using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using virtual_academy.core;
using virtual_academy.core.EFI;

namespace virtual_academy.UI
{
	public class MainMenu : MonoBehaviour
	{
		public Button PlayerB0;
		public Button CreatorB0;
		public Button OktaUIButton;
		public Button BackOnWorldSelect;
		public Button BackOnWorldCreate;
		public Button BackOnCharaSel;
		public Button CreateMapButton;
		public Button EnterMapButton;
		public Button EditMapButton;
		public Button DelMapButton;
		public Button NewCharacterButton;
		public Button EditCharacterButton;
		public Button DelCharacterButton;
		public Button ExitButton;
		public GameObject OktaUI;
		public GameObject NormalUI;
		public Button NewWorldButtonInWorldSelection;
		public Button EnterPlayButton;
		public List<GameObject> Pages;
		public int WorldLoadPage;
		public int NewWorldPage;
		public int CharacterPage;
		Action OktaUIButtonAction = null;
		public MapCreateUI ExistingWorldSelectionUI;
		public MapCreateUI NewWorldSelectionUI;
		public CharacterList CharacterList;
		void Start()
		{
			CreatorB0.onClick.AddListener(() =>
			{
				ShowOtka(() =>
				{
					NewWorldButtonInWorldSelection.gameObject.SetActive(true);
					EditMapButton.gameObject.SetActive(true);
					DelMapButton.gameObject.SetActive(true);
					NewCharacterButton.gameObject.SetActive(true);
					EditCharacterButton.gameObject.SetActive(true);
					DelCharacterButton.gameObject.SetActive(true);
					ShowPage(WorldLoadPage);
				});
			});
			PlayerB0.onClick.AddListener(() =>
			{
				ShowOtka(() =>
				{
					NewWorldButtonInWorldSelection.gameObject.SetActive(false);
					EditMapButton.gameObject.SetActive(false);
					DelMapButton.gameObject.SetActive(false);
					NewCharacterButton.gameObject.SetActive(false);
					EditCharacterButton.gameObject.SetActive(false);
					DelCharacterButton.gameObject.SetActive(false);
					ShowPage(WorldLoadPage);
				});
			});
			NewWorldButtonInWorldSelection.onClick.AddListener(() =>
			{
				ShowPage(NewWorldPage);
			});
			BackOnWorldSelect.onClick.AddListener(() =>
			{
				ShowPage(0);
			});
			BackOnWorldCreate.onClick.AddListener(() =>
			{
				ShowPage(WorldLoadPage);
			});
			BackOnCharaSel.onClick.AddListener(() =>
			{
				ShowPage(WorldLoadPage);
			});
			OktaUIButton.onClick.AddListener(() =>
			{
				NormalUI.SetActive(true);
				OktaUI.SetActive(false);
				OktaUIButtonAction?.Invoke();
			});
			CreateMapButton.onClick.AddListener(() =>
			{
				CoreData.Instance.creatorMode = CreatorMode.New;
				CoreData.Instance.TargetBase = EnvironmentResources.Instance.realBaseSceneIDs[NewWorldSelectionUI.ID];
				CoreData.Instance.TargetWorld = null;
				SceneManager.LoadScene(SceneDefinitions.instance.CreatorUISceneID);
			});
			EditMapButton.onClick.AddListener(() =>
			{
				var id = ExistingWorldSelectionUI.ID;
				if (id < 0) return;
				CoreData.Instance.creatorMode = CreatorMode.Edit;
				CoreData.Instance.TargetWorld = MapCache.Instance.MapFolders[id];
				CoreData.Instance.TargetBase = MapCache.Instance.MapMetadatas[id].BaseMapID;
				//Debug.Log($"TargetBase:{CoreData.Instance.TargetBase},Cache Meta:k{MapCache.Instance.MapMetadatas[id].BaseMapID}");
				SceneManager.LoadScene(SceneDefinitions.instance.CreatorUISceneID);
			});
			EnterMapButton.onClick.AddListener(() =>
			{
				var id = ExistingWorldSelectionUI.ID;
				Debug.Log(id);
				if (id < 0) return;
				ShowPage(CharacterPage);
			});
			EnterPlayButton.onClick.AddListener(() =>
			{
				var id = ExistingWorldSelectionUI.ID;
				CoreData.Instance.TargetCharacterID = CharacterList.ID;
				if (CharacterList.ID < 0)
					return;
				if (id < 0) return;
				CoreData.Instance.TargetWorld = MapCache.Instance.MapFolders[id];
				CoreData.Instance.TargetBase = MapCache.Instance.MapMetadatas[id].BaseMapID;
				SceneManager.LoadScene(SceneDefinitions.instance.PlayerUISceneID);

			});
			EditCharacterButton.onClick.AddListener(() =>
			{
				CoreData.Instance.TargetCharacterID = CharacterList.ID;
				if (CharacterList.ID < 0) return;
				SceneManager.LoadScene(SceneDefinitions.instance.PlayerEditID);

			});
			NewCharacterButton.onClick.AddListener(() =>
			{
				CoreData.Instance.TargetCharacterID = -1;
				SceneManager.LoadScene(SceneDefinitions.instance.PlayerEditID);
			});
			DelMapButton.onClick.AddListener(() =>
			{
				var id = ExistingWorldSelectionUI.ID;
				if (id >= 0)
				{

					DialogManager.Instance.ShowOptionDialog("Are you sure to delete?", "The map will be permanently deleted!", 400, 200,
						"Yes", () =>
					{
						MapCache.Instance.RemoveMap(id);
						ExistingWorldSelectionUI.Reload();
					},
						"Cancel", () =>
						{
						});
				}
			});
			DelCharacterButton.onClick.AddListener(() =>
			{
				var id = CharacterList.ID;
				if (id >= 0)
				{

					DialogManager.Instance.ShowOptionDialog("Are you sure to delete?", "This character will be permanently deleted!", 400, 200,
						"Yes", () =>
					{
						CharacterManager.instance.CharacterDefinitions.RemoveAt(id);
						CharacterManager.instance.CommitChanges();
						CharacterList.Reload();
					},
						"Cancel", () =>
						{
						});
				}
			});
			ExitButton.onClick.AddListener(() =>
			{
				DialogManager.Instance.ShowOptionDialog("Exit?", "Are you sure to exit?", 400, 175,
					"Yes", () => { Application.Quit(0); },
					"Cancel", () =>
					{
					});
			});
		}
		public void ShowPage(int PageID)
		{
			for (int i = 0; i < Pages.Count; i++)
			{
				GameObject item = Pages[i];
				item.SetActive(i == PageID);
			}
		}
		public void ShowOtka(Action onClick)
		{
			OktaUIButtonAction = onClick;
			NormalUI.SetActive(false);
			OktaUI.SetActive(true);
		}

	}
}
