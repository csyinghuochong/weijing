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

        public static  void OnClickHandler(this UIPetQuickFightComponent self, long petid)
        {
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            RolePetInfo rolePetInfo = petComponent.GetPetInfoByID(petid);
            Dictionary<long, long> PetFightTime = self.ZoneScene().GetComponent<BattleMessageComponent>().PetFightTime;

            //出战
            if (rolePetInfo.PetStatus == 0)
            {
                long lastTime = 0;
                PetFightTime.TryGetValue(petid, out lastTime);

                if (TimeHelper.ClientNow() - lastTime < 180 * TimeHelper.Second)
                {
                    FloatTipManager.Instance.ShowFloatTip("出战冷却中！");
                    return;
                }
            }
            //收回
            if (rolePetInfo.PetStatus == 1)
            {
                if (PetFightTime.ContainsKey(petid))
                {
                    PetFightTime[petid] = TimeHelper.ClientNow();
                }
                else
                {
                    PetFightTime.Add(petid, TimeHelper.ClientNow());
                }
            }

            self.RequestPetFight(petid).Coroutine();
        }

        public static async ETTask RequestPetFight(this UIPetQuickFightComponent self, long petid)
        {
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            RolePetInfo rolePetInfo = petComponent.GetPetInfoByID(petid);

            if (rolePetInfo.PetStatus == 2)
            {
                FloatTipManager.Instance.ShowFloatTip("宠物散步中！");
                return;
            }

            await  petComponent.RequestPetFight(petid, rolePetInfo.PetStatus == 0 ? 1 : 0);
            self.OnUpdateUI();
        }

        public static void OnUpdateUI(this UIPetQuickFightComponent self)
        {
            long fightid = self.ZoneScene().GetComponent<PetComponent>().GetFightPetId();
            foreach ( var item in self.PetList)
            {
                item.Value.OnUpdateUI(fightid);
            }
        }

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
                PetItem.OnInitUI2(showList[i],  self.OnClickHandler);
                UICommonHelper.SetParent( itemgo , self.BuildingList);
                self.PetList.Add(showList[i].Id, PetItem);
            }

            self.OnUpdateUI();
        }
    }
}