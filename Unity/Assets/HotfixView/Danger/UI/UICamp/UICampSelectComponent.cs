using System;
using UnityEngine;

namespace ET
{
    public class UICampSelectComponent : Entity,IAwake
    {
        public GameObject Button_ZhenYing_2;
        public GameObject Button_ZhenYing_1;
    }


    public class UICampSelectComponentAwakeSystem : AwakeSystem<UICampSelectComponent>
    {
        public override void Awake(UICampSelectComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Button_ZhenYing_1 = rc.Get<GameObject>("Button_ZhenYing_1");
            self.Button_ZhenYing_2 = rc.Get<GameObject>("Button_ZhenYing_2");

            ButtonHelp.AddListenerEx(self.Button_ZhenYing_1, () => { self.OnButton_ZhenYing(1); } );
            ButtonHelp.AddListenerEx(self.Button_ZhenYing_2, () => { self.OnButton_ZhenYing(2);  });
        }
    }

    public static class UICampSelectComponentSystem
    {
        public static void OnButton_ZhenYing(this UICampSelectComponent self, int campId)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            int curCamp = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.CampId);
            if (curCamp == campId)
            {
                return;
            }

            if (curCamp == 0)
            {
                self.RequestCampSelect(campId).Coroutine(); 
                return;
            }
            PopupTipHelp.OpenPopupTip(self.ZoneScene(), "更改阵营", "是否花费200钻石更改阵营?", () =>
            {
                self.RequestCampSelect(campId).Coroutine();
            }, null).Coroutine();
        }

        public static async ETTask RequestCampSelect(this UICampSelectComponent self, int campId)
        {
            C2M_CampRankSelectRequest request = new C2M_CampRankSelectRequest() { CampId = campId };
            M2C_CampRankSelectResponse response = (M2C_CampRankSelectResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
        }
    }
}
