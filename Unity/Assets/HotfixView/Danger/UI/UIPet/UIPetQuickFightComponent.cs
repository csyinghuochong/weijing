using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIPetQuickFightComponent : Entity, IAwake, IDestroy
    {
        public GameObject ImageButton;
        public GameObject UIPetQuickFightItem;
        public GameObject BuildingList;

        public Dictionary<long, UIPetQuickFightItemComponent> PetList = new Dictionary<long, UIPetQuickFightItemComponent>();
    }

    public class UIPetQuickFightComponentAwake : AwakeSystem<UIPetQuickFightComponent>
    {
        public override void Awake(UIPetQuickFightComponent self)
        {
            self.PetList.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIPetQuickFight );  }  );

            self.UIPetQuickFightItem = rc.Get<GameObject>("UIPetQuickFightItem");
            self.UIPetQuickFightItem.SetActive(false);

            self.BuildingList = rc.Get<GameObject>("BuildingList");

            self.OnInitUI();
        }
    }

    public static class UIPetQuickFightComponentSystem
    {

        public static void OnInitUI(this UIPetQuickFightComponent self)
        {
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();  
            List<RolePetInfo> rolePetInfos = petComponent.RolePetInfos;
            List<RolePetInfo> showList = new List<RolePetInfo>();
            for (int i = 0; i < rolePetInfos.Count; i++)
            {
                if (rolePetInfos[i].PetStatus != 3
                  && rolePetInfos[i].PetStatus != 2)
                {
                    showList.Add(rolePetInfos[i]);
                }
            }

            for (int i = 0; i < showList.Count; i++)
            {
                GameObject itemgo = GameObject.Instantiate( self.UIPetQuickFightItem );
                itemgo.SetActive(true);
                UIPetQuickFightItemComponent PetItem = self.AddChild<UIPetQuickFightItemComponent, GameObject>(itemgo);
                PetItem.OnInitUI(showList[i]);
                UICommonHelper.SetParent( itemgo , self.BuildingList);
                self.PetList.Add(showList[i].Id, PetItem);
            }
        }
    }
}