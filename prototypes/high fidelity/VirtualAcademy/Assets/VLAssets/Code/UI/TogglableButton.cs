using System;
using UnityEngine;
using UnityEngine.UI;

namespace virtual_academy.UI
{
	public class TogglableButton : MonoBehaviour
	{
		public Button Button;
		public GameObject Outline;
		public bool IsOverrideBehavior = false;
		public Action<bool> OnToggle = null;
		public void Start()
		{
			Button.onClick.AddListener(() =>
			{
				if (IsOverrideBehavior) { return; }
				IsOn = !IsOn;
				OnToggle?.Invoke(IsOn);
			});
		}
		public bool IsOn
		{
			get => Outline.activeSelf;
			set => Outline.SetActive(value);
		}
	}
}
