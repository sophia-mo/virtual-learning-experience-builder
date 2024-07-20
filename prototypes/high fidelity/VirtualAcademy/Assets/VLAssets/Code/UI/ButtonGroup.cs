using System;
using System.Collections.Generic;
using UnityEngine;

namespace virtual_academy.UI
{
	public class ButtonGroup : MonoBehaviour
	{
		public string OutlineName = "Outline";
		public List<TogglableButton> Buttons;
		public Action<int> OnSelect;
		public void Start()
		{
			for (int i = 0; i < Buttons.Count; i++)
			{
				int id = i;
				var button = Buttons[i];
				button.IsOverrideBehavior = true;
				button.Button.onClick.AddListener(() =>
				{
					Highlight(id);
					OnSelect?.Invoke(id);
				});
			}
		}
		public void AddButton(TogglableButton button)
		{
			Buttons.Add(button);
			var id=Buttons.Count-1;
			button.IsOverrideBehavior = true;
			button.Button.onClick.AddListener(() =>
			{
				Highlight(id);
				OnSelect?.Invoke(id);
			});
		}
		public void Highlight(int id)
		{
			for (int i = 0; i < Buttons.Count; i++)
			{
				var button = Buttons[i];
				button.IsOn = i == id;
			}
		}
	}
}
