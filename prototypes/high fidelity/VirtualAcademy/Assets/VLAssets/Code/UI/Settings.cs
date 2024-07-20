using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

namespace virtual_academy.UI
{
	public class Settings : MonoBehaviour
	{
		public UniversalRenderPipelineAsset asset;
		public Slider RenderScale;
		void Start()
		{
			RenderScale.value = asset.renderScale;
			RenderScale.onValueChanged.AddListener((v) => asset.renderScale = v);
		}

	}
}
