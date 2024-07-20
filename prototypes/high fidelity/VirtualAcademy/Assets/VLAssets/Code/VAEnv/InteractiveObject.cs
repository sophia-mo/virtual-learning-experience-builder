using UnityEngine;

namespace virtual_academy.VAEnv
{
	public class InteractableObject : MonoBehaviour
	{
		public bool IsDirectlyOperatable;
		public string Hint;
		public virtual void Operate() { }
	}
}
