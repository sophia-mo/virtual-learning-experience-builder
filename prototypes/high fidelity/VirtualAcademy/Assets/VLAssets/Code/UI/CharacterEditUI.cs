using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using virtual_academy.core;
using virtual_academy.core.Data;
using virtual_academy.core.EFI;

namespace virtual_academy
{
	public class CharacterEditUI : MonoBehaviour
	{
		public Button GoBackButton;
		public Button MenuButton;
		public Button MenuBackground;
		public Button SaveButton;
		public Button SaveAsButton;
		public Button RenameButton;
		public Slider HeightSlider;
		public InputField Height;
		public Slider JumpHeightSlider;
		public InputField JumpHeight;
		public Slider SpeedSlider;
		public InputField Speed;
		public GameObject MenuObject;
		public Transform CharacterExample;

		public float BaseModelHeight = 1.47f;
		[NonSerialized]
		CharacterDefinition cd = null;
		void Start()
		{
			if (CoreData.Instance.TargetCharacterID == -1)
			{
				cd = new CharacterDefinition();
				cd.Height = 1.47f;
				cd.JumpHeight = 0.5f;
				cd.Speed = 7.2f;
			}
			else
			{
				cd = CharacterManager.instance.CharacterDefinitions[CoreData.Instance.TargetCharacterID];
			}
			HeightSlider.value = cd.Height;
			JumpHeightSlider.value = cd.JumpHeight;
			SpeedSlider.value = cd.Speed;
			Height.text = $"{cd.Height}";
			JumpHeight.text = $"{cd.JumpHeight}";
			Speed.text = $"{cd.Speed}";
			HeightSlider.onValueChanged.AddListener((v) =>
			{
				cd.Height = v;
				Height.text = $"{cd.Height}";
				ApplyCharacter();
			});
			JumpHeightSlider.onValueChanged.AddListener((v) =>
			{
				cd.JumpHeight = v;
				JumpHeight.text = $"{cd.JumpHeight}";
				ApplyCharacter();
			});
			SpeedSlider.onValueChanged.AddListener((v) =>
			{
				cd.Speed = v;
				Speed.text = $"{cd.Speed}";
				ApplyCharacter();
			});
			Height.onSubmit.AddListener((v) =>
			{
				if (float.TryParse(v, out var f))
				{
					cd.Height = f;
					HeightSlider.value = f;
				}
			});
			JumpHeight.onSubmit.AddListener((v) =>
			{

				if (float.TryParse(v, out var f))
				{
					cd.JumpHeight = f;
					JumpHeightSlider.value = f;
				}
			});
			Speed.onSubmit.AddListener((v) =>
			{
				if (float.TryParse(v, out var f))
				{
					cd.Speed = f;
					SpeedSlider.value = f;
				}
			});
			SaveButton.onClick.AddListener(() =>
			{
				Save();
				MenuObject.SetActive(false);
			});
			SaveAsButton.onClick.AddListener(() =>
			{
				SaveAs();
				MenuObject.SetActive(false);
			});

			RenameButton.onClick.AddListener(() =>
			{
				Rename();
				MenuObject.SetActive(false);
			});
			MenuButton.onClick.AddListener(() =>
			{
				MenuObject.SetActive(true);
			});
			MenuBackground.onClick.AddListener(() =>
			{
				MenuObject.SetActive(false);
			});
			GoBackButton.onClick.AddListener(() =>
			{
				DialogManager.Instance.ShowOptionDialog("Are you sure to exit?", "All unsaved work will be lost!",
				400, 150, "OK", () =>
				{
					SceneManager.LoadScene(SceneDefinitions.instance.MainUISceneID);
				}, "Cancel", () => { });
			});
			ApplyCharacter();
		}

		public void Rename()
		{
			DialogManager.Instance.ShowInputOptionDialog("Rename the map as...", "Give the map a new name:\nNote: Renaming will save the map.", 500, 300, "OK", (s) =>
			{
				cd.Name = s;
				CharacterManager.instance.CharacterDefinitions[CoreData.Instance.TargetCharacterID] = cd;
				CharacterManager.instance.CommitChanges();
			},
				"Cancel", () =>
				{
				});
		}
		void Save()
		{
			if (CoreData.Instance.TargetCharacterID == -1)
			{
				SaveAs();
				return;
			}
			if (CoreData.Instance.TargetCharacterID == -1)
			{
				return;
			}
			CharacterManager.instance.CharacterDefinitions[CoreData.Instance.TargetCharacterID] = cd;
			CharacterManager.instance.CommitChanges();
		}
		void SaveAs()
		{
			DialogManager.Instance.ShowInputOptionDialog("Name the character", "Give the character a name:", 600, 350,
				"OK", (v) =>
				{
					var oldCD = cd;
					cd = new CharacterDefinition
					{
						Name = v,
						Height = oldCD.Height,
						JumpHeight = oldCD.JumpHeight,
						Speed = oldCD.Speed
					};
					CharacterManager.instance.CharacterDefinitions.Add(cd);
					CoreData.Instance.TargetCharacterID = CharacterManager.instance.CharacterDefinitions.Count - 1;
					CharacterManager.instance.CommitChanges();
				}, "Cancel", () => { });
		}
		void ApplyCharacter()
		{
			CharacterExample.localScale = new Vector3(1, cd.Height / BaseModelHeight, 1);
		}
	}
}
