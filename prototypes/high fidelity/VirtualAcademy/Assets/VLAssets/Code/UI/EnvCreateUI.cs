using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using virtual_academy.core;
using virtual_academy.core.EFI;
using virtual_academy.Logic;
using virtual_academy.VAEnv;

namespace virtual_academy.UI
{
	public class EnvCreateUI : MonoBehaviour
	//, IDialogHost
	{
		public Button MenuButton;
		public GameObject MenuObject;
		public Button MenuCancel;
		public Button HelpButton;
		public Button ConfigButton;
		public Button ExitButton;
		public Button RenameButton;
		public Button SaveButton;
		public Button SaveAsButton;
		public ButtonGroup RTTransformModeSelector;
		public TogglableButton GridButton;
		public Transform AssetBrowser;
		public IconedButton AssetButtonIcon;
		public StateButton SpaceStateButton;
		public Sprite GoBackIcon;
		public TreeViewNode TreeRoot;
		public Text TimerText;
		public DateTime LastTime;
		public GameObject HelpDialogWin;
		public GameObject ConfigWin;
		//public List<DialogWin> Dialogs;
		[NonSerialized]
		TreeViewNode currentNode = null;
		public void ShowAssetFolder()
		{
			for (int i = AssetBrowser.childCount - 1; i >= 0; i--)
			{
				Destroy(AssetBrowser.GetChild(i).gameObject);
			}
			if (currentNode == null)
			{
				currentNode = TreeRoot;
			}
			if (currentNode == TreeRoot)
			{
			}
			else
			{
				{

					var obj = Instantiate(AssetButtonIcon.gameObject, AssetBrowser);
					var btn = obj.GetComponent<IconedButton>();
					btn.icon.sprite = GoBackIcon;
					btn.Title.text = "Go upper level";
					btn.btn.onClick.AddListener(() =>
					{
						if (currentNode != null)
						{
							currentNode = currentNode.Parent;
						}

						ShowAssetFolder();
					});
				}

			}
			if (currentNode.IsFolder)
			{

				foreach (var item in currentNode.Children)
				{
					var obj = Instantiate(AssetButtonIcon.gameObject, AssetBrowser);
					var btn = obj.GetComponent<IconedButton>();
					btn.icon.sprite = item.Value.Icon;
					btn.Title.text = item.Value.DispName;
					btn.btn.onClick.AddListener(() =>
					{
						currentNode = item.Value;
						ShowAssetFolder();
					});
				}
			}
			else
			{
				switch (currentNode.ContentType)
				{
					case TreeViewNodeContent.AllPlacables:
						{
							foreach (var item in CreatorResourceDefinition.Instance.realObjectSet)
							{

								var obj = Instantiate(AssetButtonIcon.gameObject, AssetBrowser);
								var btn = obj.GetComponent<IconedButton>();
								btn.icon.sprite = item.Value.Icon;
								btn.Title.text = item.Value.Name;
								btn.btn.onClick.AddListener(() =>
								{
									Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
									if (Physics.Raycast(ray, out RaycastHit hit, 5))
									{
										VAEnvCore.instance.PlaceObject(item.Key, hit.point);
									}
									else
									{
										var pos = CreatorLogic.instance.Camera.transform.position + ray.direction * 5;
										VAEnvCore.instance.PlaceObject(item.Key, pos);
									}

								});
							}
						}
						break;
					case TreeViewNodeContent.ExternalPictures:
						{
							ExternalPictureCache.Instance.RebuildCache();
							for (int i = 0; i < ExternalPictureCache.Instance.Names.Count; i++)
							{
								int id = i;
								string name = ExternalPictureCache.Instance.Names[i];
								Sprite icon = ExternalPictureCache.Instance.GetSprite(i);

								var obj = Instantiate(AssetButtonIcon.gameObject, AssetBrowser);
								var btn = obj.GetComponent<IconedButton>();
								btn.icon.sprite = icon;
								btn.Title.text = name;
								btn.btn.onClick.AddListener(() =>
								{
									Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
									RaycastHit hit;

									if (Physics.Raycast(ray, out hit, 5))
									{
										VAEnvCore.instance.PlacePicture(id, hit.point);
									}
									else
									{
										var pos = CreatorLogic.instance.Camera.transform.position + ray.direction * 5;
										VAEnvCore.instance.PlacePicture(id, pos);
									}

								});
							}
						}
						break;
					case TreeViewNodeContent.SelectedPlacables:
						{

							foreach (var item in currentNode.Placables)
							{
								var realObj = CreatorResourceDefinition.Instance.realObjectSet[item];
								var obj = Instantiate(AssetButtonIcon.gameObject, AssetBrowser);
								var btn = obj.GetComponent<IconedButton>();
								btn.icon.sprite = realObj.Icon;
								btn.Title.text = realObj.Name;
								btn.btn.onClick.AddListener(() =>
								{
									Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
									RaycastHit hit;

									if (Physics.Raycast(ray, out hit, 5))
									{
										VAEnvCore.instance.PlaceObject(item, hit.point);
									}
									else
									{
										var pos = CreatorLogic.instance.Camera.transform.position + ray.direction * 5;
										VAEnvCore.instance.PlaceObject(item, pos);
									}

								});
							}
						}
						break;
					default:
						break;
				}
			}
		}
		void Start()
		{
			CurrentMap = CoreData.Instance.TargetWorld;
			MenuButton.onClick.AddListener(() =>
			{
				MenuObject.SetActive(!MenuObject.activeSelf);
			});
			MenuCancel.onClick.AddListener(CloseMenu);
			ConfigButton.onClick.AddListener(() =>
			{
				var (ConfObj, win) = DialogManager.Instance.ShowDialog(ConfigWin);
				var mapUI = ConfObj.GetComponentInChildren<MapCreateUI>();
				mapUI.OnSelect = (id) => { VAEnvCore.instance.SetSky(id); };
				CloseMenu();
			});
			HelpButton.onClick.AddListener(() =>
			{
				DialogManager.Instance.ShowDialog(HelpDialogWin);
				CloseMenu();
			});
			ExitButton.onClick.AddListener(() =>
			{
				if (VAEnvCore.instance.World.Count > 0)
				{
					CloseMenu();
					DialogManager.Instance.ShowOptionDialog("Are you sure to exit?", "Continue on exit will lose unsaved work!",
					400, 150, "OK", () =>
					{
						SceneManager.LoadScene(SceneDefinitions.instance.MainUISceneID);
					}, "Cancel", () => { });
				}
			});
			TreeRoot.Init();
			currentNode = null;
			ShowAssetFolder();
			RTTransformModeSelector.OnSelect = (i) =>
			{
				CreatorLogic.instance.RTGizmos.SetMode(i);
				CreatorLogic.instance.OperateMode = i;
			};
			GridButton.OnToggle = (v) =>
			{
				CreatorLogic.instance.IsGridBased = v;
			};
			SpaceStateButton.OnStateChange = (id) =>
			{
				CreatorLogic.instance.SpaceMode = id;
			};
			if (SaveButton != null)
			{
				SaveButton.onClick.AddListener(() => { Save(); });
			}
			if (SaveAsButton != null)
			{
				SaveAsButton.onClick.AddListener(() => { SaveAs(); });
			}
			if (RenameButton != null)
			{
				RenameButton.onClick.AddListener(() =>
				{
					Rename();
				});
			}
			StartCoroutine(__start());
		}
		IEnumerator __start()
		{
			yield return null;
			if (CoreData.Instance.creatorMode == CreatorMode.Edit)
			{
				MapName = VAEnvCore.instance.LoadMap(CurrentMap);
			}
		}
		[NonSerialized]
		public string CurrentMap = null;
		public void Rename()
		{
			DialogManager.Instance.ShowInputOptionDialog("Rename the map as...", 
				"Give the map a new name:\nNote: Renaming will save the map.", 500, 200, "OK", (s) =>
			{
				MapName = s;
				VAEnvCore.instance.RenameMap(CurrentMap, MapName);
				CloseMenu();
			},
				"Cancel", () =>
				{
					CloseMenu();
				});
		}
		public void Save()
		{
			if (CurrentMap == null)
			{
				SaveAs();
				return;
			}
			if (CurrentMap == null)
			{
				return;
			}
			VAEnvCore.instance.SaveMap(CurrentMap, MapName);
		}
		public string MapName = null;
		public void SaveAs()
		{
			DialogManager.Instance.ShowInputOptionDialog("Save the map as...", "Input Map Name:", 500, 200, "OK", (s) =>
			{
				MapName = s;
				var mapfolder = StorageManager.Instance.PrepareNewMapFolder();
				CurrentMap = mapfolder;
				Save();
				CloseMenu();

			},
				"Cancel", () =>
				{
					CloseMenu();
				});
		}
		public void CloseMenu()
		{
			MenuObject.SetActive(false);
		}
		//public void ShowDialog(int dialog)
		//{
		//	CloseDialog();
		//	BaseDialog.gameObject.SetActive(true);
		//	Dialogs[dialog].gameObject.SetActive(true);
		//}
		public void Update()
		{
			DateTime now = DateTime.Now;
			if (LastTime.Second != now.Second)
			{
				LastTime = now;
				TimerText.text = now.ToString();
			}
		}
	}
	public interface IDialogHost
	{
		void CloseDialog(IDialogWin win);
		(GameObject, IDialogWin) ShowDialog(GameObject Prefab);
	}
	public interface IDialogWin
	{
		void OnShow();
		GameObject GObject { get; }
		void Init(IDialogHost host);
		IEnumerator OnClose();
	}
}
