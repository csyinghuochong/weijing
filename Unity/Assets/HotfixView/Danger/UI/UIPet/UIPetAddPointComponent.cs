using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIPetAddPointComponent : Entity, IAwake<GameObject>
    {

        public GameObject Lab_ShengYuNum;
        public GameObject Btn_Confirm;

        public GameObject AddProperty_LiLiang;
        public GameObject AddProperty_ZhiLi;
        public GameObject AddProperty_TiZhi;
        public GameObject AddProperty_NaiLi;

        public RolePetInfo RolePetInfo;

        public GameObject GameObject;
        public bool IsHoldDown;

        public List<int> PointList = new List<int>();
        public List<int> PointInit = new List<int>();
        public int PointRemain = 0;
    }


    public class UIPetAddPointComponentAwakeSystem : AwakeSystem<UIPetAddPointComponent, GameObject>
    {
        public override void Awake(UIPetAddPointComponent self, GameObject gameObject)
        {
            self.PointList.Clear(); 
            self.PointInit.Clear(); 

            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Lab_ShengYuNum = rc.Get<GameObject>("Lab_ShengYuNum");

            self.Btn_Confirm = rc.Get<GameObject>("Btn_Confirm");
            self.Btn_Confirm.GetComponent<Button>().onClick.AddListener(() => { self.OnBtn_Confirm().Coroutine();  } );

            self.AddProperty_LiLiang = rc.Get<GameObject>("AddProperty_LiLiang");
            self.AddProperty_ZhiLi = rc.Get<GameObject>("AddProperty_ZhiLi");
            self.AddProperty_TiZhi = rc.Get<GameObject>("AddProperty_TiZhi");
            self.AddProperty_NaiLi = rc.Get<GameObject>("AddProperty_NaiLi");

            GameObject LiLiang_Btn_Add = self.AddProperty_LiLiang.transform.Find("Btn_Add").gameObject;
            GameObject LiLiang_Btn_Cost = self.AddProperty_LiLiang.transform.Find("Btn_Cost").gameObject;
            ButtonHelp.AddEventTriggers(LiLiang_Btn_Add, (PointerEventData pdata) => { self.PointerDown_Btn_AddNum(0).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(LiLiang_Btn_Cost, (PointerEventData pdata) => { self.PointerDown_Btn_CostNum(0).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(LiLiang_Btn_Add, (PointerEventData pdata) => { self.PointerUp_Btn_AddNum(); }, EventTriggerType.PointerUp);
            ButtonHelp.AddEventTriggers(LiLiang_Btn_Cost, (PointerEventData pdata) => { self.PointerUp_Btn_AddNum(); }, EventTriggerType.PointerUp);

            GameObject ZhiLi_Btn_Add = self.AddProperty_ZhiLi.transform.Find("Btn_Add").gameObject;
            GameObject ZhiLi_Btn_Cost = self.AddProperty_ZhiLi.transform.Find("Btn_Cost").gameObject;
            ButtonHelp.AddEventTriggers(ZhiLi_Btn_Add, (PointerEventData pdata) => { self.PointerDown_Btn_AddNum(1).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(ZhiLi_Btn_Cost, (PointerEventData pdata) => { self.PointerDown_Btn_CostNum(1).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(ZhiLi_Btn_Add, (PointerEventData pdata) => { self.PointerUp_Btn_AddNum(); }, EventTriggerType.PointerUp);
            ButtonHelp.AddEventTriggers(ZhiLi_Btn_Cost, (PointerEventData pdata) => { self.PointerUp_Btn_AddNum(); }, EventTriggerType.PointerUp);

            GameObject TiZhi_Btn_Add = self.AddProperty_TiZhi.transform.Find("Btn_Add").gameObject;
            GameObject TiZhi_Btn_Cost = self.AddProperty_TiZhi.transform.Find("Btn_Cost").gameObject;
            ButtonHelp.AddEventTriggers(TiZhi_Btn_Add, (PointerEventData pdata) => { self.PointerDown_Btn_AddNum(2).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(TiZhi_Btn_Cost, (PointerEventData pdata) => { self.PointerDown_Btn_CostNum(2).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(TiZhi_Btn_Add, (PointerEventData pdata) => { self.PointerUp_Btn_AddNum(); }, EventTriggerType.PointerUp);
            ButtonHelp.AddEventTriggers(TiZhi_Btn_Cost, (PointerEventData pdata) => { self.PointerUp_Btn_AddNum(); }, EventTriggerType.PointerUp);

            GameObject NaiLi_Btn_Add = self.AddProperty_NaiLi.transform.Find("Btn_Add").gameObject;
            GameObject NaiLi_Btn_Cost = self.AddProperty_NaiLi.transform.Find("Btn_Cost").gameObject;
            ButtonHelp.AddEventTriggers(NaiLi_Btn_Add, (PointerEventData pdata) => { self.PointerDown_Btn_AddNum(3).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(NaiLi_Btn_Cost, (PointerEventData pdata) => { self.PointerDown_Btn_CostNum(3).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(NaiLi_Btn_Add, (PointerEventData pdata) => { self.PointerUp_Btn_AddNum(); }, EventTriggerType.PointerUp);
            ButtonHelp.AddEventTriggers(NaiLi_Btn_Cost, (PointerEventData pdata) => { self.PointerUp_Btn_AddNum(); }, EventTriggerType.PointerUp);

            self.IsHoldDown = false;
        }
    }

    public static class UIPetAddPointComponentSystem
    {

        public static async ETTask PointerDown_Btn_AddNum(this UIPetAddPointComponent self, int addType)
        {
            self.IsHoldDown = true;
            while (self.IsHoldDown)
            {
                self.Btn_AddProprety(addType, 1);
                await TimerComponent.Instance.WaitAsync(200);
            }
        }

        public static async ETTask PointerDown_Btn_CostNum(this UIPetAddPointComponent self, int addType)
        {
            self.IsHoldDown = true;
            while (self.IsHoldDown)
            {
                self.Btn_AddProprety(addType, -1);
                await TimerComponent.Instance.WaitFrameAsync();
            }
        }

        public static void PointerUp_Btn_AddNum(this UIPetAddPointComponent self)
        {
            self.IsHoldDown = false;
        }

        public static void OnBtn_Close(this UIPetAddPointComponent self)
        {
            self.GameObject.SetActive(false);
        }

        public static void  Btn_AddProprety(this UIPetAddPointComponent self, int addType, int value)
        {
            if (self.PointRemain <= 0 && value > 0)
            {
                return;
            }
            int typeValue = self.PointList[addType];
            if (typeValue <= self.PointInit[addType] && value < 0)
            {
                return;
            }
            self.PointRemain += (value * -1);
            self.PointList[addType] += value;

            self.OnUpdateUI();
        }

        public static async ETTask OnBtn_Confirm(this UIPetAddPointComponent self)
        {
            C2M_RolePetJiadian c2M_RolePetJiadian = new C2M_RolePetJiadian() { };
            c2M_RolePetJiadian.PetInfoId = self.RolePetInfo.Id;
            c2M_RolePetJiadian.AddPropretyValue = self.PointList;
            M2C_RolePetJiadian m2C_RolePetJiadian = (M2C_RolePetJiadian)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetJiadian);
            self.ZoneScene().GetComponent<PetComponent>().OnRolePetUpdate(m2C_RolePetJiadian.RolePetInfo);
            self.OnInitUI(m2C_RolePetJiadian.RolePetInfo);
            UI uipet = UIHelper.GetUI(self.ZoneScene(), UIType.UIPet);
            uipet.GetComponent<UIPetComponent>().UIPageView.UISubViewList[(int)PetPageEnum.PetList].GetComponent<UIPetListComponent>().OnUpdatePetPoint(self.RolePetInfo);
        }


        public static void OnInitUI(this UIPetAddPointComponent self, RolePetInfo rolePetInfo)
        {
            self.RolePetInfo = rolePetInfo;
           
            self.PointList.Clear();
            self.PointInit.Clear();
            string[] propertyList = self.RolePetInfo.AddPropretyValue.Split('_');
            self.PointList.Add(int.Parse(propertyList[0]));
            self.PointList.Add(int.Parse(propertyList[1]));
            self.PointList.Add(int.Parse(propertyList[2]));
            self.PointList.Add(int.Parse(propertyList[3]));
            self.PointInit.Clear();
            self.PointInit.AddRange(self.PointList);
            self.PointRemain = self.RolePetInfo.AddPropretyNum;

            self.OnUpdateUI();
        }

        public static void OnUpdateUI(this UIPetAddPointComponent self)
        {
            self.Lab_ShengYuNum.GetComponent<Text>().text = self.PointRemain.ToString();
            string[] propertyList = self.RolePetInfo.AddPropretyValue.Split('_');
            self.OnUpdateItem(self.AddProperty_LiLiang, self.PointList[0], self.RolePetInfo.PetLv);
            self.OnUpdateItem(self.AddProperty_ZhiLi,   self.PointList[1], self.RolePetInfo.PetLv);
            self.OnUpdateItem(self.AddProperty_TiZhi,   self.PointList[2], self.RolePetInfo.PetLv);
            self.OnUpdateItem(self.AddProperty_NaiLi,   self.PointList[3], self.RolePetInfo.PetLv);
        }

        public static void OnUpdateItem(this UIPetAddPointComponent self, GameObject gameObject, int number, int level)
        {
            gameObject.transform.Find("Lab_Value").GetComponent<Text>().text = ( number+ level ).ToString();
        }
    }

}
