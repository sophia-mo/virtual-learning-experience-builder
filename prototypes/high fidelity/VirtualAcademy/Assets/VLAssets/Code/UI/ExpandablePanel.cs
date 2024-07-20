using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace virtual_academy.UI
{
	public class ExpandablePanel : MonoBehaviour
	{
		public float RotationIntensity = 0.1f;
		public float RotationThreshold = 1f;
		public float SizeIntensity = 0.1f;
		public float SizeThreshold = 4f;
		public Button Button;
		public GameObject Contents;
		public GameObject Child;
		public GameObject Icon;
		public Vector3 IconExpandRotation;
		public Vector3 IconFoldedRotation;
		public RectTransform ControlledTransform;
		public Vector2 ExpandedSize = new Vector2(350, 1060);
		public Vector2 FoldedSize = new Vector2(350, 30);
		void Start()
		{
			Button.onClick.AddListener(() =>
			{
				Child.SetActive(!Child.activeSelf);
				//if (Child.activeSelf)
				//{
				//	ControlledTransform.sizeDelta = ExpandedSize;
				//}
				//else
				//{
				//	ControlledTransform.sizeDelta = FoldedSize;
				//}
			});
		}
		private void Update()
		{

			if (Icon != null)
			{
				var tgt = (Child.activeSelf ? IconExpandRotation : IconFoldedRotation);
				var delta = tgt - Icon.transform.localEulerAngles;
				if (delta.sqrMagnitude > RotationThreshold)
				{
					Icon.transform.localEulerAngles += delta * RotationIntensity;

				}
			}
			{
				var tgt = (Child.activeSelf ? ExpandedSize : FoldedSize);
				var delta = tgt - ControlledTransform.sizeDelta;
				if (delta.sqrMagnitude > SizeThreshold)
				{
					ControlledTransform.sizeDelta += delta * SizeIntensity;
				}
			}
		}
		public void UpdateContent()
		{
			StartCoroutine(__UpdateContent());
		}
		IEnumerator __UpdateContent()
		{
			{
				yield return null;
				Contents.SetActive(false);
				yield return null;
				Contents.SetActive(true);
			}
		}
	}
}
