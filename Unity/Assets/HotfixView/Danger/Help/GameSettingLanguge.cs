using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Text.RegularExpressions;
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

        private static bool IsChange = false;
        private static int language = 0;

        public static int Language
        {
            get
            {
                return language;
            }
            set
            {
                if (value == language)
                {
                    return;
                }

                language = value;
                IsChange = true;
                PlayerPrefsHelp.SetInt(PlayerPrefsHelp.Language, value);
                PlayerPrefsHelp.SetInt(PlayerPrefsHelp.LanguageSet, 1);
                HintHelp.GetInstance().DataUpdate(DataType.LanguageUpdate);
            }
        }

        public struct LangugeType
        {
            public string cn;
            public string en;
        }

        private Dictionary<string, LangugeType> LangugeList = new Dictionary<string, LangugeType>();

        private static Dictionary<string, string> ZhToEn = new Dictionary<string, string>();
        private static Dictionary<string, string> EnToZh = new Dictionary<string, string>();

        public static string LoadLocalization(string getString)
        {
            return GetText(getString);
        }

        protected override void InternalInit()
        {
            base.InternalInit();
        }

        public async ETTask InitRandomName()
        {
            if (randomName_xing == null)
            {
                var path_1 = ABPathHelper.GetTextPath("RandName_Xing");
                var path_2 = ABPathHelper.GetTextPath("RandName_Name");
                TextAsset textAsset1 = await ResourcesComponent.Instance.LoadAssetAsync<TextAsset>(path_1);
                TextAsset textAsset2 = await ResourcesComponent.Instance.LoadAssetAsync<TextAsset>(path_2);
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
            if (Language == 0 && !IsChange)
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
            if (Language == 0 && !IsChange)
            {
                return;
            }
            // 有点慢，先屏蔽 方案1
            // foreach (Transform chind in root)
            // {
            //     Image image = chind.GetComponent<Image>();
            //     if (image != null && image.sprite!=null)
            //     {
            //         string text = image.sprite.name;
            //         var path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.MulLanguageIcon, text + "_en");
            //         Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            //         if (sp!=null)
            //         {
            //             image.sprite = sp;
            //         }
            //     }
            //     if (chind.childCount > 0)
            //     {
            //         TransformImage(chind);
            //     }
            // }
            
            // 方案2 Mac会丢失图片
            // foreach (Transform chind in root)
            // {
            //     Image image = chind.GetComponent<Image>();
            //     if (image != null && image.sprite != null)
            //     {
            //         string text = image.sprite.name;
            //         ReferenceCollector re = chind.GetComponent<ReferenceCollector>();
            //         if (re != null)
            //         {
            //             if (text.EndsWith("_EN"))
            //             {
            //                 text = text.Substring(0, text.Length - 3);
            //             }
            //             
            //             Sprite sprite = null;
            //             if (Language == 0)
            //             {
            //                 sprite = re.Get<Sprite>(text);
            //             }
            //             else
            //             {
            //                 sprite = re.Get<Sprite>(text + "_EN");
            //             }
            //                     
            //             if (sprite != null)
            //             {
            //                 image.sprite = sprite;
            //             }
            //         }
            //     }
            //
            //     if (chind.childCount > 0)
            //     {
            //         TransformImage(chind);
            //     }
            // }
            
            // 方案 3
            foreach (Transform chind in root)
            {
                Image image = chind.GetComponent<Image>();
                if (image != null && image.sprite != null)
                {
                    ReferenceCollector rc = chind.GetComponent<ReferenceCollector>();
                    if (rc != null)
                    {
                        GameObject imgGo = null;
                        if (Language == 0)
                        {
                            imgGo = rc.Get<GameObject>("ZH");
                        }
                        else
                        {
                            imgGo = rc.Get<GameObject>("EN");
                        }

                        if (imgGo != null)
                        {
                            Sprite sprite = imgGo.GetComponent<Image>().sprite;
                            if (sprite != null)
                            {
                                image.sprite = sprite;
                            }
                        }
                    }
                }

                if (chind.childCount > 0)
                {
                    TransformImage(chind);
                }
            }
        }

        public static void InitMulLanguageData()
        {
            Language = PlayerPrefsHelp.GetInt(PlayerPrefsHelp.Language);
            
            foreach (MulLanguageConfig config in MulLanguageConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Chinese, config.English);
            }
        }

        private static void AddMulLanguageData(string chinese, string english)
        {
            if (string.IsNullOrEmpty(chinese) || string.IsNullOrEmpty(english))
            {
                return;
            }

            if (!ZhToEn.ContainsKey(chinese))
            {
                ZhToEn.Add(chinese, english);
            }
            
            if (!EnToZh.ContainsKey(english))
            {
                EnToZh.Add(english, chinese);
            }
        }
        
        private static string GetText(string text)
        {
            if (Language == 0 && !IsChange)
            {
                return text;
            }

            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            int textType = -1;
            foreach (char c in text)
            {
                if (char.IsWhiteSpace(c) || char.IsPunctuation(c) || char.IsDigit(c))
                    continue;

                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    // 英文
                    textType = 1;
                }
                else
                {
                    // 中文
                    textType = 0;
                }
                break;
            }

            if (textType == Language)
            {
                return text;
            }

            if (Language == 0)
            {
                // 英文转中文
                if (EnToZh.TryGetValue(text, out string text1))
                {
                    return text1;
                }
            }
            else
            {
                // 中文转英文
                if (ZhToEn.TryGetValue(text, out string text1))
                {
                    return text1;
                }
            }

            return text;
        }


        public static string EmailTranslate(string input)
        {
            if (Language == 0)
            {
                return input;
            }

            for (int id = 300001; id < 310000 ; id++)
            {
                if (!MulLanguageConfigCategory.Instance.Contain(id))
                {
                    return input;
                }

                MulLanguageConfig config = MulLanguageConfigCategory.Instance.Get(id);

                if (input == config.Chinese)
                {
                    return config.English;
                }

                string zhTemplate = config.Chinese;
                string enTemplate = config.English;

                string pattern = Regex.Replace(zhTemplate, @"\{(\d+)\}", "(.+?)");
                pattern = "^" + pattern + "$"; // 完整匹配

                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    // 提取参数
                    List<string> args = new List<string>();
                    for (int i = 1; i < match.Groups.Count; i++)
                    {
                        args.Add(match.Groups[i].Value);
                    }

                    // 拼接英文
                    string result = string.Format(enTemplate, args.ToArray());
                    return result;
                }
            }

            return input;
        }

        public static string GetText(string text, params object[] args)
        {
            //通过传进来的中文KEY 去数据表里面读对应替换的多语言文字
            return string.Format(text, args);
        }
    }
    
    public static class MulLanguageHelper
    {
        public static string GetItemName(this ItemConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.ItemName;
            }
            else
            {
                return self.ItemName_EN;
            }
        }
        
        public static string GetItemDes(this ItemConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.ItemDes;
            }
            else
            {
                return self.ItemDes_EN;
            }
        }
        
        public static string GetName(this HideProListConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Name;
            }
            else
            {
                return self.Name_EN;
            }
        }
        
        public static string GetName(this NpcConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Name;
            }
            else
            {
                return self.Name_EN;
            }
        }
        
        public static string GetNpcHeadSpeakText(this NpcConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.NpcHeadSpeakText;
            }
            else
            {
                return self.NpcHeadSpeakText_EN;
            }
        }
        
        public static string GetSpeakText(this NpcConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.SpeakText;
            }
            else
            {
                return self.SpeakText_EN;
            }
        }

        public static string ShowPetName(string name)
        {
            foreach (PetConfig config in PetConfigCategory.Instance.GetAll().Values)
            {
                if (config.PetName == name || config.PetName_EN == name)
                {
                    if (GameSettingLanguge.Language == 0)
                    {
                        return config.PetName;
                    }
                    else
                    {
                        return config.PetName_EN;
                    }
                }
            }

            foreach (PetSkinConfig config in PetSkinConfigCategory.Instance.GetAll().Values)
            {
                if (config.Name == name || config.Name_EN == name)
                {
                    if (GameSettingLanguge.Language == 0)
                    {
                        return config.Name;
                    }
                    else
                    {
                        return config.Name_EN;
                    }
                }
            }

            return name;
        }
        
        public static string GetPetName(this PetConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.PetName;
            }
            else
            {
                return self.PetName_EN;
            }
        }
        
        public static string GetName(this SceneConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Name;
            }
            else
            {
                return self.Name_EN;
            }
        }
        
        public static string GetChapterDes(this SceneConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.ChapterDes;
            }
            else
            {
                return self.ChapterDes_EN;
            }
        }
        
        public static string GetSkillName(this SkillConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.SkillName;
            }
            else
            {
                return self.SkillName_EN;
            }
        }
        
        public static string GetSkillDescribe(this SkillConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.SkillDescribe;
            }
            else
            {
                return self.SkillDescribe_EN;
            }
        }
        
        public static string GetName(this TalentConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Name;
            }
            else
            {
                return self.Name_EN;
            }
        }
        
        public static string GettalentDes(this TalentConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.talentDes;
            }
            else
            {
                return self.talentDes_EN;
            }
        }
        
        public static string GetBuffName(this SkillBuffConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.BuffName;
            }
            else
            {
                return self.BuffName_EN;
            }
        }
        
        public static string GetBuffDescribe(this SkillBuffConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.BuffDescribe;
            }
            else
            {
                return self.BuffDescribe_EN;
            }
        }
        
        public static string GetPar_4(this ActivityConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Par_4;
            }
            else
            {
                return self.Par_4_EN;
            }
        }
        
        public static string GetOccupationName(this OccupationConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.OccupationName;
            }
            else
            {
                return self.OccupationName_EN;
            }
        }
        
        public static string GetOccupationName(this OccupationTwoConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.OccupationName;
            }
            else
            {
                return self.OccupationName_EN;
            }
        }
        
        public static string GetOccDes(this OccupationTwoConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.OccDes;
            }
            else
            {
                return self.OccDes_EN;
            }
        }
        
        public static string GetTaskName(this TaskConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.TaskName;
            }
            else
            {
                return self.TaskName_EN;
            }
        }
        
        public static string GetTaskDes(this TaskConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.TaskDes;
            }
            else
            {
                return self.TaskDes_EN;
            }
        }
        
        public static string GetMonsterName(this MonsterConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.MonsterName;
            }
            else
            {
                return self.MonsterName_EN;
            }
        }
        
        public static string GetName(this ZuoQiShowConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Name;
            }
            else
            {
                return self.Name_EN;
            }
        }
        
        public static string GetDes(this ZuoQiShowConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Des;
            }
            else
            {
                return self.Des_EN;
            }
        }
        
        public static string GetGetDes(this ZuoQiShowConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.GetDes;
            }
            else
            {
                return self.GetDes_EN;
            }
        }
        
        public static string GetName(this TitleConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Name;
            }
            else
            {
                return self.Name_EN;
            }
        }
        
        public static string GetDes(this TitleConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Des;
            }
            else
            {
                return self.Des_EN;
            }
        }
        
        public static string GetGetDes(this TitleConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.GetDes;
            }
            else
            {
                return self.GetDes_EN;
            }
        }
        
        public static string GetName(this FashionConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Name;
            }
            else
            {
                return self.Name_EN;
            }
        }
        
        public static string GetPropertyDes(this FashionConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.PropertyDes;
            }
            else
            {
                return self.PropertyDes_EN;
            }
        }
        
        public static string GetName(this TowerConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Name;
            }
            else
            {
                return self.Name_EN;
            }
        }
        
        public static string GetEquipSpaceName(this PublicQiangHuaConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.EquipSpaceName;
            }
            else
            {
                return self.EquipSpaceName_EN;
            }
        }
        
        public static string GetName(this JiaYuanConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Name;
            }
            else
            {
                return self.Name_EN;
            }
        }
        
        public static string GetJiaYuanDes(this JiaYuanConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.JiaYuanDes;
            }
            else
            {
                return self.JiaYuanDes_EN;
            }
        }

        public static string GetEquipSpaceName(this UnionQiangHuaConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.EquipSpaceName;
            }
            else
            {
                return self.EquipSpaceName_EN;
            }
        }
        
        public static string GetTaskName(this TaskCountryConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.TaskName;
            }
            else
            {
                return self.TaskName_EN;
            }
        }
        
        public static string GetTaskDes(this TaskCountryConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.TaskDes;
            }
            else
            {
                return self.TaskDes_EN;
            }
        }
        
        public static string GetChapterName(this DungeonConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.ChapterName;
            }
            else
            {
                return self.ChapterName_EN;
            }
        }
        
        public static string GetEquipSuitDes(this EquipSuitPropertyConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.EquipSuitDes;
            }
            else
            {
                return self.EquipSuitDes_EN;
            }
        }
        
        public static string GetName(this EquipSuitConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Name;
            }
            else
            {
                return self.Name_EN;
            }
        }
        
        public static string GetChapterName(this DungeonSectionConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.ChapterName;
            }
            else
            {
                return self.ChapterName_EN;
            }
        }
        
        public static string GetName(this DungeonSectionConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Name;
            }
            else
            {
                return self.Name_EN;
            }
        }
        
        public static string GetName(this PetSkinConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Name;
            }
            else
            {
                return self.Name_EN;
            }
        }
        
        public static string GetPripertyShow(this PetSkinConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.PripertyShow;
            }
            else
            {
                return self.PripertyShow_EN;
            }
        }
     
        public static string ShowJingLingName(string name)
        {
            foreach (JingLingConfig config in JingLingConfigCategory.Instance.GetAll().Values)
            {
                if (config.Name == name || config.Name_EN == name)
                {
                    if (GameSettingLanguge.Language == 0)
                    {
                        return config.Name;
                    }
                    else
                    {
                        return config.Name_EN;
                    }
                }
            }

            return name;
        }
        
        public static string GetName(this JingLingConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Name;
            }
            else
            {
                return self.Name_EN;
            }
        }
        
        public static string GetProDes(this JingLingConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.ProDes;
            }
            else
            {
                return self.ProDes_EN;
            }
        }
        
        public static string GetDes(this JingLingConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Des;
            }
            else
            {
                return self.Des_EN;
            }
        }
        
        public static string GetGetDes(this JingLingConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.GetDes;
            }
            else
            {
                return self.GetDes_EN;
            }
        }
        
        public static string GetEquipSpaceName(this UnionKeJiConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.EquipSpaceName;
            }
            else
            {
                return self.EquipSpaceName_EN;
            }
        }
        
        public static string GetName(this PetFubenConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Name;
            }
            else
            {
                return self.Name_EN;
            }
        }
        
        public static string GetMapName(this TaskPositionConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.MapName;
            }
            else
            {
                return self.MapName_EN;
            }
        }
        
        public static string GetTitle(this EquipXiLianConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Title;
            }
            else
            {
                return self.Title_EN;
            }
        }
        
        public static string GetText(this GuideConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Text;
            }
            else
            {
                return self.Text_EN;
            }
        }
        
        public static string GetName(this JiaYuanFarmConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Name;
            }
            else
            {
                return self.Name_EN;
            }
        }
        
        public static string GetSpeak(this JiaYuanFarmConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Speak;
            }
            else
            {
                return self.Speak_EN;
            }
        }
        
        public static string GetDes(this JiaYuanFarmConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Des;
            }
            else
            {
                return self.Des_EN;
            }
        }
        
        public static string GetName(this JiaYuanPastureConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Name;
            }
            else
            {
                return self.Name_EN;
            }
        }
        
        public static string GetSpeak(this JiaYuanPastureConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Speak;
            }
            else
            {
                return self.Speak_EN;
            }
        }
        
        public static string GetDes(this JiaYuanPastureConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Des;
            }
            else
            {
                return self.Des_EN;
            }
        }
        
        public static string GetItemName(this BattleSummonConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.ItemName;
            }
            else
            {
                return self.ItemName_EN;
            }
        }
        
        public static string GetName(this ChengJiuConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Name;
            }
            else
            {
                return self.Name_EN;
            }
        }
        
        public static string GetDes(this ChengJiuConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Des;
            }
            else
            {
                return self.Des_EN;
            }
        }
        
        public static string GetDesc(this ChengJiuRewardConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Desc;
            }
            else
            {
                return self.Desc_EN;
            }
        }
        
        public static string GetShieldName(this LifeShieldConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.ShieldName;
            }
            else
            {
                return self.ShieldName_EN;
            }
        }
        
        public static string GetDes(this LifeShieldConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Des;
            }
            else
            {
                return self.Des_EN;
            }
        }

        public static string GetName(this MagickaSlotConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.MagicName;
            }
            else
            {
                return self.MagicName_EN;
            }
        }

        public static string GetDes(this MagickaSlotConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Des;
            }
            else
            {
                return self.Des_EN;
            }
        }

        public static string GetName(this DungeonTransferConfig self)
        {
            if (GameSettingLanguge.Language == 0)
            {
                return self.Name;
            }
            else
            {
                return self.Name_EN;
            }
        }
    }
}
