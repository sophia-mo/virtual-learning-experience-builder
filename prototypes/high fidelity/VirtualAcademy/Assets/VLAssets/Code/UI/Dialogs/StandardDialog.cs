using System;
using UnityEngine;
using UnityEngine.UI;

namespace virtual_academy.UI.Dialogs
{
	public class StandardDialog : MonoBehaviour
	{
		public Text Title;
		public Text Content;
		public Button OKBtn;
		public Text OKBtnText;
		public Button CancelBtn;
		public Text CancelBtnText;
		public InputField InputField;
		public DialogWin DialogWin;
		public RectTransform WinRect;
		public void InitOptionOnly(string Title, string Content, int W, int H,
			string OKBtn, Action OKAction, string CancelBtn, Action CancelAction)
		{
			this.Title.text = Title;
			this.Content.text = Content;
			OKBtnText.text = OKBtn;
			CancelBtnText.text = CancelBtn;
			WinRect.sizeDelta=new Vector2(W, H);
			if (OKBtn == null)
			{
				this.OKBtn.gameObject.SetActive(false);
			}
			else
				this.OKBtn.onClick.AddListener(() =>
				{
					OKAction();
					DialogWin.host.CloseDialog(DialogWin);
				});
			if (InputField != null) InputField.gameObject.SetActive(false);
			if (CancelBtn == null)
			{
				this.CancelBtn.gameObject.SetActive(false);
				DialogWin.CloseButton.gameObject.SetActive(false);
			}
			else
				this.CancelBtn.onClick.AddListener(() =>
				{
					CancelAction();
					DialogWin.host.CloseDialog(DialogWin);
				});
		}
		public void InitInputDialog(string Title, string Content, int W, int H,
			string OKBtn, Action<string> OKAction, string CancelBtn, Action CancelAction)
		{

			if (InputField != null) InputField.gameObject.SetActive(true);
			this.Title.text = Title;
			this.Content.text = Content;
			OKBtnText.text = OKBtn;
			CancelBtnText.text = CancelBtn;
			WinRect.sizeDelta = new Vector2(W, H);
			if (OKBtn == null)
			{
				this.OKBtn.gameObject.SetActive(false);
			}
			else
				this.OKBtn.onClick.AddListener(() =>
				{
					OKAction(InputField.text);
					DialogWin.host.CloseDialog(DialogWin);
				});
			if (CancelBtn == null)
			{
				this.CancelBtn.gameObject.SetActive(false);
				DialogWin.CloseButton.gameObject.SetActive(false);
			}
			else
				this.CancelBtn.onClick.AddListener(() =>
				{
					CancelAction();
					DialogWin.host.CloseDialog(DialogWin);
				});
		}
	}
}
