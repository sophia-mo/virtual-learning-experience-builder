using System;
using UnityEngine;
using virtual_academy.core;

namespace virtual_academy.UI
{
	public class CharacterList : MonoBehaviour
	{
		public Transform Presenter;
		public ButtonGroup ButtonGroup;
		public IconedToggleButton ButtonPrototype;
		public Sprite CharacterImage;
		[NonSerialized]
		public int ID=-1;
		int startElementCount = 0;
		public void Start()
		{
			ButtonGroup.OnSelect = (id) => ID = id;
			startElementCount = Presenter.childCount;
			Load();
		}
		public void Load()
		{

			CharacterManager.instance.RebuildDB();
			foreach (var item in CharacterManager.instance.CharacterDefinitions)
			{
				var btn = Instantiate(ButtonPrototype, Presenter);
				btn.IconImage.sprite = CharacterImage;
				btn.Title.text = $"Name:{item.Name}\nHeight:{item.Height}\nJump:{item.JumpHeight}\nSpeed:{item.Speed}";
				ButtonGroup.AddButton(btn);
			}
		}
		public void Reload()
		{
			ButtonGroup.Buttons.Clear();
			for (int i = Presenter.childCount - 1; i >= startElementCount; i--)
			{
				Destroy(Presenter.GetChild(i).gameObject);
			}
			Load();
		}
	}
}
