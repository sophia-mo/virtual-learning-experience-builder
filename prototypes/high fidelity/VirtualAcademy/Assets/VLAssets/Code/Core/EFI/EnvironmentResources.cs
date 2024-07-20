using System.Collections.Generic;
using UnityEngine;

namespace virtual_academy.core.EFI
{

	public class EnvironmentResources : EFIProgram
	{
		public static EnvironmentResources Instance;
		public KVList<int, string> SkyboxNames;
		public KVList<int, Sprite> SkyboxImages;
		public KVList<int, Material> Skyboxes;
		public KVList<int, int> BaseSceneIDs;
		public KVList<int, string> BaseSceneNames;
		public KVList<int, Sprite> BaseSceneImages;
		public Dictionary<int, Material> realSkyboxes;
		public Dictionary<int, string> realSkyboxNames;
		public Dictionary<int, Sprite> realSkyboxImages;
		public Dictionary<int, int> realBaseSceneIDs;
		public Dictionary<int, string> realBaseSceneNames;
		public Dictionary<int, Sprite> realBaseSceneImages;
		public override void Init(Boot booter)
		{
			Instance = this;
			realSkyboxes = Skyboxes.ToMap();
			realSkyboxNames = SkyboxNames.ToMap();
			realSkyboxImages = SkyboxImages.ToMap();
			realBaseSceneIDs = BaseSceneIDs.ToMap();
			realBaseSceneImages = BaseSceneImages.ToMap();
			realBaseSceneNames = BaseSceneNames.ToMap();
			booter.ReportDone();

		}
	}
}
