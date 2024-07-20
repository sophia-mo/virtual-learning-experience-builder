using System;
using System.Collections.Generic;
using UnityEngine;
using virtual_academy.core;

namespace virtual_academy
{
	[Serializable]
	public class TreeViewNode
	{
		public KVList<string, TreeViewNode> PreFillChildren = new();
		public Dictionary<string, TreeViewNode> Children = new Dictionary<string, TreeViewNode>();
		public bool IsFolder;
		public Sprite Icon;
		public string DispName;
		public TreeViewNodeContent ContentType;
		public List<string> Placables = new List<string>();
		[NonSerialized]
		public TreeViewNode Parent;
		public void Init(TreeViewNode parent = null)
		{
			Children = PreFillChildren.ToMap();
			this.Parent = parent;
			foreach (var item in Children)
			{
				item.Value.Init(this);
			}
		}
	}
	public enum TreeViewNodeContent
	{
		AllPlacables, ExternalPictures, SelectedPlacables
	}
}
