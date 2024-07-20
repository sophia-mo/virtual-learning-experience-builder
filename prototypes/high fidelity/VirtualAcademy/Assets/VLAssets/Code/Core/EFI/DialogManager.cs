using System;
using System.Collections;
using UnityEngine;
using virtual_academy.UI;
using virtual_academy.UI.Dialogs;

namespace virtual_academy.core.EFI
{
	public class DialogManager : EFIProgram, IDialogHost
	{
		public Transform DialogRoot;
		public static DialogManager Instance;
		public GameObject StandardDialogPrefab;
		public GameObject InputStandardDialogPrefab;
		public void CloseDialog(IDialogWin win)
		{
			StartCoroutine(__close(win));
		}
		IEnumerator __close(IDialogWin win)
		{
			yield return win.OnClose();
			Destroy(win.GObject);
			if (DialogRoot.childCount == 0)
			{
				DialogRoot.gameObject.SetActive(false);
			}
		}
		public override void Init(Boot booter)
		{
			Instance = this;
			booter.ReportDone();
		}

		public void ShowOptionDialog(string Title, string Content, int W, int H,
			string OKBtn, Action OKAction, string CancelBtn, Action CancelAction)
		{
			var (obj, dlg) = ShowDialog(this.StandardDialogPrefab);
			var stddlg = obj.GetComponentInChildren<StandardDialog>();
			stddlg.InitOptionOnly(Title, Content, W, H, OKBtn, OKAction, CancelBtn, CancelAction);
		}
		public void ShowInputOptionDialog(string Title, string Content, int W, int H,
			string OKBtn, Action<string> OKAction, string CancelBtn, Action CancelAction)
		{
			var (obj, dlg) = ShowDialog(this.InputStandardDialogPrefab);
			var stddlg = obj.GetComponentInChildren<StandardDialog>();
			stddlg.InitInputDialog(Title, Content, W, H, OKBtn, OKAction, CancelBtn, CancelAction);
		}
		public (GameObject, IDialogWin) ShowDialog(GameObject Prefab)
		{
			DialogRoot.gameObject.SetActive(true);
			var obj = Instantiate(Prefab, DialogRoot);
			var win = obj.GetComponentInChildren<IDialogWin>();
			win.Init(this);
			win.OnShow();
			return (obj, win);
		}
	}
}
