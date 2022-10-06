using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

namespace ET
{
    public class GameSettingLanguge : Singleton<GameSettingLanguge>
    {

        //随机名称
        public int ranNameNum;
        public string[] randomName_xing;
        public string[] randomName_name;
        public bool langLoadStatus;             //本地化语言加载状态 

        public static bool Chinese = true;

        public struct LangugeType
        {
            public string cn;
            public string en;
        }

        public Dictionary<string, LangugeType> LangugeList = new Dictionary<string, LangugeType>();

        public static Dictionary<string, string> MulLanguge = new Dictionary<string, string>();

        public static string LoadLocalization(string getString)
        {
            return GetText(getString);
        }

        protected override void InternalInit()
        {
            base.InternalInit();
        }


        public async ETTask InitRandomName() {

            if (randomName_xing == null)
            {
                var path = ABPathHelper.GetTextPath();
                await ETTask.CompletedTask;
                GameObject prefab = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
                TextAsset textAsset1 = prefab.Get<TextAsset>("RandName_Xing");
                TextAsset textAsset2 = prefab.Get<TextAsset>("RandName_Name");
                LoadWWW_Xing(textAsset1.text);
                LoadWWW_Name(textAsset2.text);
                //Log.Debug(textAsset1.text);
                Log.Debug(randomName_xing[0]);
                Log.Debug(randomName_name[0]);
            }

        }

        /// <summary>
        /// 使用一个协程来进行文件读取
        /// </summary>
        /// <returns></returns>
        //[OPS.Obfuscator.Attribute.DoNotRenameAttribute]
        public void LoadWWW(string wwwStr)
        {
            // WWW www = new WWW("RandName_Name");
            ////不同平台下StreamingAssets的路径是不同的，这里需要注意一下。
            //if (Application.platform == RuntimePlatform.Android)
            //{

            //    www = new WWW(Application.streamingAssetsPath + "/" + "Localization.txt");
            //}
            //else
            //{
            //    //Debug.Log("开始加载字11111");
            //    www = new WWW("file://" + Application.streamingAssetsPath + "/" + "Localization.txt");
            //    //Debug.Log("开始加载字22222" + www.bytes.Length);
            //}
            //yield return www;

            //  if (!(www.Equals("") || www.Equals(null)))
            //{
            //Debug.Log("开始加载屏蔽字33333");
            //LocalizationDebug.Log(www.text);

            //string wwwStr = ""; // www.text;
            wwwStr = wwwStr.Replace("\r", "");
            wwwStr = wwwStr.Replace("\n", "");

            //将读取到的字符串进行分割后存储到定义好的数组中
            string[] zuList = wwwStr.Split('@');
            for (int i = 0; i < zuList.Length; i++)
            {
                string[] List = zuList[i].Split('#');
                if (List.Length >= 3)
                {
                    LangugeType langType = new LangugeType();
                    langType.cn = List[1];
                    langType.en = List[2];
                    if (LangugeList.ContainsKey(List[0]) == false)
                    {
                        LangugeList.Add(List[0], langType);
                    }
                    else
                    {
                        //Debug.Log("本地化语言包有重复项目:" + List[0]);
                    }

                }
            }

            langLoadStatus = true;
            //}
        }

        /// <summary>
        /// 使用一个协程来进行文件读取
        /// </summary>
        /// <returns></returns>
        //[OPS.Obfuscator.Attribute.DoNotRenameAttribute]
        public void LoadWWW_Xing(string wwwStr)
        {
            //  WWW www = new WWW("RandName_Name");
            //不同平台下StreamingAssets的路径是不同的，这里需要注意一下。
            //if (Application.platform == RuntimePlatform.Android)
            //{

            //    www = new WWW(Application.streamingAssetsPath + "/" + "RandName_Xing.txt");
            //}
            //else
            //{
            //    //Debug.Log("开始加载字11111");
            //    www = new WWW("file://" + Application.streamingAssetsPath + "/" + "RandName_Xing.txt");
            //    //Debug.Log("开始加载字22222" + www.bytes.Length);
            //}
            //yield return www;

            //  if (!(www.Equals("") || www.Equals(null)))
            {
                //Debug.Log("开始加载屏蔽字33333");
                //LocalizationDebug.Log(www.text);

                //string wwwStr = "";// www.text;
                wwwStr = wwwStr.Replace("\r", "");
                wwwStr = wwwStr.Replace("\n", "");

                //将读取到的字符串进行分割后存储到定义好的数组中
                randomName_xing = wwwStr.Split('@');

                ranNameNum = ranNameNum + 1;
            }
        }


        /// <summary>
        /// 使用一个协程来进行文件读取
        /// </summary>
        /// <returns></returns>
        //[OPS.Obfuscator.Attribute.DoNotRenameAttribute]
        public void LoadWWW_Name(string wwwStr)
        {
            // WWW www = new WWW("RandName_Name");
            //不同平台下StreamingAssets的路径是不同的，这里需要注意一下。
            //if (Application.platform == RuntimePlatform.Android)
            //{

            //    www = new WWW(Application.streamingAssetsPath + "/" + "RandName_Name.txt");
            //}
            //else
            //{
            //    //Debug.Log("开始加载字11111");
            //    www = new WWW("file://" + Application.streamingAssetsPath + "/" + "RandName_Name.txt");
            //    //Debug.Log("开始加载字22222" + www.bytes.Length);
            //}
            //yield return www;

            // if (!(www.Equals("") || www.Equals(null)))
            {
                //Debug.Log("开始加载屏蔽字33333");
                //LocalizationDebug.Log(www.text);

                //string wwwStr = "";
                wwwStr = wwwStr.Replace("\r", "");
                wwwStr = wwwStr.Replace("\n", "");

                //将读取到的字符串进行分割后存储到定义好的数组中
                randomName_name = wwwStr.Split('@');

                ranNameNum = ranNameNum + 1;
            }
        }

        public static void TransformText(Transform root)
        {
            if (Chinese)
            {
                return;
            }
            foreach (Transform chind in root)
            {
                Text label = chind.GetComponent<Text>();
                if (label != null)
                {
                    string text = label.text;
                    if (!string.IsNullOrEmpty(GetText(text)))
                    {
                        //text = text.Replace("\n", @"\n");
                        label.text = GetText(text);
                    }
                }
                if (chind.childCount > 0)
                {
                    TransformText(chind);
                }
            }
        }

        public static void TransformImage(Transform root)
        {
            if (Chinese)
            {
                return;
            }
            foreach (Transform chind in root)
            {
                Image image = chind.GetComponent<Image>();
                if (image != null && image.sprite!=null)
                {
                    string text = image.sprite.name;
                    Sprite sp =  ABAtlasHelp.GetIconSprite(ABAtlasTypes.MulLanguageIcon, text + "_en");
                    if (sp!=null)
                    {
                        image.sprite = sp;
                    }
                }
                if (chind.childCount > 0)
                {
                    TransformImage(chind);
                }
            }
        }

        public  static string GetText(string text)
        {
            //通过传进来的中文KEY 去数据表里面读对应替换的多语言文字
            if (Chinese)
            {
                return text;
            }
            if (MulLanguge.ContainsKey(text))
            {
                return MulLanguge[text];
            }
            List<MulLanguageConfig> configs = MulLanguageConfigCategory.Instance.GetAll().Values.ToList();
            for (int i = 0; i < configs.Count; i++)
            {
                if (configs[i].Chinese.Equals(text))
                {
                    MulLanguge.Add(text, configs[i].English);
                    return configs[i].English;
                }
            }
            return text;
        }

        public static string GetText(string text, params object[] args)
        {
            //通过传进来的中文KEY 去数据表里面读对应替换的多语言文字
            return string.Format(text, args);
        }

    }
}
