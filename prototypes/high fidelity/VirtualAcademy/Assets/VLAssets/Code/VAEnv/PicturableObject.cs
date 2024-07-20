using System;
using System.Collections.Generic;
using UnityEngine;
using virtual_academy.core;

namespace virtual_academy.VAEnv
{
	public class PicturableObject : MonoBehaviour
	{
		public List<Renderer> renderers;
		public Transform PictureHolder;
		[NonSerialized]
		int Generation = -1;
		[NonSerialized]
		internal string target_name = null;
		public void SetTexture(string name)
		{
			target_name = name;
		}
		private void LateUpdate()
		{
			if (target_name != null)
			{
				if (Generation != ExternalPictureCache.Instance.Generation)
				{
					var id = ExternalPictureCache.Instance.Names.IndexOf(target_name);

					var texture = (ExternalPictureCache.Instance.GetTexture(id));
					if (texture == null) return;
					PictureHolder.localScale = new Vector3((float)texture.width / (float)texture.height, 1, 1);
					foreach (var item in renderers)
					{
						foreach (var mat in item.materials)
						{
							mat.mainTexture = texture;
							mat.SetTexture("_Main", texture);
						}
					}
					Generation = ExternalPictureCache.Instance.Generation;
				}
			}
		}
	}
}
