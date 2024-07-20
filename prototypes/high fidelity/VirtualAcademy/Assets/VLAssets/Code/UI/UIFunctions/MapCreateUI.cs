using System;
using System.Collections.Generic;
using UnityEngine;
using virtual_academy.core;
using virtual_academy.core.EFI;
using virtual_academy.UI;

namespace virtual_academy
{
	public class MapCreateUI : MonoBehaviour
	{
		public ButtonGroup ButtonGroup;
		public IconedToggleButton MapButton;
		public LoadType RersourceToLoad;
		public Transform Presenter;
		[NonSerialized]
		public int ID = -1;
		public Action<int> OnSelect = null;
		public List<int> IDs;
		int startElementCount = 0;
		void Start()
		{
			ButtonGroup.OnSelect = (id) =>
			{
				ID = IDs[id];
				OnSelect?.Invoke(ID);
			};
			startElementCount = Presenter.childCount;
			Load();
		}
		public void Load()
		{
			switch (RersourceToLoad)
			{
				case LoadType.Skyboxes:
					{
						foreach (var item in EnvironmentResources.Instance.realSkyboxNames)
						{
							var btn = Instantiate(MapButton, Presenter);
							btn.IconImage.sprite = EnvironmentResources.Instance.realSkyboxImages[item.Key];
							btn.Title.text = item.Value;
							ButtonGroup.AddButton(btn);
							IDs.Add(item.Key);
						}
					}
					break;
				case LoadType.BaseMaps:
					{
						foreach (var item in EnvironmentResources.Instance.realBaseSceneNames)
						{
							var btn = Instantiate(MapButton, Presenter);
							btn.IconImage.sprite = EnvironmentResources.Instance.realBaseSceneImages[item.Key];
							btn.Title.text = item.Value;
							ButtonGroup.AddButton(btn);
							IDs.Add(item.Key);
						}
					}
					break;
				case LoadType.ExistingMaps:
					{
						MapCache.Instance.RebuildCache();
						Debug.Log("List Maps:" + MapCache.Instance.MapFolders.Count);
						for (int i = 0; i < MapCache.Instance.MapFolders.Count; i++)
						{
							var btn = Instantiate(MapButton, Presenter);
							btn.IconImage.sprite = MapCache.Instance.GetIcon(i);
							btn.Title.text = MapCache.Instance.MapNames[i];
							ButtonGroup.AddButton(btn);
							IDs.Add(i);
						}
					}
					break;
				default:
					break;
			}
		}
		public void Reload()
		{
			ID = -1;
			for (int i = Presenter.childCount - 1; i >= startElementCount; i--)
			{
				Destroy(Presenter.GetChild(i).gameObject);
			}
			ButtonGroup.Buttons.Clear();
			Load();
		}
		public enum LoadType
		{
			Skyboxes, BaseMaps, ExistingMaps
		}
	}
}
