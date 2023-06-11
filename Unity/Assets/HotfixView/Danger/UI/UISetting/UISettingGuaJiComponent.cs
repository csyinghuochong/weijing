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

    }

    public class UISettingGuaJiComponentAwake : AwakeSystem<UISettingGuaJiComponent>
    {
        public override void Awake(UISettingGuaJiComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Btn_StartGuajI = rc.Get<GameObject>("Btn_StartGuajI");
            self.Btn_StopGuaJi = rc.Get<GameObject>("Btn_StopGuaJi");

            //给按钮添加监听事件
            self.Btn_StartGuajI.GetComponent<Button>().onClick.AddListener(()=> { self.OpenGuaJi(); } );
            self.Btn_StopGuaJi.GetComponent<Button>().onClick.AddListener(() => { self.StopGuaJi(); } );
        }
    }


    public static class UISettingGuaJiComponentSystem {

        //开始挂机
        public static void OpenGuaJi(this UISettingGuaJiComponent self ) {

            //判断是否有体力,没体力不能挂机,减少服务器开销
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (unit.GetComponent<UserInfoComponent>().UserInfo.PiLao <= 0)
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

    }
}
