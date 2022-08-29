using System.Collections.Generic;
using UnityEngine;
using UnityEditor; 

public class TogglesInspector : CustomMaterialEditor
{
	protected override void CreateToggleList()
	{
        Toggles.Add(new FeatureToggle("Dissolve Enabled", "Dissolve", "DISSOVLE_ON", "DISSOVLE_OFF"));
        Toggles.Add(new FeatureToggle("Mask Enabled","Mask","MASK_ON","MASK_OFF"));

	}
}