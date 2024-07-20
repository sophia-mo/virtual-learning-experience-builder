using System;
using UnityEngine;
using UnityEngine.UI;
using virtual_academy.core;

namespace virtual_academy.UI.Dialogs
{
	public class ImageViewDialog : MonoBehaviour
	{
		public Image image;
		public DialogWin win;
		public void Setup(string Image_Name, Action OnClose)
		{
			//this.win = win;
			win.OnCloseDialog = OnClose;
			image.sprite = ExternalPictureCache.Instance.GetSprite(Image_Name);
		}
	}
}
