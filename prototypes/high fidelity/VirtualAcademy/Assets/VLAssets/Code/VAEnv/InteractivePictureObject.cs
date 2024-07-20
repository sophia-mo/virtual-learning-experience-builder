using virtual_academy.core.EFI;
using virtual_academy.Logic;
using virtual_academy.UI.Dialogs;

namespace virtual_academy.VAEnv
{
	public class InteractivePictureObject : InteractableObject
	{
		public PicturableObject pobj;
		public override void Operate()
		{
			PlayerController.instance.SetPause(true);
			var (a, b) = DialogManager.Instance.ShowDialog(PlayerLogic.instance.ImageViewDialog);
			if (a.TryGetComponent<ImageViewDialog>(out var ivd))
			{
				ivd.Setup(pobj.target_name, () => PlayerController.instance.SetPause(false));
			}
		}
	}
}
