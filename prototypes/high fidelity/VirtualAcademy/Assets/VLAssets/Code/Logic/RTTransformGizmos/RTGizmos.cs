using UnityEngine;

namespace virtual_academy.Logic.RTTransformGizmos
{
	public class RTGizmos : MonoBehaviour
	{
		public GameObject PosTool;
		public GameObject RotTool;
		public GameObject SclTool;
		void Start()
		{

		}
		public void SetMode(int mode)
		{
			switch (mode)
			{
				case 0:
					PosTool.SetActive(false);
					RotTool.SetActive(false);
					SclTool.SetActive(false);
					break;
				case 1:
					PosTool.SetActive(true);
					RotTool.SetActive(false);
					SclTool.SetActive(false);
					break;
				case 2:
					PosTool.SetActive(false);
					RotTool.SetActive(true);
					SclTool.SetActive(false);
					break;
				case 3:
					PosTool.SetActive(false);
					RotTool.SetActive(false);
					SclTool.SetActive(true);
					break;
			}
		}
	}
	public enum HandleAxis
	{
		X, Y, Z,All
	}
}
