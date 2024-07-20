using System.Collections.Generic;
using System.IO;
using UnityEngine;
using virtual_academy.core.EFI;

namespace virtual_academy.core
{
	public class ExternalPictureCache
	{
		private DirectoryInfo externalPictureDir;
		public static ExternalPictureCache Instance = new ExternalPictureCache();
		public List<string> Names = new List<string>();
		public List<string> Files = new List<string>();
		public List<Texture2D> Textures = new List<Texture2D>();
		public List<Sprite> Icons = new List<Sprite>();
		public int Generation = 0;
		public ExternalPictureCache()
		{
		}
		public void DisposeCurrentData()
		{
			for (int i = 0; i < Icons.Count; i++)
			{
				Sprite item = Icons[i];
				if (item != null)
				{
					Object.Destroy(item);
					Icons[i] = null;
				}
			}
			for (int i = 0; i < Textures.Count; i++)
			{
				Texture2D tex = Textures[i];
				if (tex != null)
				{
					Object.Destroy(tex);
					Textures[i] = null;
				}
			}
		}
		public void RebuildCache()
		{
			DisposeCurrentData();
			Files.Clear();
			Names.Clear();
			Textures.Clear();
			Icons.Clear();
			foreach (var file in StorageManager.Instance.EnumeratePictures())
			{
				Debug.Log(file.FullName);
				Files.Add(file.FullName);
				Names.Add(file.Name);
				Textures.Add(null);
				Icons.Add(null);
			}
			Generation++;
		}
		public Texture2D GetTexture(int ID)
		{
			if (ID < 0) return null;
			if (ID >= Textures.Count)
			{
				return null;
			}
			if (Textures[ID] == null)
				Textures[ID] = LoadPictureAsTexture2D(Files[ID]);
			return Textures[ID];
		}
		public Sprite GetSprite(string name)
		{
			return GetSprite(Names.IndexOf(name));
		}
		public Sprite GetSprite(int ID)
		{
			if (ID < 0) return null;
			if (ID >= Textures.Count)
			{
				return null;
			}
			if (Icons[ID] == null)
				Icons[ID] = LoadPictureFromSprite(GetTexture(ID));
			return Icons[ID];
		}
		public static Sprite LoadPictureFromSprite(Texture2D t2d)
		{

			Sprite sprite = null;

			{
				if (t2d != null)
				{

					sprite = Sprite.Create(t2d, new Rect(0, 0, t2d.width, t2d.height), new Vector2(0.5f, 0.5f));
				}
			}

			return sprite;
		}
		public static Texture2D LoadPictureAsTexture2D(string filePath)
		{
			Texture2D result = null;
			if (File.Exists(filePath))
			{
				try
				{
					byte[] data = File.ReadAllBytes(filePath);
					result = new Texture2D(2, 2);
					result.LoadImage(data);
				}
				catch (System.Exception)
				{
				}
			}
			return result;
		}
	}
}
