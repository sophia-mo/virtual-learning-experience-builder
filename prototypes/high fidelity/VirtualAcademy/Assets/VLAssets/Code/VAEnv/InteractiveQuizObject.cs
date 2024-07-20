using virtual_academy.core.EFI;
using virtual_academy.Logic;
using virtual_academy.UI.Dialogs;

namespace virtual_academy.VAEnv
{
	public class InteractiveQuizObject : InteractableObject
	{
		public string QuizName;
		public PlacableObject pobj;
		public override void Operate()
		{
			PlayerController.instance.SetPause(true);
			var (a, b) = DialogManager.Instance.ShowDialog(PlayerLogic.instance.QuizViewDialog);
			if (a.TryGetComponent<QuizDialog>(out var ivd))
			{
				string name = null;
				if (pobj != null)
				{
					if (pobj.placed != null)
					{
						name = pobj.placed.InteractTarget;
					}
				}
				ivd.Setup(name, () => PlayerController.instance.SetPause(false));
			}
		}
	}
}
