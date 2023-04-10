using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace ET
{
    public class UIJiaYuanPetWalkComponent : Entity, IAwake
    {
        public GameObject BuildingList1;
        public GameObject UIJiaYuanPetWalkItem;

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

            self.OnUpdateUI();
        }
    }

    public static class UIJiaYuanPetWalkComponentSystem
    {

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
