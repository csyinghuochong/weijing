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

        public static int Language = 0;

        public struct LangugeType
        {
            public string cn;
            public string en;
        }

        public Dictionary<string, LangugeType> LangugeList = new Dictionary<string, LangugeType>();

        public static Dictionary<string, string> MulLanguage = new Dictionary<string, string>();

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
            Language = PlayerPrefsHelp.GetInt(PlayerPrefsHelp.Language);
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
            if (Language == 0)
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
            if (Language == 0)
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
            
            // 方案2
            foreach (Transform chind in root)
            {
                Image image = chind.GetComponent<Image>();
                if (image != null && image.sprite != null)
                {
                    string text = image.sprite.name;
                    
                    ReferenceCollector re = chind.GetComponent<ReferenceCollector>();
                    if (re != null)
                    {
                        Sprite sp_EN = re.Get<Sprite>(text + "_EN");
                        if (sp_EN != null)
                        {
                            image.sprite = sp_EN;
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
            foreach (ItemConfig config in ItemConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.ItemName, config.ItemName_EN);
                AddMulLanguageData(config.ItemDes, config.ItemDes_EN);
            }

            foreach (HideProListConfig config in HideProListConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Name, config.Name_EN);
            }

            foreach (NpcConfig config in NpcConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Name, config.Name_EN);
                AddMulLanguageData(config.NpcHeadSpeakText, config.NpcHeadSpeakText_EN);
                AddMulLanguageData(config.SpeakText, config.SpeakText_EN);
            }

            foreach (PetConfig config in PetConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.PetName, config.PetName_EN);
            }

            foreach (SceneConfig config in SceneConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Name, config.Name_EN);
                AddMulLanguageData(config.ChapterDes, config.ChapterDes_EN);
            }

            foreach (SkillConfig config in SkillConfigCategory.Instance.GetAll().Values)  
            {
                AddMulLanguageData(config.SkillName, config.SkillName_EN);
                AddMulLanguageData(config.SkillDescribe, config.SkillDescribe_EN);
            }

            foreach (TalentConfig config in TalentConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Name, config.Name_EN);
                AddMulLanguageData(config.TalentDes, config.TalentDes_EN);
            }

            foreach (SkillBuffConfig config in SkillBuffConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.BuffName, config.BuffName_EN);
                AddMulLanguageData(config.BuffDescribe, config.BuffDescribe_EN);
            }

            foreach (ActivityConfig config in ActivityConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Par_4, config.Par_4_EN);
            }

            foreach (OccupationConfig config in OccupationConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.OccupationName, config.OccupationName_EN);
            }

            foreach (OccupationTwoConfig config in OccupationTwoConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.OccupationName, config.OccupationName_EN);
                AddMulLanguageData(config.OccDes, config.OccDes_EN);
            }

            foreach (TaskConfig config in TaskConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.TaskName, config.TaskName_EN);
                AddMulLanguageData(config.TaskDes, config.TaskDes_EN);
            }

            foreach (MonsterConfig config in MonsterConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.MonsterName, config.MonsterName_EN);
            }

            foreach (ZuoQiShowConfig config in ZuoQiShowConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Name, config.Name_EN);
                AddMulLanguageData(config.Des, config.Des_EN);
                AddMulLanguageData(config.GetDes, config.GetDes_EN);
            }

            foreach (TitleConfig config in TitleConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Name, config.Name_EN);
                AddMulLanguageData(config.Des, config.Des_EN);
                AddMulLanguageData(config.GetDes, config.GetDes_EN);
            }

            foreach (FashionConfig config in FashionConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Name, config.Name_EN);
                AddMulLanguageData(config.PropertyDes, config.PropertyDes_EN);
            }

            foreach (LifeShieldConfig config in LifeShieldConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.ShieldName, config.ShieldName_EN);
                AddMulLanguageData(config.Des, config.Des_EN);
            }

            foreach (TowerConfig config in TowerConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Name,  config.Name_EN);
            }

            foreach (PublicQiangHuaConfig config in PublicQiangHuaConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.EquipSpaceName, config.EquipSpaceName_EN);
            }

            foreach (JiaYuanConfig config in JiaYuanConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Name, config.Name_EN);
                AddMulLanguageData(config.JiaYuanDes, config.JiaYuanDes_EN);
            }

            foreach (UnionQiangHuaConfig config in UnionQiangHuaConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.EquipSpaceName, config.EquipSpaceName_EN);
            }

            foreach (TaskCountryConfig config in TaskCountryConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.TaskName, config.TaskName_EN);
                AddMulLanguageData(config.TaskDes, config.TaskDes_EN);
            }

            foreach (DungeonConfig config in DungeonConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.ChapterName, config.ChapterDes_EN);
            }

            foreach (EquipSuitPropertyConfig config in EquipSuitPropertyConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.EquipSuitDes, config.EquipSuitDes_EN);
            }

            foreach (EquipSuitConfig config in EquipSuitConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Name, config.Name_EN);
            }

            foreach (DungeonSectionConfig config in DungeonSectionConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.ChapterName, config.ChapterName_EN);
                AddMulLanguageData(config.Name, config.Name_EN);
            }

            foreach (PetSkinConfig config in PetSkinConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Name, config.Name_EN);
            }

            foreach (JingLingConfig config in JingLingConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Name, config.Name_EN);
                AddMulLanguageData(config.ProDes, config.ProDes_EN);
                AddMulLanguageData(config.Des, config.Des_EN);
                AddMulLanguageData(config.GetDes, config.GetDes_EN);
            }

            foreach (UnionKeJiConfig config in UnionKeJiConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.EquipSpaceName,  config.EquipSpaceName_EN);
            }

            foreach (PetFubenConfig config in PetFubenConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Name, config.Name_EN);
            }

            foreach (TaskPositionConfig config in TaskPositionConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.MapName, config.MapName_EN);
            }

            foreach (EquipXiLianConfig config in EquipXiLianConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Title, config.Title_EN);
            }

            foreach (GuideConfig config in GuideConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Text, config.Text_EN);
            }

            foreach (JiaYuanFarmConfig config in JiaYuanFarmConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Name, config.Name_EN);
                AddMulLanguageData(config.Speak, config.Speak_EN);
                AddMulLanguageData(config.Des, config.Des_EN);
            }

            foreach (JiaYuanPastureConfig config in JiaYuanPastureConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Name, config.Name_EN);
                AddMulLanguageData(config.Speak, config.Speak_EN);
                AddMulLanguageData(config.Des, config.Des_EN);
            }

            foreach (BattleSummonConfig config in BattleSummonConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.ItemName, config.ItemName_EN);
            }

            foreach (ChengJiuConfig config in ChengJiuConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Name, config.Name_EN);
                AddMulLanguageData(config.Des, config.Des_EN);
            }

            foreach (ChengJiuRewardConfig config in ChengJiuRewardConfigCategory.Instance.GetAll().Values)
            {
                AddMulLanguageData(config.Desc, config.Desc_EN);
            }
            
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

            if (!MulLanguage.ContainsKey(chinese))
            {
                MulLanguage.Add(chinese, english);
            }
        }
        
        private static string GetText(string text)
        {
            //通过传进来的中文KEY 去数据表里面读对应替换的多语言文字
            if (Language == 0)
            {
                return text;
            }

            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            if (MulLanguage.TryGetValue(text, out string text1))
            {
                return text1;
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
