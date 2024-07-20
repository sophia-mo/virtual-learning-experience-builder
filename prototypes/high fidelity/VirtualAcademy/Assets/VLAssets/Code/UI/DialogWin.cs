using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace virtual_academy.UI
{
	public class DialogWin : MonoBehaviour, IDialogWin
	{
		public Button CloseButton;
		public IDialogHost host;
		public Animator animator;
		public string CloseTrigger;
		public float CloseAnimationLength;

		public GameObject GObject => gameObject;
		public Action OnCloseDialog;
		public void Init(IDialogHost host)
		{
			this.host = host;
			CloseButton.onClick.AddListener(() =>
			{
				OnCloseDialog?.Invoke();
				this.host.CloseDialog(this);
			});
		}

		public IEnumerator OnClose()
		{
			if (animator != null)
				animator.SetTrigger(CloseTrigger ?? "Close");
			yield return new WaitForSeconds(CloseAnimationLength);
		}

		public void OnShow()
		{

		}
	}
}
