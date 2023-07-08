using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISettingGuaJiComponent:Entity,IAwake
    {

        public GameObject Btn_StopGuaJi;
        public GameObject Btn_StartGuajI;
        public GameObject Image_Click_0;
        public GameObject Btn_Click_0;
        public GameObject Click_GuaJiRange;
        public GameObject Btn_GuaJiRange;
        public GameObject Click_GuaJiAutoUseItem;
        public GameObject Btn_GuaJiAutoUseItem;
    }

    public class UISettingGuaJiComponentAwake : AwakeSystem<UISettingGuaJiComponent>
    {
        public override void Awake(UISettingGuaJiComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Btn_StartGuajI = rc.Get<GameObject>("Btn_StartGuajI");
            self.Btn_StopGuaJi = rc.Get<GameObject>("Btn_StopGuaJi");
            self.Btn_Click_0 = rc.Get<GameObject>("Btn_Click_0");
            self.Image_Click_0 = rc.Get<GameObject>("Image_Click_0");
            self.Click_GuaJiRange = rc.Get<GameObject>("Click_GuaJiRange");
            self.Btn_GuaJiRange = rc.Get<GameObject>("Btn_GuaJiRange");
            self.Click_GuaJiAutoUseItem = rc.Get<GameObject>("Click_GuaJiAutoUseItem");
            self.Btn_GuaJiAutoUseItem = rc.Get<GameObject>("Btn_GuaJiAutoUseItem");

            //给按钮添加监听事件
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

            self.ZoneScene().GetComponent<UserInfoComponent>().UpdateGameSetting(gameSettingInfos);
            self.UpdateGuaJiAutoUseItem();
        }
        public static void UpdateGuaJiSell(this UISettingGuaJiComponent self)
        {
            string acttype = self.ZoneScene().GetComponent<UserInfoComponent>().GetGameSettingValue(GameSettingEnum.GuaJiSell);
            self.Image_Click_0.SetActive(acttype != "0");
        }

        public static void UpdateGuaJiRange(this UISettingGuaJiComponent self)
        {
            string acttype = self.ZoneScene().GetComponent<UserInfoComponent>().GetGameSettingValue(GameSettingEnum.GuaJiRang);
            self.Click_GuaJiRange.SetActive(acttype != "0");
        }

        public static void UpdateGuaJiAutoUseItem(this UISettingGuaJiComponent self)
        {
            string acttype = self.ZoneScene().GetComponent<UserInfoComponent>().GetGameSettingValue(GameSettingEnum.GuaJiAutoUseItem);
            self.Click_GuaJiAutoUseItem.SetActive(acttype != "0");
        }

    }
}
