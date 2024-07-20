using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using virtual_academy.core.Data;

namespace virtual_academy.core.EFI
{
	public class StorageManager : EFIProgram
	{
		[NonSerialized]
		static readonly JsonSerializerSettings serializerSettings = new JsonSerializerSettings()
		{
			TypeNameHandling = TypeNameHandling.All,
			NullValueHandling = NullValueHandling.Ignore,
			MissingMemberHandling = MissingMemberHandling.Ignore,
			Formatting = Formatting.Indented,
		};
		public static StorageManager Instance;
		public string BaseFolder;
		public string MapFolder;
		public string ExternelPicture;
		public string ExternelQuiz;
		public DirectoryInfo BaseFolderInfo;
		public DirectoryInfo MapFolderInfo = null;
		public DirectoryInfo PictureFolder = null;
		public DirectoryInfo QuizFolder = null;
		public override void Init(Boot booter)
		{
			Instance = this;
			BaseFolder = Application.persistentDataPath;
			BaseFolderInfo = new DirectoryInfo(BaseFolder);
			if (!BaseFolderInfo.Exists)
			{
				BaseFolderInfo.Create();
			}
			{
				var mapFolder = Path.Combine(BaseFolderInfo.FullName, MapFolder);
				MapFolderInfo = new DirectoryInfo(mapFolder);
				if (!MapFolderInfo.Exists)
				{
					MapFolderInfo.Create();
				}
				MapFolder = mapFolder;
			}
			{
				var picturePath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				if (picturePath == null || picturePath == "")
				{
					picturePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Pictures");
				}
				picturePath = Path.Combine(picturePath, "VirtualAcademy");
				ExternelPicture = picturePath;
				PictureFolder = new DirectoryInfo(picturePath);
			}
			{
				var picturePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
				if (picturePath == null || picturePath == "")
				{
					picturePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Documents");
				}
				picturePath = Path.Combine(picturePath, "VirtualAcademy");
				ExternelPicture = picturePath;
				QuizFolder = new DirectoryInfo(picturePath);
			}
			ExternalPictureCache.Instance.RebuildCache();
			booter.ReportDone();
		}
		public IEnumerable<string> EnumerateMaps()
		{
			if (MapFolderInfo == null)
			{
				return Enumerable.Empty<string>();
			}
			return EnumerateMap();
		}
		public IEnumerable<string> EnumerateMap()
		{
			foreach (var item in MapFolderInfo.EnumerateDirectories())
			{
				var metadataFile = Path.Combine(item.FullName, "metadata.json");
				if (File.Exists(metadataFile))
				{
					yield return item.Name;
				}
			}
		}
		public void DeleteMap(string folderName)
		{
			var baseMapFolder = Path.Combine(MapFolderInfo.FullName, folderName);
			if (Directory.Exists(baseMapFolder))
			{
				Directory.Delete(baseMapFolder, true);
			}
		}
		public Sprite LoadMapIcon(string name)
		{
			var baseMapFolder = Path.Combine(MapFolderInfo.FullName, name);
			var imgFile = Path.Combine(baseMapFolder, "Cover.png");
			var t2d = ExternalPictureCache.LoadPictureAsTexture2D(imgFile);
			if (t2d != null)
			{
				return ExternalPictureCache.LoadPictureFromSprite(t2d);
			}
			else
			{
				return null;
			}
		}
		public MapMetadata ReadMapMetadata(string name)
		{
			var baseMapFolder = Path.Combine(MapFolderInfo.FullName, name);
			var MetadataFile = Path.Combine(baseMapFolder, "metadata.json");
			try
			{
				return JsonConvert.DeserializeObject<MapMetadata>(File.ReadAllText(MetadataFile));
			}
			catch (Exception e)
			{
				Debug.LogException(e);
			}
			return null;
		}
		public MapData ReadMapData(string name)
		{
			var baseMapFolder = Path.Combine(MapFolderInfo.FullName, name);
			var MapDataFile = Path.Combine(baseMapFolder, "data.json");
			try
			{
				return JsonConvert.DeserializeObject<MapData>(File.ReadAllText(MapDataFile), serializerSettings);
			}
			catch (Exception)
			{
			}
			return null;
		}
		public string PrepareNewMapFolder()
		{
			if (!MapFolderInfo.Exists) return null;
			Guid guid = Guid.NewGuid();
			var name = guid.ToString();
			MapFolderInfo.CreateSubdirectory(name);
			return name;
		}
		public void SaveMap(string mapDirName, MapMetadata meta, MapData data)
		{
			var baseMapFolder = Path.Combine(MapFolderInfo.FullName, mapDirName);
			ScreenCapture.CaptureScreenshot(Path.Combine(baseMapFolder, "Cover.png"), ScreenCapture.StereoScreenCaptureMode.BothEyes);
			{
				var MetadataFile = Path.Combine(baseMapFolder, "metadata.json");
				if (File.Exists(MetadataFile)) { File.Delete(MetadataFile); }
				File.WriteAllText(MetadataFile, JsonConvert.SerializeObject(meta));
			}
			{
				var DataFile = Path.Combine(baseMapFolder, "data.json");
				if (File.Exists(DataFile)) { File.Delete(DataFile); }
				File.WriteAllText(DataFile, JsonConvert.SerializeObject(data, serializerSettings));
			}
		}
		public IEnumerable<FileInfo> EnumeratePictures()
		{
			if (PictureFolder == null)
			{
				Debug.Log("Folder not inited!");
				return Enumerable.Empty<FileInfo>();
			}
			if (!PictureFolder.Exists)
			{
				Debug.Log("Folder not exist!");
				return Enumerable.Empty<FileInfo>();
			}
			return PictureFolder.EnumerateFiles().Where((f) =>
			{
				switch (f.Extension.ToUpper())
				{
					case ".JPG":
					case ".PNG":
						return true;
					default:
						break;
				}
				return false;
			});
		}
	}
}