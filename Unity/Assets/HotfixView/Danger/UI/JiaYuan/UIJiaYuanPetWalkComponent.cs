using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace ET
{
    public class UIJiaYuanPetWalkComponent : Entity, IAwake, IDestroy
    {
        public GameObject BuildingList1;
        public GameObject UIJiaYuanPetWalkItem;


        public int Position;
        public List<UIJiaYuanPetWalkItemComponent> uIJiaYuanPets = new List<UIJiaYuanPetWalkItemComponent>();
    }

    public class UIJiaYuanPetWalkComponentAwake : AwakeSystem<UIJiaYuanPetWalkComponent>
    {
        public override void Awake(UIJiaYuanPetWalkComponent self)
        {
            self.uIJiaYuanPets.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.BuildingList1 = rc.Get<GameObject>("BuildingList1");
            self.UIJiaYuanPetWalkItem = rc.Get<GameObject>("UIJiaYuanPetWalkItem");

            self.UIJiaYuanPetWalkItem.SetActive(false);

            DataUpdateComponent.Instance.AddListener(DataType.PetItemSelect, self);

            self.OnUpdateUI();
        }
    }

    public class UIJiaYuanPetWalkComponentDestroy : DestroySystem<UIJiaYuanPetWalkComponent>
    {
        public override void Destroy(UIJiaYuanPetWalkComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.PetItemSelect, self);
        }
    }

    public static class UIJiaYuanPetWalkComponentSystem
    {

        public static async ETTask PetItemSelect(this UIJiaYuanPetWalkComponent self, string dataParams)
        {
            string[] paramsList = dataParams.Split('@');
            long petId = long.Parse(paramsList[1]);
            RolePetInfo rolePetInfo = self.ZoneScene().GetComponent<PetComponent>().GetPetInfoByID(petId);

    
            int lv = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
            JiaYuanComponent jiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();
            if (self.Position == 1 && lv < 10)
            {
                FloatTipManager.Instance.ShowFloatTip("等级不足！");
                return;
            }
            if (self.Position == 2 && lv < 20)
            {
                FloatTipManager.Instance.ShowFloatTip("等级不足！");
                return;
            }

            C2M_JiaYuanPetWalkRequest request = new C2M_JiaYuanPetWalkRequest() { PetStatus = 2, PetId = rolePetInfo.Id, Position = self.Position };
            M2C_JiaYuanPetWalkResponse response = (M2C_JiaYuanPetWalkResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.ZoneScene().GetComponent<JiaYuanComponent>().JiaYuanPetList_2 = response.JiaYuanPetList;

            self.OnUpdateUI();
        }

        public static void OnClickButtonAdd(this UIJiaYuanPetWalkComponent self, int position)
        {
            self.Position = position;
        }

        public static void OnClickButtonStop(this UIJiaYuanPetWalkComponent self)
        {
            self.OnUpdateUI();
        }

        public static void OnUpdateUI(this UIJiaYuanPetWalkComponent self)
        {
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            JiaYuanComponent jiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();

            for (int i = 0; i < 3; i++)
            {
                UIJiaYuanPetWalkItemComponent ui_1 = null;
                if ( i < self.uIJiaYuanPets.Count)
                {
                    ui_1 = self.uIJiaYuanPets[i];
                }
                else
                {
                    GameObject go = GameObject.Instantiate(self.UIJiaYuanPetWalkItem);
                    go.SetActive(true);
                    UICommonHelper.SetParent(go, self.BuildingList1);
                    ui_1 = self.AddChild<UIJiaYuanPetWalkItemComponent, GameObject>(go);
                    ui_1.SetClickAddHandler(self.OnClickButtonAdd);
                    ui_1.SetClickStopHandler(self.OnClickButtonStop);
                    self.uIJiaYuanPets.Add(ui_1);
                    ui_1.Position = i;
                }

                JiaYuanPet jiaYuanPet = jiaYuanComponent.GetJiaYuanPetGetPosition(i);
                if (jiaYuanPet != null && jiaYuanPet.unitId != 0)
                {
                    ui_1.OnUpdateUI(petComponent.GetPetInfoByID(jiaYuanPet.unitId), jiaYuanPet);
                }
                else
                {
                    ui_1.OnUpdateUI(null, null);
                }
            }
        }
    }
}
