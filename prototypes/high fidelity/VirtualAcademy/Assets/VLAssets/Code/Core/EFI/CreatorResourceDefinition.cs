using System.Collections.Generic;
using UnityEngine;
using virtual_academy.VAEnv;

namespace virtual_academy.core.EFI
{
	public class CreatorResourceDefinition : EFIProgram
	{
		public static CreatorResourceDefinition Instance;
		public Dictionary<string, PlacableObject> realObjectSet;
		public KVList<string, PlacableObject> PlacableObjects;
		public GameObject PictureHolder;
		public override void Init(Boot booter)
		{
			realObjectSet = PlacableObjects.ToMap();
			Instance = this;
			booter.ReportDone();
		}
	}
}
