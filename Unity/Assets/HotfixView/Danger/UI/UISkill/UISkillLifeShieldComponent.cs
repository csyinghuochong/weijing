using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISkillLifeShieldComponent : Entity, IAwake
    {
        public GameObject Text_ShieldDesc;
        public GameObject Text_Progess;
        public GameObject Text_ShieldName;
        public GameObject ImageProgess;

        public GameObject[] Shield_List = new GameObject[6];

        public GameObject BuildingList;

        public GameObject[] UICommonItem_List = new GameObject[5];

        public GameObject Btn_ZhuRu;

        public int ShieldType;
    }

    [ObjectSystem]
    public class UISkillLifeShieldComponentAwake : AwakeSystem<UISkillLifeShieldComponent>
    {
        public override void Awake(UISkillLifeShieldComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.Text_ShieldDesc = rc.Get<GameObject>("Text_ShieldDesc");
            self.Text_Progess = rc.Get<GameObject>("Text_Progess");
            self.Text_ShieldName = rc.Get<GameObject>("Text_ShieldName");
            self.ImageProgess = rc.Get<GameObject>("ImageProgess");

            for (int i = 0; i < 6; i++)
            {
                self.Shield_List[i] = rc.Get<GameObject>($"Shield_{i+1}");
            }

            self.BuildingList = rc.Get<GameObject>("BuildingList");

            for (int i = 0; i < 5; i++)
            { 
                self.UICommonItem_List[i] = rc.Get<GameObject>($"UICommonItem_{i+1}");
            }

            self.Btn_ZhuRu = rc.Get<GameObject>("Btn_ZhuRu");

        }
    }

    public static class UISkillLifeShieldComponentSystem
    {

        public static async ETTask OnBtn_ZhuRu(this UISkillLifeShieldComponent self)
        {
            List<long> costs = self.GetConstItems ();
            C2M_LifeShieldCostRequest  request = new C2M_LifeShieldCostRequest() { OperateType = self.ShieldType, OperateBagID = costs };
            M2C_LifeShieldCostResponse response = (M2C_LifeShieldCostResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            self.ZoneScene().GetComponent<TitleComponent>().ShieldList = response.ShieldList;   
        }



        public static List<long> GetConstItems(this UISkillLifeShieldComponent self)
        {
            return new List<long>();
        }

    }
}
