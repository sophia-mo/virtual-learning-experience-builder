using System;
using UnityEngine;
using UnityEngine.UI;

namespace virtual_academy.UI.Controls
{
	public class ToggleButton : MonoBehaviour
	{
		public Toggle UnderlyingToggle;
		public GameObject OnIndicator;
		public Action<bool> OnToggle;
		void Start()
		{
			OnIndicator.SetActive(UnderlyingToggle.isOn);
			UnderlyingToggle.onValueChanged.AddListener((v) =>
			{
				OnIndicator.SetActive(v);
				OnToggle?.Invoke(v);
			});
		}
		public void ApplyIndicator(bool enabled)
		{
			OnIndicator?.SetActive(enabled);
		}
	}
}
