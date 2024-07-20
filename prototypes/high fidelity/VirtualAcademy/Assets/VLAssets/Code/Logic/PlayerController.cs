using UnityEngine;
using UnityEngine.UI;
using virtual_academy.core;
using virtual_academy.core.Data;
using virtual_academy.VAEnv;

namespace virtual_academy.Logic
{
	public class PlayerController : MonoBehaviour
	{
		public static PlayerController instance;
		public CharacterController controlledCharacter;
		public CapsuleCollider CapsuleCollider;
		public Camera MainCam;
		public Transform HeadV;
		CharacterDefinition CharacterDefinition = null;
		public float JumpTime = 0.25f;
		public float RealSpeed = 0;
		public float Speed;
		public float FallSpeed = 2f;
		public float HorizontalSpeed = 10f;
		public float VerticalSpeed = 10f;
		public Vector2 VerticalRange;
		public GameObject HelpObject;
		public Text Hint;
		void Start()
		{
			instance = this;
			try
			{
				CharacterDefinition = CharacterManager.instance.CharacterDefinitions[CoreData.Instance.TargetCharacterID];
			}
			catch (System.Exception)
			{
				CharacterDefinition = new CharacterDefinition
				{
					Height = 1.47f,
					JumpHeight = 0.5f,
					Speed = 7.2f
				};
			}
			if (CharacterDefinition.JumpHeight != 0)
			{
				SpeedV = CharacterDefinition.JumpHeight / JumpTime;
			}
			else
			{
				SpeedV = 0;
			}
			RealSpeed = CharacterDefinition.Speed * 1000f / 3600f;
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
			controlledCharacter.height = CharacterDefinition.Height;
			CapsuleCollider.height = CharacterDefinition.Height;
			HeadV.transform.localPosition = new Vector3(0, (CapsuleCollider.height / 2) * 0.9f, 0);
		}
		float SpeedV;
		bool IsJump = false;
		float StartTime;
		bool __lastIsGrounded = true;
		public bool IsReleased = false;
		public bool IsPaused = false;
		public void SetPause(bool V)
		{
			IsPaused = V;
			if (V)
			{
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
			}
			else
			{

				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
			}
		}
		public void ToggleMouse()
		{
			IsReleased = !IsReleased;
			if (IsReleased)
			{
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
			}
			else
			{
				Cursor.lockState = CursorLockMode.Locked;
				Cursor.visible = false;
			}
		}
		string HintText = null;
		void Update()
		{
			if (IsPaused) return;
			if (Input.GetKeyDown(KeyCode.AltGr) || Input.GetKeyDown(KeyCode.LeftAlt) || Input.GetKeyDown(KeyCode.RightAlt))
			{
				ToggleMouse();
			}
			if (Input.GetKeyDown(KeyCode.H))
			{
				HelpObject.SetActive(!HelpObject.activeSelf);
			}
			if (IsReleased) return;
			bool isGrounded = controlledCharacter.isGrounded;
			float DT = Time.deltaTime;
			if (__lastIsGrounded != isGrounded)
			{
				__lastIsGrounded = isGrounded;

			};
			Vector3 FinalMovemovement = Vector3.zero;
			if (isGrounded)
				if (Input.GetButtonDown("Jump"))
				{
					IsJump = true;
					StartTime = 0;
				}
			if (!isGrounded)
			{
				if (IsJump)
				{
					StartTime += DT;
					FinalMovemovement = controlledCharacter.transform.up * SpeedV;
					if (StartTime >= JumpTime)
					{
						IsJump = false;
					}
				}
				else
				{
					FinalMovemovement = -FallSpeed * controlledCharacter.transform.up;
				}
			}
			FinalMovemovement += Input.GetAxis("Vertical") * RealSpeed * controlledCharacter.transform.forward;
			FinalMovemovement += Input.GetAxis("Horizontal") * RealSpeed * controlledCharacter.transform.right;
			controlledCharacter.Move(FinalMovemovement * DT);
			{
				var H = Input.GetAxis("Mouse X");
				controlledCharacter.transform.Rotate(new Vector3(0, H * HorizontalSpeed * Time.smoothDeltaTime, 0), Space.Self);
			}
			{
				var V = Input.GetAxis("Mouse Y");
				var r = HeadV.localEulerAngles;
				r += new Vector3(V * VerticalSpeed * DT, 0, 0);
				var x = r.x;
				if (x > 180) { x -= 360f; }
				r.x = Mathf.Max(VerticalRange.x, Mathf.Min(VerticalRange.y, x));
				HeadV.localEulerAngles = r;
			}
			{
				Ray ray = MainCam.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

				if (Physics.Raycast(ray, out RaycastHit hit, 10))
				{
					InteractableObject inter;
					bool IsTransitive = false;
					if ((inter = hit.transform.GetComponentInChildren<InteractableObject>()) != null)
					{
						(inter, IsTransitive) = GetInteractableObject(inter);
						if (inter != null)
						{
							if (inter.IsDirectlyOperatable || IsTransitive)
							{

								if (!Hint.gameObject.activeSelf)
								{
									Hint.gameObject.SetActive(true);
								}
								if (HintText != inter.Hint)
								{
									HintText = inter.Hint;
									Hint.text = HintText;
								}
								if (Input.GetKeyDown(KeyCode.E))
								{
									inter.Operate();
								}
							}
							else
							{
								if (Hint.gameObject.activeSelf)
									Hint.gameObject.SetActive(false);
							}
						}
						else
						{
							if (Hint.gameObject.activeSelf)
								Hint.gameObject.SetActive(false);
						}
					}
					else
					{
						if (Hint.gameObject.activeSelf)
							Hint.gameObject.SetActive(false);
					}
				}
			}
		}
		public (InteractableObject, bool) GetInteractableObject(InteractableObject interactableObject)
		{
			if (interactableObject == null) return (null, false);
			if (interactableObject is TransitiveInteractableObject tobj)
			{
				if (tobj.IsDirectlyOperatable)
				{
					return (null, false);
				}
				return (GetInteractableObject(tobj.passToObject.UnderlyingObject.GetComponentInChildren<InteractableObject>()).Item1, true);
			}
			return (interactableObject, false);
		}
	}
}
