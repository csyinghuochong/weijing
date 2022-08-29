//쉐이더 커스텀 용

using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Linq;
using System.Text.RegularExpressions;

public abstract class CustomMaterialEditor : MaterialEditor
{
	public class FeatureToggle
	{
		public string InspectorName;
		public string InspectorPropertyHideTag;
		public string ShaderKeywordEnabled;
		public string ShaderKeywordDisabled;
		public bool Enabled;

		public FeatureToggle(string InspectorName, string InspectorPropertyHideTag, string ShaderKeywordEnabled, string ShaderKeywordDisabled)
		{
			this.InspectorName = InspectorName;
			this.InspectorPropertyHideTag = InspectorPropertyHideTag;
			this.ShaderKeywordEnabled = ShaderKeywordEnabled;
			this.ShaderKeywordDisabled = ShaderKeywordDisabled;
			this.Enabled = false;
		}
	}

	protected List<FeatureToggle> Toggles = new List<FeatureToggle>();
	protected abstract void CreateToggleList(); 

	public override void OnInspectorGUI ()
	{
		if (!isVisible)
			return;

		Material targetMat = target as Material;
		string[] oldKeyWords = targetMat.shaderKeywords;

		Toggles = new List<FeatureToggle>();
		CreateToggleList();

		for(int i = 0; i < Toggles.Count; i++)
		{
			Toggles[i].Enabled = oldKeyWords.Contains (Toggles[i].ShaderKeywordEnabled);
		}

		EditorGUI.BeginChangeCheck();

		serializedObject.Update ();
		var theShader = serializedObject.FindProperty ("m_Shader");
		if (isVisible && !theShader.hasMultipleDifferentValues && theShader.objectReferenceValue != null)
		{
			float controlSize = 64;
			EditorGUIUtility.labelWidth = Screen.width - controlSize - 50;
			EditorGUIUtility.fieldWidth = controlSize;

			Shader shader = theShader.objectReferenceValue as Shader;

			EditorGUI.BeginChangeCheck();
            
            //렌더큐는 지오메트리 기준
			int renderingoffset = targetMat.renderQueue - 2000;
			renderingoffset = EditorGUILayout.IntField("RenderQueue Order Seting - 2000", renderingoffset);
			targetMat.renderQueue = renderingoffset + 2000;

			for (int i = 0; i < ShaderUtil.GetPropertyCount(shader); i++)
			{
				ShaderPropertyImpl(shader, i, null);
			}
			for (int s = 0; s < Toggles.Count; s++)
			{
				EditorGUILayout.Separator();
				Toggles[s].Enabled = EditorGUILayout.BeginToggleGroup(Toggles[s].InspectorName, Toggles[s].Enabled);

				if (Toggles[s].Enabled)
				{
					for (int i = 0; i < ShaderUtil.GetPropertyCount(shader); i++)
					{
						ShaderPropertyImpl(shader, i, Toggles[s]);
					}
				}
				EditorGUILayout.EndToggleGroup();
			}

			if (EditorGUI.EndChangeCheck())
				PropertiesChanged ();
		}

		if (EditorGUI.EndChangeCheck())
		{

			List<string> newKeyWords = new List<string>();

			for(int i = 0; i < Toggles.Count; i++)
			{
				newKeyWords.Add(Toggles[i].Enabled ? Toggles[i].ShaderKeywordEnabled : Toggles[i].ShaderKeywordDisabled);
			}

			targetMat.shaderKeywords = newKeyWords.ToArray ();
			EditorUtility.SetDirty (targetMat);
		}
	}

	private void ShaderPropertyImpl(Shader shader, int propertyIndex, FeatureToggle currentToggle)
	{
		string propertyDescription = ShaderUtil.GetPropertyDescription(shader, propertyIndex);

		if (currentToggle == null)
		{
			for (int i = 0; i < Toggles.Count; i++)
			{
				if (Regex.IsMatch(propertyDescription, Toggles[i].InspectorPropertyHideTag , RegexOptions.IgnoreCase))
				{
					return;
				}
			}
		}
		else if (!Regex.IsMatch(propertyDescription, currentToggle.InspectorPropertyHideTag , RegexOptions.IgnoreCase))
		{
			return;
		}

		MaterialProperty materialProperty = GetMaterialProperty( targets, propertyIndex );
		ShaderProperty( materialProperty, materialProperty.displayName );
	}
}