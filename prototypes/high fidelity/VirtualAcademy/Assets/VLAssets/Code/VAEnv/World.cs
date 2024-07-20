using System;
using System.Collections.Generic;

namespace virtual_academy.VAEnv
{
	[Serializable]
	public class World
	{
		public int Skybox;
		public int BaseEnvironment;
		public List<PlacableObject> PlacableObjects;
	}
}
