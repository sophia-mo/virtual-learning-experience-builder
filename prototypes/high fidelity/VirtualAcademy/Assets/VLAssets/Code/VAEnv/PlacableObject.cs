using System;
using System.Collections.Generic;
using UnityEngine;

namespace virtual_academy.VAEnv
{
	public class PlacableObject : MonoBehaviour
	{
		public string Name;
		public bool IsInteractive = false;
		[NonSerialized]
		public bool isSelected;
		[NonSerialized]
		public PlacedObject placed;
		public List<Transform> SnapPoints;
		public List<MeshRenderer> Renderers;
		public Sprite Icon;
		public bool IsSelected
		{
			get => isSelected; set
			{
				isSelected = value;
				foreach (var item in Renderers)
				{
					foreach (var mat in item.materials)
					{
						mat.SetFloat("_IsSelected", value ? 1 : 0);
					}
				}
			}
		}
	}
}
