using System;
using virtual_academy.core.Data;

namespace virtual_academy.VAEnv
{
	[Serializable]
	public class PlacedObject
	{
		public string Name;
		public string Prototype;
		public string BindedObject;
		public FLOAT3 Position;
		public FLOAT4 Rotation;
		public FLOAT3 Scale;
		public bool IsInteractable = false;
		public string InteractTarget = null;
		[NonSerialized]
		public PlacableObject UnderlyingObject;
		public void FinalizeObject()
		{
			Position = UnderlyingObject.transform.position;
			Rotation = UnderlyingObject.transform.rotation;
			Scale = UnderlyingObject.transform.lossyScale;
		}
	}
	[Serializable]
	public class PictureObject : PlacedObject
	{
		public string PictureName;
		public void ApplyImage()
		{
			var po = UnderlyingObject.GetComponentInChildren<PicturableObject>();
			if (po != null)
			{
				po.SetTexture(PictureName);
			}
		}
	}
}
