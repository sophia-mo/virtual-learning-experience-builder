namespace virtual_academy.core
{
	public class CoreData
	{
		public static CoreData Instance = new CoreData();
		public int TargetBase;
		public CreatorMode creatorMode = CreatorMode.None;
		public string TargetWorld = null;
		public bool IsLoad;
		public int TargetCharacterID=-1;
	}
	public enum CreatorMode
	{
		None, New, Edit
	}
}
