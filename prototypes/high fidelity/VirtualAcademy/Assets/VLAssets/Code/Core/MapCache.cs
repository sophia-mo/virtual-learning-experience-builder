using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using virtual_academy.core.Data;
using virtual_academy.core.EFI;

namespace virtual_academy.core
{
	public class CharacterManager
	{
		public static CharacterManager instance = new CharacterManager();
		string CharacterFile = null;
		public List<CharacterDefinition> CharacterDefinitions = new();
		public void RebuildDB()
		{
			CharacterFile = Path.Combine(StorageManager.Instance.BaseFolderInfo.FullName, "characters.json");
			if (File.Exists(CharacterFile))
			{
				try
				{
					CharacterDefinitions = JsonConvert.DeserializeObject<List<CharacterDefinition>>(File.ReadAllText(CharacterFile));
				}
				catch (System.Exception)
				{
				}
			}
		}
		public void CommitChanges()
		{
			if (File.Exists(CharacterFile))
			{
				File.Delete(CharacterFile);
			}
			File.WriteAllText(CharacterFile, JsonConvert.SerializeObject(CharacterDefinitions));
		}
	}
	public class MapCache
	{
		public static MapCache Instance = new();
		public List<string> MapFolders = new();
		public List<string> MapNames = new();
		public List<MapMetadata> MapMetadatas = new();
		public List<Sprite> MapIcons = new();
		public void DisposeCache()
		{
			for (int i = 0; i < MapIcons.Count; i++)
			{
				Sprite item = MapIcons[i];
				if (item != null)
				{
					Object.Destroy(item.texture);
					Object.Destroy(item);
				}
				MapIcons[i] = null;
			}
			MapNames.Clear();
			MapFolders.Clear();
			MapMetadatas.Clear();
			MapIcons.Clear();
		}
		public void RemoveMap(int ID)
		{
			StorageManager.Instance.DeleteMap(MapFolders[ID]);
			RebuildCache();
		}
		public Sprite GetIcon(int ID)
		{
			if (MapIcons[ID] == null)
			{
				MapIcons[ID] = StorageManager.Instance.LoadMapIcon(MapFolders[ID]);
			}
			return MapIcons[ID];
		}
		public void RebuildCache()
		{
			DisposeCache();
			foreach (var name in StorageManager.Instance.EnumerateMaps())
			{
				var data = StorageManager.Instance.ReadMapMetadata(name);
				MapFolders.Add(name);
				MapNames.Add(data.Name);
				MapMetadatas.Add(data);
				MapIcons.Add(null);
			}
		}
	}
}
