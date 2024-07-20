using UnityEngine;
using UnityEngine.UI;
using virtual_academy.Logic;

namespace virtual_academy.UI
{
	public class BasicTransformProperties : MonoBehaviour
	{
		public InputField Field_Name;
		public InputField Field_Pos_X;
		public InputField Field_Pos_Y;
		public InputField Field_Pos_Z;
		public InputField Field_Rot_X;
		public InputField Field_Rot_Y;
		public InputField Field_Rot_Z;
		public InputField Field_Scl_X;
		public InputField Field_Scl_Y;
		public InputField Field_Scl_Z;
		public GameObject PropertiesGroup;
		float LastPosX = float.MinValue;
		float LastPosY = float.MinValue;
		float LastPosZ = float.MinValue;
		float LastRotX = float.MinValue;
		float LastRotY = float.MinValue;
		float LastRotZ = float.MinValue;
		float LastSclX = float.MinValue;
		float LastSclY = float.MinValue;
		float LastSclZ = float.MinValue;
		public void Start()
		{
			Field_Pos_X.onValueChanged.AddListener((s) =>
			{
				if (CreatorLogic.instance.SelectedObject != null)
					if (float.TryParse(s, out var v))
					{
						var v3 = CreatorLogic.instance.SelectedObject.UnderlyingObject.transform.position;
						v3.x = v;
						CreatorLogic.instance.SelectedObject.UnderlyingObject.transform.position = v3;
					}
			});
			Field_Pos_Y.onValueChanged.AddListener((s) =>
			{
				if (CreatorLogic.instance.SelectedObject != null)
					if (float.TryParse(s, out var v))
					{
						var v3 = CreatorLogic.instance.SelectedObject.UnderlyingObject.transform.position;
						v3.y = v;
						CreatorLogic.instance.SelectedObject.UnderlyingObject.transform.position = v3;
					}
			});
			Field_Pos_Z.onValueChanged.AddListener((s) =>
			{
				if (CreatorLogic.instance.SelectedObject != null)
					if (float.TryParse(s, out var v))
					{
						var v3 = CreatorLogic.instance.SelectedObject.UnderlyingObject.transform.position;
						v3.z = v;
						CreatorLogic.instance.SelectedObject.UnderlyingObject.transform.position = v3;
					}
			});
			Field_Rot_X.onValueChanged.AddListener((s) =>
			{
				if (CreatorLogic.instance.SelectedObject != null)
					if (float.TryParse(s, out var v))
					{
						var v3 = CreatorLogic.instance.SelectedObject.UnderlyingObject.transform.eulerAngles;
						v3.x = v;
						CreatorLogic.instance.SelectedObject.UnderlyingObject.transform.eulerAngles = v3;
					}
			});
			Field_Rot_Y.onValueChanged.AddListener((s) =>
			{
				if (CreatorLogic.instance.SelectedObject != null)
					if (float.TryParse(s, out var v))
					{
						var v3 = CreatorLogic.instance.SelectedObject.UnderlyingObject.transform.eulerAngles;
						v3.y = v;
						CreatorLogic.instance.SelectedObject.UnderlyingObject.transform.eulerAngles = v3;
					}
			});
			Field_Rot_Z.onValueChanged.AddListener((s) =>
			{
				if (CreatorLogic.instance.SelectedObject != null)
					if (float.TryParse(s, out var v))
					{
						var v3 = CreatorLogic.instance.SelectedObject.UnderlyingObject.transform.eulerAngles;
						v3.z = v;
						CreatorLogic.instance.SelectedObject.UnderlyingObject.transform.eulerAngles = v3;
					}
			});
			Field_Scl_X.onValueChanged.AddListener((s) =>
			{
				if (CreatorLogic.instance.SelectedObject != null)
					if (float.TryParse(s, out var v))
					{
						var v3 = CreatorLogic.instance.SelectedObject.UnderlyingObject.transform.localScale;
						v3.x = v;
						CreatorLogic.instance.SelectedObject.UnderlyingObject.transform.localScale = v3;
					}
			});
			Field_Scl_Y.onValueChanged.AddListener((s) =>
			{
				if (CreatorLogic.instance.SelectedObject != null)
					if (float.TryParse(s, out var v))
					{
						var v3 = CreatorLogic.instance.SelectedObject.UnderlyingObject.transform.localScale;
						v3.y = v;
						CreatorLogic.instance.SelectedObject.UnderlyingObject.transform.localScale = v3;
					}
			});
			Field_Scl_Z.onValueChanged.AddListener((s) =>
			{
				if (CreatorLogic.instance.SelectedObject != null)
					if (float.TryParse(s, out var v))
					{
						var v3 = CreatorLogic.instance.SelectedObject.UnderlyingObject.transform.localScale;
						v3.z = v;
						CreatorLogic.instance.SelectedObject.UnderlyingObject.transform.localScale = v3;
					}
			});
			Field_Name.onSubmit.AddListener((s) =>
			{
				CreatorLogic.instance.SelectedObject.Name = s;
			});
			Field_Name.onEndEdit.AddListener((s) =>
			{
				Field_Name.text = __name;
			});
		}
		public void UpdateValue(InputField field, float value, ref float LastValue)
		{
			if (!field.isFocused)
			{
				if (LastValue != value)
				{
					//field.text = value + "";
					field.SetTextWithoutNotify(value + "");
					LastValue = value;
				}
			}
		}
		string __name;
		public void Update()
		{
			if (CreatorLogic.instance.SelectedObject != null)
			{
				if (!PropertiesGroup.activeSelf)
				{ PropertiesGroup.SetActive(true); }
				var obj = CreatorLogic.instance.SelectedObject.UnderlyingObject;
				UpdateValue(Field_Pos_X, obj.transform.position.x, ref LastPosX);
				UpdateValue(Field_Pos_Y, obj.transform.position.y, ref LastPosY);
				UpdateValue(Field_Pos_Z, obj.transform.position.z, ref LastPosZ);
				UpdateValue(Field_Rot_X, obj.transform.eulerAngles.x, ref LastRotX);
				UpdateValue(Field_Rot_Y, obj.transform.eulerAngles.y, ref LastRotY);
				UpdateValue(Field_Rot_Z, obj.transform.eulerAngles.z, ref LastRotZ);
				UpdateValue(Field_Scl_X, obj.transform.localScale.x, ref LastSclX);
				UpdateValue(Field_Scl_Y, obj.transform.localScale.y, ref LastSclY);
				UpdateValue(Field_Scl_Z, obj.transform.localScale.z, ref LastSclZ);
				if (__name != CreatorLogic.instance.SelectedObject.Name)
				{
					__name = CreatorLogic.instance.SelectedObject.Name;
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
