using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using virtual_academy.core.EFI;

namespace virtual_academy
{
	public class Boot : MonoBehaviour
	{
		public static Boot Instance = null;
		public int TargetScreen;
		public List<EFIProgram> EFIs;
		public int DoneCount;
		public bool NotLoadWhenExists = true;
		public bool NoJump = false;
		public void ReportDone()
		{
			Interlocked.Increment(ref DoneCount);
		}
		void Start()
		{
			if (Instance != null)
			{
				if (NotLoadWhenExists)
				{
					return;
				}
			}
			Instance = this;
			DontDestroyOnLoad(gameObject);
			foreach (var item in EFIs)
			{
				item.Init(this);
			}
		}
		void Update()
		{
			if (DoneCount >= EFIs.Count)
			{
				if (!NoJump)
					SceneManager.LoadScene(TargetScreen);
				this.enabled = false;
			}
		}
	}
}
