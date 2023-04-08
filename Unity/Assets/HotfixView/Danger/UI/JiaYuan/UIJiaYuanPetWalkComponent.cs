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

        public List<UIJiaYuanPetWalkItemComponent> uIJiaYuanPets = new List<UIJiaYuanPetWalkItemComponent>();
    }

    public class UIJiaYuanPetWalkComponentAwake : AwakeSystem<UIJiaYuanPetWalkComponent>
    {
        public override void Awake(UIJiaYuanPetWalkComponent self)
        {
            self.uIJiaYuanPets.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.BuildingList1 = rc.Get<GameObject>("BuildingList1");

            self.OnUpdateUI();
        }
    }

    public static class UIJiaYuanPetWalkComponentSystem
    {

        public static void OnUpdateUI(this UIJiaYuanPetWalkComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("JiaYuan/UIJiaYuanPetWalkItem");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();  

            List<RolePetInfo> rolePetInfos = petComponent.RolePetInfos;
            for (int i = 0; i < rolePetInfos.Count; i++)
            {
                UIJiaYuanPetWalkItemComponent ui_1 = null;
                if ( i < self.uIJiaYuanPets.Count)
                {
                    ui_1 = self.uIJiaYuanPets[i];
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.BuildingList1);
                    ui_1 = self.AddChild<UIJiaYuanPetWalkItemComponent, GameObject>(go);
                    self.uIJiaYuanPets.Add(ui_1);
                }
            }
        }
    }
}
