
#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace ET
{
    [InitializeOnLoad]
    public class EditorNotification : AssetPostprocessor
    {
        private static bool isFocused;
        static EditorNotification()
        {
            EditorApplication.update += Update;
        }

        private static void Update()
        {
            if (isFocused == UnityEditorInternal.InternalEditorUtility.isApplicationActive)
            {
                return;
            }
            isFocused = UnityEditorInternal.InternalEditorUtility.isApplicationActive;
            OnEditorFocus(isFocused);
        }

        /// <summary>
        /// Unity
        /// </summary>
        /// <param name="focus"></param>
        private static void OnEditorFocus(bool focus)
        {
            if (focus)
            {
                bool autoBuild = PlayerPrefs.HasKey("AutoBuild");
                if (!autoBuild)
                    return;
                BuildAssemblieEditor.BuildCodeDebug();
            }
        }


        private void OnPreprocessAsset()
        {
            //Debug.Log("OnPreprocessAsset");
        }
    }
}

#endif
