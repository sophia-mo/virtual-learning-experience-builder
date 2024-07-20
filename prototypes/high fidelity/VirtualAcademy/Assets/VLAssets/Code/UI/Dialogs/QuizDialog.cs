using System;
using UnityEngine;

namespace virtual_academy.UI.Dialogs
{
	public class QuizDialog : MonoBehaviour
	{
		public DialogWin win;
		public void Setup(string quizName, Action OnClose)
		{
			//this.win = win;
			win.OnCloseDialog = OnClose;
		}
	}
}
