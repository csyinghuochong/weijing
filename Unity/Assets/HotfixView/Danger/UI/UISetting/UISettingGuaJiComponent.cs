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

            //给按钮添加监听事件
            self.Btn_StartGuajI.GetComponent<Button>().onClick.AddListener(()=> { self.OpenGuaJi(); } );
            self.Btn_StopGuaJi.GetComponent<Button>().onClick.AddListener(() => { self.StopGuaJi(); } );

            self.Btn_Click_0.GetComponent<Button>().onClick.AddListener(() => { self.ClickSell(); });


            //初始化
            self.Init();

            self.UpdateGuaJiSell();
        }
    }


    public static class UISettingGuaJiComponentSystem {

        public static void Init(this UISettingGuaJiComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            List<KeyValuePair> gameSettingInfos = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.GameSettingInfos;
            bool ifHaveGuaJiSell = false;
            for (int i = 0; i < gameSettingInfos.Count; i++)
            {
                if (gameSettingInfos[i].KeyId == (int)GameSettingEnum.GuaJiSell)
                {
                    ifHaveGuaJiSell = true;
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
        }

        //开始挂机
        public static void OpenGuaJi(this UISettingGuaJiComponent self ) {

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

                //关闭设置界面
                UI uisetting = UIHelper.GetUI(self.ZoneScene(), UIType.UISetting);
                //uisetting.Remove(); .GetComponent<UISettingComponent>().RE();
            }
            else {
                //当前已经在挂机
                FloatTipManager.Instance.ShowFloatTip("当前正在挂机,请确保周围是怪物刷新点!");
            }
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
        }

        public static void ClickSell(this UISettingGuaJiComponent self) {

            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            string acttype = self.ZoneScene().GetComponent<UserInfoComponent>().GetGameSettingValue(GameSettingEnum.GuaJiSell);
            if (acttype == "0")
            {
                acttype = "1";
            }
            else {
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

        public static void UpdateGuaJiSell(this UISettingGuaJiComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            string acttype = self.ZoneScene().GetComponent<UserInfoComponent>().GetGameSettingValue(GameSettingEnum.GuaJiSell);
            self.Image_Click_0.SetActive(acttype != "0");
        }

    }
}
