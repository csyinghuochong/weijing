using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    [Timer(TimerType.PetQuickFightTimer)]
    public class PetQuickFightTimer : ATimer<UIPetQuickFightComponent>
    {
        public override void Run(UIPetQuickFightComponent self)
        {
            try
            {
                self.OnTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UIPetQuickFightComponent : Entity, IAwake, IDestroy
    {
        public GameObject ImageButton;
        public GameObject UIPetQuickFightItem;
        public GameObject BuildingList;

        public Dictionary<long, UIPetQuickFightItemComponent> PetList = new Dictionary<long, UIPetQuickFightItemComponent>();

        public long Timer;
    }
    


    public class UIPetQuickFightComponentDestroy : DestroySystem<UIPetQuickFightComponent>
    {
        public override void Destroy(UIPetQuickFightComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
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
            self.Timer = TimerComponent.Instance.NewRepeatedTimer( 1000, TimerType.PetQuickFightTimer, self);

            self.OnInitUI();
        }
    }

    public static class UIPetQuickFightComponentSystem
    {

        public static void OnTimer(this UIPetQuickFightComponent self)
        {
            long curTime = TimeHelper.ClientNow();
            Dictionary<long, long> PetFightTime = self.ZoneScene().GetComponent<BattleMessageComponent>().PetFightCD;

            foreach (var item in self.PetList)
            {
                long petid = item.Value.PetId;
                long cdTime = 0;
                PetFightTime.TryGetValue(petid, out cdTime);
                long leftTime = cdTime - curTime;

                item.Value.OnTimer(leftTime);
            }
        }

        public static  void OnClickHandler(this UIPetQuickFightComponent self, long petid)
        {
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            RolePetInfo rolePetInfo = petComponent.GetPetInfoByID(petid);
            Dictionary<long, long> PetFightTime = self.ZoneScene().GetComponent<BattleMessageComponent>().PetFightCD;
            long huishouid = 0;
            //出战
            if (rolePetInfo.PetStatus == 0)
            {
                long cdTime = 0;
                PetFightTime.TryGetValue(petid, out cdTime);

                if (TimeHelper.ClientNow() - cdTime < 180 * TimeHelper.Second)
                {
                    FloatTipManager.Instance.ShowFloatTip("出战冷却中！");
                    return;
                }

                huishouid = petComponent.GetFightPetId();
            }

            //收回
            if (rolePetInfo.PetStatus == 1)
            {
                huishouid = petid;
            }
            if (PetFightTime.ContainsKey(huishouid))
            {
                PetFightTime[huishouid] = TimeHelper.ClientNow() + 180 * TimeHelper.Second;
            }
            else
            {
                PetFightTime.Add(huishouid, TimeHelper.ClientNow() + 180 * TimeHelper.Second);
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

            Log.ILog.Debug($"OnUpdateUI: 出战   {fightid}");

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