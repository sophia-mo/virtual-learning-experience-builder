using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace virtual_academy.UI
{
	public class StateButton : MonoBehaviour
	{
		public List<GameObject> States;
		public Button BindedButton;
		public Action<int> OnStateChange;
		public int CurrentState;
		void Start()
		{
			BindedButton.onClick.AddListener(() =>
			{
				CurrentState++;
				if (CurrentState >= States.Count)
				{
					CurrentState = 0;
				}
				if (OnStateChange != null)
				{
					OnStateChange(CurrentState);
				}
				ApplyState(CurrentState);

			});

		}
		public void ApplyState(int state)
		{
			for (int i = 0; i < States.Count; i++)
			{
				var item = States[i];
				if (item != null)
				{
					item.SetActive(i == state);
				}
			}
		}
	}
}
