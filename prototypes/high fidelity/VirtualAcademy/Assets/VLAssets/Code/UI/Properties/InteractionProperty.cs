using UnityEngine;
using UnityEngine.UI;
using virtual_academy.Logic;
using virtual_academy.UI.Controls;

namespace virtual_academy
{
	public class InteractionProperty : MonoBehaviour
	{
		public ToggleButton IsInteractiveToggle;
		public InputField Field_Name;
		public GameObject PropertiesGroup;
		void Start()
		{
			IsInteractiveToggle.OnToggle = (v) =>
			{
				CreatorLogic.instance.SelectedObject.IsInteractable = v;
			};
			Field_Name.onSubmit.AddListener((v) =>
			{
				CreatorLogic.instance.SelectedObject.InteractTarget = v;

			});
			Field_Name.onEndEdit.AddListener((s) =>
			{
				Field_Name.text = __name;
			});
		}
		string __name = null;
		void Update()
		{
			if (CreatorLogic.instance.SelectedObject != null)
			{
				if (!PropertiesGroup.activeSelf)
				{ PropertiesGroup.SetActive(true); }
				if (IsInteractiveToggle.UnderlyingToggle.isOn != CreatorLogic.instance.SelectedObject.IsInteractable)
				{
					IsInteractiveToggle.UnderlyingToggle.SetIsOnWithoutNotify(CreatorLogic.instance.SelectedObject.IsInteractable);
					IsInteractiveToggle.ApplyIndicator(CreatorLogic.instance.SelectedObject.IsInteractable);
				}

				if (__name != CreatorLogic.instance.SelectedObject.InteractTarget)
				{
					__name = CreatorLogic.instance.SelectedObject.InteractTarget;
					Field_Name.text = __name;
				}
			}
			else
			{
				if (PropertiesGroup.activeSelf)
				{ PropertiesGroup.SetActive(false); }
			}

		}
	}
}
