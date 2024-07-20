using UnityEngine;

namespace virtual_academy.VAEnv
{
	public class TogglableObject : InteractableObject
	{
		bool State = false;
		public GameObject State0;
		public GameObject State1;
		public override void Operate()
		{
			State = !State;
			if (State)
			{
				State0.SetActive(false);
				State1.SetActive(true);
			}
			else
			{
				State0.SetActive(true);
				State1.SetActive(false);
			}
		}
	}
}
