using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using virtual_academy.core;
using virtual_academy.core.EFI;
using virtual_academy.VAEnv;

namespace virtual_academy.Logic
{
	public class PlayerLogic : MonoBehaviour
	{
		public static PlayerLogic instance;
		public Text TimerText;
		string CurrentMap = null;
		public GameObject PauseMenu;
		public GameObject ImageViewDialog;
		public GameObject QuizViewDialog;
		public GameObject SettingDialog;
		public Button ExitButton;
		public Button SettingButton;
		void Start()
		{
			instance = this;
			CurrentMap = CoreData.Instance.TargetWorld;
			SceneManager.LoadScene(CoreData.Instance.TargetBase, LoadSceneMode.Additive);
			StartCoroutine(__start());
			ExitButton.onClick.AddListener(() =>
			{
				SceneManager.LoadScene(SceneDefinitions.instance.MainUISceneID);
			});
			SettingButton.onClick.AddListener(() =>
			{
				DialogManager.Instance.ShowDialog(SettingDialog);
			});
		}
		IEnumerator __start()
		{
			yield return null;
			{
				VAEnvCore.instance.LoadMap(CurrentMap);
			}
		}
		DateTime LastTime;
		public void Update()
		{
			DateTime now = DateTime.Now;
			if (LastTime.Second != now.Second)
			{
				LastTime = now;
				TimerText.text = now.ToString();
			}
			if (Input.GetButtonDown("Cancel"))
			{
				PlayerController.instance.IsPaused = !PlayerController.instance.IsPaused;
				PauseMenu.SetActive(PlayerController.instance.IsPaused);
				if (PlayerController.instance.IsPaused)
				{
					Cursor.lockState = CursorLockMode.None;
					Cursor.visible = true;
				}
				else
				{
					Cursor.lockState = CursorLockMode.Locked;
					Cursor.visible = false;
				}
			}
		}
	}
}
