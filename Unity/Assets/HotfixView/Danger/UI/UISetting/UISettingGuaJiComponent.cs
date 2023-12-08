using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISettingGuaJiComponent:Entity,IAwake,IDestroy
    {
        public GameObject SkillIPositionSet;
        public GameObject SkillIconItem;
        public GameObject Btn_EditSkill;
        public GameObject Btn_StopGuaJi;
        public GameObject Btn_StartGuajI;
        public GameObject Image_Click_0;
        public GameObject Btn_Click_0;
        public GameObject Click_GuaJiRange;
        public GameObject Btn_GuaJiRange;
        public GameObject Click_GuaJiAutoUseItem;
        public GameObject Btn_GuaJiAutoUseItem;
        
        public List<string> AssetPath = new List<string>();
        public List<int> SkillSet = new List<int>();
        public List<GameObject> SkillSetIconRightList = new List<GameObject>();
    }

    public class UISettingGuaJiComponentAwake : AwakeSystem<UISettingGuaJiComponent>
    {
        public override void Awake(UISettingGuaJiComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.SkillIPositionSet = rc.Get<GameObject>("SkillIPositionSet");
            self.SkillIconItem = rc.Get<GameObject>("SkillIconItem");
            self.Btn_EditSkill = rc.Get<GameObject>("Btn_EditSkill");
            self.Btn_StartGuajI = rc.Get<GameObject>("Btn_StartGuajI");
            self.Btn_StopGuaJi = rc.Get<GameObject>("Btn_StopGuaJi");
            self.Btn_Click_0 = rc.Get<GameObject>("Btn_Click_0");
            self.Image_Click_0 = rc.Get<GameObject>("Image_Click_0");
            self.Click_GuaJiRange = rc.Get<GameObject>("Click_GuaJiRange");
            self.Btn_GuaJiRange = rc.Get<GameObject>("Btn_GuaJiRange");
            self.Click_GuaJiAutoUseItem = rc.Get<GameObject>("Click_GuaJiAutoUseItem");
            self.Btn_GuaJiAutoUseItem = rc.Get<GameObject>("Btn_GuaJiAutoUseItem");

            self.SkillIconItem.SetActive(false);
            //给按钮添加监听事件
            self.Btn_EditSkill.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_EditSkill().Coroutine(); });
            self.Btn_StartGuajI.GetComponent<Button>().onClick.AddListener(()=> { self.OpenGuaJi(); } );
            self.Btn_StopGuaJi.GetComponent<Button>().onClick.AddListener(() => { self.StopGuaJi(); } );

            self.Btn_Click_0.GetComponent<Button>().onClick.AddListener(() => { self.ClickSell(); });
            self.Btn_GuaJiRange.GetComponent<Button>().onClick.AddListener(() => { self.ClickGuaJiRange(); });
            self.Btn_GuaJiAutoUseItem.GetComponent<Button>().onClick.AddListener(() => { self.ClickGuaJiAutoUseItem(); });

            //初始化
            self.Init();

            self.UpdateGuaJiSell();
            self.UpdateGuaJiRange();
            self.UpdateGuaJiAutoUseItem();
            self.UpdataSkillSet();
        }
    }
    
    public class UISettingGuaJiComponentDestroy: DestroySystem<UISettingGuaJiComponent>
    {
        public override void Destroy(UISettingGuaJiComponent self)
        {
            for (int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]);
                }
            }

            self.AssetPath = null;
        }
    }

    public static class UISettingGuaJiComponentSystem {

        public static void Init(this UISettingGuaJiComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            List<KeyValuePair> gameSettingInfos = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.GameSettingInfos;
            bool ifHaveGuaJiSell = false;
            bool ifHaveGuaJiRang = false;
            bool ifHaveGuaJiAutoUseItem = false;
            for (int i = 0; i < gameSettingInfos.Count; i++)
            {

                if (gameSettingInfos[i].KeyId == (int)GameSettingEnum.GuaJiSell)
                {
                    ifHaveGuaJiSell = true;
                    break;
                }

                if (gameSettingInfos[i].KeyId == (int)GameSettingEnum.GuaJiRang)
                {
                    ifHaveGuaJiRang = true;
                    break;
                }

                if (gameSettingInfos[i].KeyId == (int)GameSettingEnum.GuaJiAutoUseItem)
                {
                    ifHaveGuaJiAutoUseItem = true;
                    break;
                }

            }

            //找到没有的键值进行保存
            if (ifHaveGuaJiSell == false)
            {
                KeyValuePair pair = new KeyValuePair();
                pair.KeyId = (int)GameSettingEnum.GuaJiSell;
                pair.Value = "0";
                pair.Value2 = "0";
                unit.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.GameSettingInfos.Add(pair);
            }
            if (ifHaveGuaJiRang == false)
            {
                KeyValuePair pair = new KeyValuePair();
                pair.KeyId = (int)GameSettingEnum.GuaJiRang;
                pair.Value = "0";
                pair.Value2 = "0";
                unit.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.GameSettingInfos.Add(pair);
            }
            if (ifHaveGuaJiAutoUseItem == false)
            {
                KeyValuePair pair = new KeyValuePair();
                pair.KeyId = (int)GameSettingEnum.GuaJiAutoUseItem;
                pair.Value = "0";
                pair.Value2 = "0";
                unit.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.GameSettingInfos.Add(pair);
            }
            
            int childCount = self.SkillIPositionSet.transform.childCount;
            for (int i = 0; i < childCount; i++)
            {
                GameObject go = UnityEngine.Object.Instantiate(self.SkillIconItem);
                go.SetActive(false);
                UICommonHelper.SetParent(go, self.SkillIPositionSet.transform.GetChild(i).gameObject);
                self.SkillSetIconRightList.Add(go);
            }
        }

        public static async ETTask OnBtn_EditSkill(this UISettingGuaJiComponent self)
        {
            UI ui = await UIHelper.Create(self.ZoneScene(), UIType.UISettingSkill);
            ui.GetComponent<UISettingSkillComponent>().CloseAction = self.UpdataSkillSet;
        }

        public static void UpdataSkillSet(this UISettingGuaJiComponent self)
        {
            self.SkillSet.Clear();
            string[] skillIndexs = self.ZoneScene().GetComponent<UserInfoComponent>().GetGameSettingValue(GameSettingEnum.GuaJiAutoUseSkill)
                    .Split('@');
            if (skillIndexs.Length > 0)
            {
                foreach (string skill in skillIndexs)
                {
                    if (skill == "")
                    {
                        continue;
                    }

                    self.SkillSet.Add(int.Parse(skill));
                }
            }
            
            SkillSetComponent skillSetComponent = self.ZoneScene().GetComponent<SkillSetComponent>();
            for (int i = 0; i < self.SkillSetIconRightList.Count; i++)
            {
                GameObject itemgo = self.SkillSetIconRightList[i];
                GameObject addImage = itemgo.transform.parent.GetChild(0).gameObject;

                itemgo.SetActive(false);
                addImage.GetComponent<Image>().fillAmount = 1;

                if (i >= self.SkillSet.Count)
                {
                    continue;
                }

                SkillPro skillPro = skillSetComponent.GetByPosition(self.SkillSet[i] + 1);

                if (skillPro == null)
                {
                    addImage.GetComponent<Image>().fillAmount = 1;
                    itemgo.SetActive(false);
                    continue;
                }

                addImage.GetComponent<Image>().fillAmount = 0;
                itemgo.SetActive(true);
                if (skillPro.SkillSetType == SkillSetEnum.Skill)
                {
                    SkillConfig skillConfig = SkillConfigCategory.Instance.Get(SkillHelp.GetWeaponSkill(skillPro.SkillID,
                        UnitHelper.GetEquipType(self.ZoneScene()), skillSetComponent.SkillList));
                    string path = ABPathHelper.GetAtlasPath_2(ABAtlasTypes.RoleSkillIcon, skillConfig.SkillIcon);
                    Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                    if (!self.AssetPath.Contains(path))
                    {
                        self.AssetPath.Add(path);
                    }

                    itemgo.transform.Find("Img_Mask/Img_SkillIcon").GetComponent<Image>().sprite = sp;
                }
            }
        }

        //开始挂机
        public static void OpenGuaJi(this UISettingGuaJiComponent self ) 
        {
            MapComponent mapComponent = self.ZoneScene().GetComponent<MapComponent>();
            if (mapComponent.SceneTypeEnum != SceneTypeEnum.LocalDungeon)
            {
                FloatTipManager.Instance.ShowFloatTip("当前地图不能挂机!");
                return;
            }

            //判断是否有体力,没体力不能挂机,减少服务器开销
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (unit.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.PiLao <= 0)
            {
                if (self.ZoneScene().GetComponent<UnitGuaJiComponen>() != null)
                {
                    //移除挂机组件
                    self.ZoneScene().RemoveComponent<UnitGuaJiComponen>();
                }
                FloatTipManager.Instance.ShowFloatTip("体力已经消耗完毕,请确保体力充足喔!");
                return;
            };

            // 等级判断，达到12级才能挂机
            if (unit.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv < 12)
            {
                FloatTipManager.Instance.ShowFloatTip("达到12级才能挂机哦!");
                return;
            }
            
            //添加挂机组件
            if (self.ZoneScene().GetComponent<UnitGuaJiComponen>() == null)
            {
                self.ZoneScene().AddComponent<UnitGuaJiComponen>();
                FloatTipManager.Instance.ShowFloatTip("开始挂机!");
            }
            else
            {
                //当前已经在挂机
                FloatTipManager.Instance.ShowFloatTip("当前正在挂机,请确保周围是怪物刷新点!");
            }

            //关闭设置界面
            UIHelper.Remove(self.ZoneScene(), UIType.UISetting);
        }

        //停止挂机
        public static void StopGuaJi(this UISettingGuaJiComponent self)
        {
            if (self.ZoneScene().GetComponent<UnitGuaJiComponen>() != null)
            {
                //移除挂机组件
                self.ZoneScene().RemoveComponent<UnitGuaJiComponen>();
                FloatTipManager.Instance.ShowFloatTip("取消挂机!");
            }
            UI uimain = UIHelper.GetUI(self.ZoneScene(), UIType.UIMain);
            uimain.GetComponent<UIMainComponent>().UGuaJiSet.SetActive(false);
        }

        public static void ClickSell(this UISettingGuaJiComponent self) {

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            string acttype = self.ZoneScene().GetComponent<UserInfoComponent>().GetGameSettingValue(GameSettingEnum.GuaJiSell);
            if (acttype == "0")
            {
                acttype = "1";
            }
            else
            {
                acttype = "0";
            }

            List<KeyValuePair> gameSettingInfos = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.GameSettingInfos;

            for (int i = 0; i < gameSettingInfos.Count; i++)
            {
                if (gameSettingInfos[i].KeyId == (int)GameSettingEnum.GuaJiSell)
                {
                    gameSettingInfos[i].Value = acttype;
                    break;
                }
            }
            
            // 存储设置到本地
            self.SetSettingValueToLocal(GameSettingEnum.GuaJiSell.ToString(), acttype);

            self.ZoneScene().GetComponent<UserInfoComponent>().UpdateGameSetting(gameSettingInfos);
            self.UpdateGuaJiSell();
        }

        public static void ClickGuaJiRange(this UISettingGuaJiComponent self)
        {
            string acttype = self.ZoneScene().GetComponent<UserInfoComponent>().GetGameSettingValue(GameSettingEnum.GuaJiRang);
            if (acttype == "0")
            {
                acttype = "1";
            }
            else
            {
                acttype = "0";
            }

            List<KeyValuePair> gameSettingInfos = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.GameSettingInfos;

            for (int i = 0; i < gameSettingInfos.Count; i++)
            {
                if (gameSettingInfos[i].KeyId == (int)GameSettingEnum.GuaJiRang)
                {
                    gameSettingInfos[i].Value = acttype;
                    break;
                }
            }

            // 存储设置到本地
            self.SetSettingValueToLocal(GameSettingEnum.GuaJiRang.ToString(), acttype);
            
            self.ZoneScene().GetComponent<UserInfoComponent>().UpdateGameSetting(gameSettingInfos);
            self.UpdateGuaJiRange();
        }

        public static void ClickGuaJiAutoUseItem(this UISettingGuaJiComponent self)
        {
            string acttype = self.ZoneScene().GetComponent<UserInfoComponent>().GetGameSettingValue(GameSettingEnum.GuaJiAutoUseItem);
            if (acttype == "0")
            {
                acttype = "1";
            }
            else
            {
                acttype = "0";
            }

            List<KeyValuePair> gameSettingInfos = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.GameSettingInfos;

            for (int i = 0; i < gameSettingInfos.Count; i++)
            {
                if (gameSettingInfos[i].KeyId == (int)GameSettingEnum.GuaJiAutoUseItem)
                {
                    gameSettingInfos[i].Value = acttype;
                    break;
                }
            }

            // 存储设置到本地
            self.SetSettingValueToLocal(GameSettingEnum.GuaJiAutoUseItem.ToString(), acttype);
            
            self.ZoneScene().GetComponent<UserInfoComponent>().UpdateGameSetting(gameSettingInfos);
            self.UpdateGuaJiAutoUseItem();
        }
        public static void UpdateGuaJiSell(this UISettingGuaJiComponent self)
        {
            // 因为没有直接同步服务器，先从本地获取并存储到本地
            string value = self.GetSettingValueFromLocal(GameSettingEnum.GuaJiSell.ToString());
            foreach (KeyValuePair valuePair in self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.GameSettingInfos)
            {
                if (valuePair.KeyId == (int)GameSettingEnum.GuaJiSell)
                {
                    valuePair.Value = value;
                }
            }
            
            // string acttype = self.ZoneScene().GetComponent<UserInfoComponent>().GetGameSettingValue(GameSettingEnum.GuaJiSell);
            self.Image_Click_0.SetActive(value != "0");
        }

        public static void UpdateGuaJiRange(this UISettingGuaJiComponent self)
        {
            // 因为没有直接同步服务器，先从本地获取并存储到本地
            string value = self.GetSettingValueFromLocal(GameSettingEnum.GuaJiRang.ToString());
            foreach (KeyValuePair valuePair in self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.GameSettingInfos)
            {
                if (valuePair.KeyId == (int)GameSettingEnum.GuaJiRang)
                {
                    valuePair.Value = value;
                }
            }
            
            //string acttype = self.ZoneScene().GetComponent<UserInfoComponent>().GetGameSettingValue(GameSettingEnum.GuaJiRang);
            self.Click_GuaJiRange.SetActive(value != "0");
        }

        public static void UpdateGuaJiAutoUseItem(this UISettingGuaJiComponent self)
        {
            // 因为没有直接同步服务器，先从本地获取并存储到本地
            string value = self.GetSettingValueFromLocal(GameSettingEnum.GuaJiAutoUseItem.ToString());
            foreach (KeyValuePair valuePair in self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.GameSettingInfos)
            {
                if (valuePair.KeyId == (int)GameSettingEnum.GuaJiAutoUseItem)
                {
                    valuePair.Value = value;
                }
            }
            
            //string acttype = self.ZoneScene().GetComponent<UserInfoComponent>().GetGameSettingValue(GameSettingEnum.GuaJiAutoUseItem);
            self.Click_GuaJiAutoUseItem.SetActive(value != "0");
        }

        /// <summary>
        /// 从本地获取游戏设置数据
        /// </summary>
        /// <param name="self"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetSettingValueFromLocal(this UISettingGuaJiComponent self, string key)
        {
            if (PlayerPrefs.HasKey(key))
            {
                return PlayerPrefs.GetString(key);
            }

            return "0";
        }

        /// <summary>
        /// 存储游戏设置到本地
        /// </summary>
        /// <param name="self"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void SetSettingValueToLocal(this UISettingGuaJiComponent self, string key, string value)
        {
            PlayerPrefs.SetString(key, value);
        }
    }
}
