using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using virtual_academy.core;
using virtual_academy.Logic.RTTransformGizmos;
using virtual_academy.VAEnv;

namespace virtual_academy.Logic
{
	public class CreatorLogic : MonoBehaviour
	{
		public static CreatorLogic instance;
		public Camera Camera;
		public Vector2 CamSpeed;
		public float MoveSpeed = 1;
		public float MoveSpeedHigh = 2;
		public float GizmosScalePara = 1;
		public float GizmosScalePara2 = 1;
		public float GizmosScaleRotParaX = 1;
		public float GizmosScaleRotParaY = 1;
		public float GizmosScaleRotParaZ = 1;
		public float GridDistance = 0.1f;
		public float GridAngle = 15f;
		public RTGizmos RTGizmos;
		public int GizmosLayer;
		public int OperateMode;
		public int SpaceMode;
		public bool IsGridBased;
		float MovementAccumulation;
		IEnumerator Start()
		{
			instance = this;
			GizmosLayer = LayerMask.GetMask("Gizmos");
			SelectedObject = null;
			yield return null;
			if (CoreData.Instance.creatorMode == CreatorMode.New || CoreData.Instance.creatorMode == CreatorMode.Edit)
			{
				SceneManager.LoadScene(CoreData.Instance.TargetBase, LoadSceneMode.Additive);
			}
			//VAEnvCore.instance.SetSky(0);
		}
		[NonSerialized]
		public PlacedObject SelectedObject = null;
		void Deselect()
		{
			if (SelectedObject != null)
			{

				SelectedObject.UnderlyingObject.IsSelected = false;
				SelectedObject = null;
				RTGizmos.gameObject.SetActive(false);
			}
		}
		Vector2 Direction;
		RTGizmosHandle currentHandle;
		void Update()
		{
			if (Input.GetMouseButton(1))
			{
				var t = Camera.transform;

				var r = t.eulerAngles;
				r.x += Input.mousePositionDelta.y * CamSpeed.y;
				r.y += Input.mousePositionDelta.x * CamSpeed.x;
				t.eulerAngles = r;
				int FWD = Input.GetKey(KeyCode.W) ? 1 : (Input.GetKey(KeyCode.S) ? -1 : 0);
				int RHT = Input.GetKey(KeyCode.D) ? 1 : (Input.GetKey(KeyCode.A) ? -1 : 0);
				int UPD = Input.GetKey(KeyCode.E) ? 1 : (Input.GetKey(KeyCode.Q) ? -1 : 0);
				var dir = new Vector3(RHT, UPD, FWD) * (Input.GetKey(KeyCode.LeftShift) ? MoveSpeedHigh : MoveSpeed) * Time.deltaTime;
				t.Translate(dir, Space.Self);
			}
			if (Input.GetMouseButtonDown(0))
			{
				if (!EventSystem.current.IsPointerOverGameObject())
				{
					Ray ray = Camera.main.ScreenPointToRay(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
					RaycastHit hit;

					if (Physics.Raycast(ray, out hit, 5000, GizmosLayer))
					{
						if (hit.transform.TryGetComponent<RTGizmosHandle>(out var handle))
						{
							this.currentHandle = handle;
							MovementAccumulation = 0;
							if (OperateMode == 2)
							{
								Direction = (Camera.WorldToScreenPoint(currentHandle.Reference.transform.position) - Camera.WorldToScreenPoint(RTGizmos.transform.position)).normalized;
							}
							else
							{
								if (currentHandle.Reference != null)
									Direction = (Camera.WorldToScreenPoint(currentHandle.Reference.transform.position) - Camera.WorldToScreenPoint(RTGizmos.transform.position)).normalized;
								else
									Direction = (Camera.WorldToScreenPoint(currentHandle.transform.position) - Camera.WorldToScreenPoint(RTGizmos.transform.position)).normalized;
							}
							goto UpdateGizmos;
						}
					}
					if (Physics.Raycast(ray, out hit, 5000, int.MaxValue))
					{
						if (hit.transform.TryGetComponent<Linker>(out var linker))
						{
							Deselect();
							linker.linked.IsSelected = true;
							SelectedObject = linker.linked.placed;
							RTGizmos.gameObject.SetActive(true);
						}
						else
						{
							Deselect();
						}
					}
					else
					{

						Deselect();
					}
				}
			}
			if (Input.GetMouseButtonUp(0))
			{
				MovementAccumulation = 0;
				currentHandle = null;
			}
			if (Input.GetMouseButton(0))
			{
				if (currentHandle != null)
				{
					var input_normalized = new Vector2(Input.mousePositionDelta.x / Screen.width, Input.mousePositionDelta.y / Screen.height);
					var movement = Vector2.Dot(input_normalized, Direction) * Vector3.Distance(Camera.transform.position, SelectedObject.UnderlyingObject.transform.position) * GizmosScalePara2;
					//Debug.Log(movement);
					switch (OperateMode)
					{
						case 1:
							MovementAccumulation += movement;
							if (IsGridBased)
							{
								if (Mathf.Abs(MovementAccumulation) > GridDistance)
								{
									if (SpaceMode == 0)
									{
										var m = ((MovementAccumulation > 0) ? GridDistance : -GridDistance);
										switch (currentHandle.TargetAxis)
										{
											case HandleAxis.X:
												SelectedObject.UnderlyingObject.transform.position += (new Vector3(m, 0, 0));
												break;
											case HandleAxis.Y:
												SelectedObject.UnderlyingObject.transform.position += (new Vector3(0, m, 0));
												break;
											case HandleAxis.Z:
												SelectedObject.UnderlyingObject.transform.position += (new Vector3(0, 0, m));
												break;
											default:
												break;
										}
									}
									else
									{
										switch (currentHandle.TargetAxis)
										{
											case HandleAxis.X:
												SelectedObject.UnderlyingObject.transform.Translate(new Vector3(GridDistance, 0, 0), Space.Self);
												break;
											case HandleAxis.Y:
												SelectedObject.UnderlyingObject.transform.Translate(new Vector3(0, GridDistance, 0), Space.Self);
												break;
											case HandleAxis.Z:
												SelectedObject.UnderlyingObject.transform.Translate(new Vector3(0, 0, GridDistance), Space.Self);
												break;
											default:
												break;
										}
									}
									MovementAccumulation = 0;
								}
							}
							else
							{

								if (SpaceMode == 0)
								{

									switch (currentHandle.TargetAxis)
									{
										case HandleAxis.X:
											SelectedObject.UnderlyingObject.transform.position += (new Vector3(movement, 0, 0));
											break;
										case HandleAxis.Y:
											SelectedObject.UnderlyingObject.transform.position += (new Vector3(0, movement, 0));
											break;
										case HandleAxis.Z:
											SelectedObject.UnderlyingObject.transform.position += (new Vector3(0, 0, movement));
											break;
										default:
											break;
									}
								}
								else
								{
									switch (currentHandle.TargetAxis)
									{
										case HandleAxis.X:
											SelectedObject.UnderlyingObject.transform.Translate(new Vector3(movement, 0, 0), Space.Self);
											break;
										case HandleAxis.Y:
											SelectedObject.UnderlyingObject.transform.Translate(new Vector3(0, movement, 0), Space.Self);
											break;
										case HandleAxis.Z:
											SelectedObject.UnderlyingObject.transform.Translate(new Vector3(0, 0, movement), Space.Self);
											break;
										default:
											break;
									}
								}
							}
							break;
						case 2:
							if (IsGridBased)
							{

								switch (currentHandle.TargetAxis)
								{
									case HandleAxis.X:
										MovementAccumulation += movement * GizmosScaleRotParaX;
										break;
									case HandleAxis.Y:
										MovementAccumulation += movement * GizmosScaleRotParaY;
										break;
									case HandleAxis.Z:
										MovementAccumulation += movement * GizmosScaleRotParaZ;
										break;
									default:
										break;
								}
								if (Mathf.Abs(MovementAccumulation) > GridAngle)
								{

									var m = ((MovementAccumulation > 0) ? GridAngle : -GridAngle);
									MovementAccumulation = 0;
									if (SpaceMode == 0)
									{
										switch (currentHandle.TargetAxis)
										{
											case HandleAxis.X:
												SelectedObject.UnderlyingObject.transform.eulerAngles += new Vector3(m, 0, 0);
												break;
											case HandleAxis.Y:
												SelectedObject.UnderlyingObject.transform.eulerAngles += (new Vector3(0, m, 0));
												break;
											case HandleAxis.Z:
												SelectedObject.UnderlyingObject.transform.eulerAngles += (new Vector3(0, 0, m));
												break;
											default:
												break;
										}
									}
									else
									{

										switch (currentHandle.TargetAxis)
										{
											case HandleAxis.X:
												SelectedObject.UnderlyingObject.transform.localEulerAngles += new Vector3(m, 0, 0);
												break;
											case HandleAxis.Y:
												SelectedObject.UnderlyingObject.transform.localEulerAngles += (new Vector3(0, m, 0));
												break;
											case HandleAxis.Z:
												SelectedObject.UnderlyingObject.transform.localEulerAngles += (new Vector3(0, 0, m));
												break;
											default:
												break;
										}
									}
								}
							}
							else
							{

								if (SpaceMode == 0)
								{
									switch (currentHandle.TargetAxis)
									{
										case HandleAxis.X:
											SelectedObject.UnderlyingObject.transform.eulerAngles += new Vector3(movement * GizmosScaleRotParaX, 0, 0);
											break;
										case HandleAxis.Y:
											SelectedObject.UnderlyingObject.transform.eulerAngles += (new Vector3(0, movement * GizmosScaleRotParaY, 0));
											break;
										case HandleAxis.Z:
											SelectedObject.UnderlyingObject.transform.eulerAngles += (new Vector3(0, 0, movement * GizmosScaleRotParaZ));
											break;
										default:
											break;
									}
								}
								else
								{

									switch (currentHandle.TargetAxis)
									{
										case HandleAxis.X:
											SelectedObject.UnderlyingObject.transform.localEulerAngles += new Vector3(movement * GizmosScaleRotParaX, 0, 0);
											break;
										case HandleAxis.Y:
											SelectedObject.UnderlyingObject.transform.localEulerAngles += (new Vector3(0, movement * GizmosScaleRotParaY, 0));
											break;
										case HandleAxis.Z:
											SelectedObject.UnderlyingObject.transform.localEulerAngles += (new Vector3(0, 0, movement * GizmosScaleRotParaZ));
											break;
										default:
											break;
									}
								}
							}
							break;
						case 3:
							if (IsGridBased)
							{

								MovementAccumulation += movement;
								if (Mathf.Abs(MovementAccumulation) > GridDistance)
								{

									var m = ((MovementAccumulation > 0) ? GridDistance : -GridDistance);
									MovementAccumulation = 0;
									switch (currentHandle.TargetAxis)
									{
										case HandleAxis.X:
											SelectedObject.UnderlyingObject.transform.localScale += (new Vector3(m, 0, 0));
											break;
										case HandleAxis.Y:
											SelectedObject.UnderlyingObject.transform.localScale += (new Vector3(0, m, 0));
											break;
										case HandleAxis.Z:
											SelectedObject.UnderlyingObject.transform.localScale += (new Vector3(0, 0, m));
											break;
										case HandleAxis.All:
											SelectedObject.UnderlyingObject.transform.localScale += (new Vector3(m, m, m));
											break;
										default:
											break;
									}
								}
							}
							else
							{

								switch (currentHandle.TargetAxis)
								{
									case HandleAxis.X:
										SelectedObject.UnderlyingObject.transform.localScale += (new Vector3(movement, 0, 0));
										break;
									case HandleAxis.Y:
										SelectedObject.UnderlyingObject.transform.localScale += (new Vector3(0, movement, 0));
										break;
									case HandleAxis.Z:
										SelectedObject.UnderlyingObject.transform.localScale += (new Vector3(0, 0, movement));
										break;
									case HandleAxis.All:
										SelectedObject.UnderlyingObject.transform.localScale += (new Vector3(movement, movement, movement));
										break;
									default:
										break;
								}
							}
							break;
						default:
							break;
					}
				}
			}
			if (Input.GetKeyDown(KeyCode.Delete))
			{
				if (EventSystem.current.currentSelectedGameObject == null)
				{
					var tgt = SelectedObject;
					Deselect();
					VAEnvCore.instance.DeleteObject(tgt);
				}
			}
		UpdateGizmos:
			if (SelectedObject != null)
			{
				RTGizmos.transform.position = SelectedObject.UnderlyingObject.transform.position;
				if (SpaceMode == 1 || OperateMode == 3)
				{
					RTGizmos.transform.rotation = SelectedObject.UnderlyingObject.transform.rotation;
				}
				else
				{
					RTGizmos.transform.rotation = Quaternion.identity;

				}
				RTGizmos.transform.localScale =
					GizmosScalePara * Vector3.Distance(Camera.transform.position, SelectedObject.UnderlyingObject.transform.position) * Vector3.one;
			}
		}
	}
}
