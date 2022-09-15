
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
        /// Unity���ھ۽�״̬�ı�ص�
        /// </summary>
        /// <param name="focus"></param>
        private static void OnEditorFocus(bool focus)
        {
            if (focus)
            {
                //ÿ���л���Unity���Զ�ִ�нű�����
                // Debug.Log($"�༭������״̬:{focus}");
                bool autoBuild = PlayerPrefs.HasKey("AutoBuild");
                if (!autoBuild)
                    return;
                BuildAssemblieEditor.BuildCodeDebug();
            }
        }

        /// <summary>
        /// Asset���ļ��ı�ʱ�ص�
        /// </summary>
        private void OnPreprocessAsset()
        {
            //Debug.Log("Asset���ļ��ı�ʱ�ص�");
        }
    }
}

#endif
