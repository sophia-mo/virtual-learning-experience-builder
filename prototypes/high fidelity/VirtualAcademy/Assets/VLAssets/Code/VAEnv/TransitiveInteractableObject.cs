namespace virtual_academy.VAEnv
{
	public class TransitiveInteractableObject : InteractableObject
	{
		public PlacedObject passToObject;
		public override void Operate()
		{
			if (passToObject != null)
			{
				var iobj = passToObject.UnderlyingObject.GetComponentInChildren<InteractableObject>();
				if (iobj != null)
					iobj.Operate();
			}
		}
	}
}
