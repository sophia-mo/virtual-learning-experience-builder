namespace virtual_academy.core.EFI
{
	public class SceneDefinitions : EFIProgram
	{
		public static SceneDefinitions instance;
		public int MainUISceneID;
		public int PlayerEditID;
		public int CreatorUISceneID;
		public int PlayerUISceneID;
		public override void Init(Boot booter)
		{
			instance = this;
			booter.ReportDone();
		}
	}
}
