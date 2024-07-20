using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using virtual_academy.core;
using virtual_academy.core.EFI;

namespace virtual_academy.VAEnv
{
	public class VAEnvCore : MonoBehaviour
	{
		public static VAEnvCore instance;
		public Transform OperateSpace;
		public List<Material> SkyMaterials;
		int SkyID = 0;
		void Start()
		{
			instance = this;
			SkyID = EnvironmentResources.Instance.realBaseSceneIDs.First().Key;
			SetSky(SkyID);
		}
		public List<PlacedObject> World;
		public void SetSky(int ID)
		{
			SkyID = ID;
			if (EnvironmentResources.Instance != null)
			{
				if (EnvironmentResources.Instance.realSkyboxes != null)
				{
					if (EnvironmentResources.Instance.realSkyboxes.TryGetValue(ID, out var material))
					{
						RenderSettings.skybox = material;
						return;
					}
				}
			}
			if (SkyMaterials.Count > ID)
			{
				var mat = SkyMaterials[ID];
				RenderSettings.skybox = mat;
			}
		}
		public void FinalizeObjects()
		{
			foreach (var item in World)
			{
				item.FinalizeObject();
			}
		}
		public void DeleteObject(PlacedObject obj)
		{
			Destroy(obj.UnderlyingObject.gameObject);
			World.Remove(obj);
		}
		public void PlacePicture(int ID, Vector3 position)
		{
			try
			{
				PictureObject pictureObject = new();
				pictureObject.PictureName = ExternalPictureCache.Instance.Names[ID];
				pictureObject.Name = ExternalPictureCache.Instance.Names[ID];
				var obj = Instantiate(CreatorResourceDefinition.Instance.PictureHolder, OperateSpace);
				obj.transform.position = position;
				var pobj = obj.GetComponent<PicturableObject>();
				var _pobj = obj.GetComponent<PlacableObject>();
				pictureObject.IsInteractable = _pobj.IsInteractive;
				//pobj.SetTexture(ExternalPictureCache.Instance.GetTexture(ID));
				pictureObject.UnderlyingObject = _pobj;
				_pobj.placed = pictureObject;
				World.Add(pictureObject);
				StartCoroutine(DelayerApplyImage(pictureObject));
			}
			catch (Exception)
			{
			}
		}
		IEnumerator DelayerApplyImage(PictureObject pobj)
		{
			yield return null;
			pobj.ApplyImage();
		}
		public void PlaceObject(string name, Vector3 position)
		{
			if (CreatorResourceDefinition.Instance.realObjectSet.TryGetValue(name, out PlacableObject placableObject))
			{
				var obj = Instantiate(placableObject.gameObject, OperateSpace);
				obj.transform.position = position;
				var pobj = obj.GetComponent<PlacableObject>();
				PlacedObject placedObject = new() { Name = Guid.NewGuid().ToString(), UnderlyingObject = pobj, Prototype = name, IsInteractable = placableObject.IsInteractive };
				pobj.placed = placedObject;
				World.Add(placedObject);
			}
		}
		public void RestorePicture(PictureObject pictureObject)
		{

			var obj = Instantiate(CreatorResourceDefinition.Instance.PictureHolder, OperateSpace);
			obj.transform.position = pictureObject.Position;
			obj.transform.rotation = pictureObject.Rotation;
			obj.transform.localScale = pictureObject.Scale;
			var pobj = obj.GetComponent<PicturableObject>();
			var _pobj = obj.GetComponent<PlacableObject>();
			//pobj.SetTexture(ExternalPictureCache.Instance.GetTexture(ID));
			pictureObject.UnderlyingObject = _pobj;
			_pobj.placed = pictureObject;
			World.Add(pictureObject);
			StartCoroutine(DelayerApplyImage(pictureObject));
		}
		public void RestoreObject(PlacedObject placedObject)
		{
			if (placedObject is PictureObject po)
			{
				RestorePicture(po);
			}
			else
			if (CreatorResourceDefinition.Instance.realObjectSet.TryGetValue(placedObject.Prototype, out PlacableObject placableObject))
			{
				var obj = Instantiate(placableObject.gameObject, OperateSpace);
				obj.transform.position = placedObject.Position;
				obj.transform.rotation = placedObject.Rotation;
				obj.transform.localScale = placedObject.Scale;
				var pobj = obj.GetComponent<PlacableObject>();
				placedObject.UnderlyingObject = pobj;
				pobj.placed = placedObject;
				World.Add(placedObject);
			}

		}
		public void ApplyInteractions()
		{
			foreach (var item in World)
			{
				var obj = item.UnderlyingObject;
				if (obj.IsInteractive)
				{
					var iobj = obj.GetComponentInChildren<InteractableObject>();
					if (iobj != null)
						iobj.IsDirectlyOperatable = item.IsInteractable;
				}
				else
				{
					foreach (var _item in World)
					{
						if (_item.Name == item.InteractTarget)
						{
							var collider = obj.GetComponentInChildren<Collider>();
							var tobj = collider.AddComponent<TransitiveInteractableObject>();
							tobj.passToObject = _item;
						}
					}
				}
			}
		}
		public string LoadMap(string MapName)
		{
			var data = StorageManager.Instance.ReadMapData(MapName);
			var meta = StorageManager.Instance.ReadMapMetadata(MapName);
			SetSky(meta.SkyboxID);
			foreach (var item in data.placedObjects)
			{
				RestoreObject(item);
			}
			ApplyInteractions();
			return meta.Name;
		}
		public void SaveMap(string MapFolderName, string MapName)
		{
			this.FinalizeObjects();
			StorageManager.Instance.SaveMap(MapFolderName,
				new core.Data.MapMetadata() { BaseMapID = CoreData.Instance.TargetBase, SkyboxID = SkyID, Name = MapName },
				new core.Data.MapData { placedObjects = World });
		}
		public void RenameMap(string MapFolderName, string NewName)
		{
			this.FinalizeObjects();
			StorageManager.Instance.SaveMap(MapFolderName,
				new core.Data.MapMetadata() { BaseMapID = CoreData.Instance.TargetBase, SkyboxID = SkyID, Name = NewName },
				new core.Data.MapData { placedObjects = World });
		}
	}
}
