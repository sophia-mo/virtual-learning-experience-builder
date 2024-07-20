using UnityEngine;
using UnityEngine.UI;

namespace virtual_academy.UI
{
	public class Expander : MonoBehaviour
	{
		public float RotationIntensity;
		public float RotationThreshold;
		public Button MainButton;
		public ExpandablePanel ParentObject;
		public GameObject Icon;
		public Vector3 IconExpandRotation;
		public Vector3 IconFoldedRotation;
		public GameObject ControlledObject;
		void Start()
		{
			MainButton.onClick.AddListener(() =>
			{
				ControlledObject.SetActive(!ControlledObject.activeSelf);
				ParentObject.UpdateContent();
			});
		}
		private void Update()
		{
			if (Icon == null) return;
			var tgt = (ControlledObject.activeSelf ? IconExpandRotation : IconFoldedRotation);
			var delta = tgt - Icon.transform.localEulerAngles;
			if (delta.sqrMagnitude < RotationThreshold)
			{
				return;
			}
			Icon.transform.localEulerAngles += delta * RotationIntensity;

		}
	}
}
