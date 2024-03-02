using System.Collections;
using UnityEngine;

namespace ET
{

    public static class LoadHelper
    {

        private static GameObject Code_Prefab;
        //  const string CodeABName = "code.unity3d";
        public static IEnumerator PreLoad()
        {
            var code = ABPathHelper.GetNormalConfigPath("Code");
            var request = libx.Assets.LoadAssetAsync(code, typeof(GameObject));
            var code_1 = $"Assets/Bundles/Text/ETKey.txt";
            var request_1 = libx.Assets.LoadAsset(code_1, typeof(TextAsset));
            yield return request;
#if UNITY_EDITOR
            Code_Prefab = request.asset as GameObject;
#else
            Code_Prefab = request_1.asset != null ? request.asset as GameObject : null;
            InitHelper.InitKey = request_1.asset != null ? request_1.asset.ToString() : string.Empty;
#endif
        }

        public static TextAsset LoadCode(string name)
        {
            if (Code_Prefab == null)
            {
                //throw new System.Exception("not found code.prefab");
                return new TextAsset(name); 
            }
            //#if UNITY_EDITOR
            //            string codePath = $"Assets/Bundles/Independent/Code.prefab";//Path.Combine(Application.dataPath, "Bundles","Independent","Code.prefab");

            //            string[] realPath = null;
            //            realPath = AssetDatabase.GetAssetPathsFromAssetBundle(CodeABName);
            //            codePath = realPath.FirstOrDefault();
            //            GameObject code = AssetDatabase.LoadAssetAtPath<GameObject>(codePath);
            //            if (code == null)
            //            {
            //                throw new System.Exception("请检查 Code是否存在");
            //            }
            //            var testAsset = code.GetComponent<ReferenceCollector>().Get<TextAsset>(name);
            //            return testAsset;
            //#endif
            var textAsset = Code_Prefab.GetComponent<ReferenceCollector>().Get<TextAsset>(name);
            return textAsset;
        }

        public static byte[] LoadCodeBytes(string name)
        {
            if (Code_Prefab == null)
            {
                throw new System.Exception("not found code.prefab");
            }
            //#if UNITY_EDITOR
            //            string codePath = $"Assets/Bundles/Independent/Code.prefab";//Path.Combine(Application.dataPath, "Bundles","Independent","Code.prefab");

            //            string[] realPath = null;
            //            realPath = AssetDatabase.GetAssetPathsFromAssetBundle(CodeABName);
            //            codePath = realPath.FirstOrDefault();
            //            GameObject code = AssetDatabase.LoadAssetAtPath<GameObject>(codePath);
            //            if (code == null)
            //            {
            //                throw new System.Exception("请检查 Code是否存在");
            //            }
            //            var testAsset = code.GetComponent<ReferenceCollector>().Get<TextAsset>(name);
            //            return testAsset;
            //#endif
            var textAsset = Code_Prefab.GetComponent<ReferenceCollector>().Get<TextAsset>(name);
            return textAsset.bytes;
        }
    }
}