using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public enum PetOperationType
    { 
        HeCheng = 1,
        XiLian = 2,
        UpStar_Main = 3,
        UpStar_FuZh = 4,
        RankPet_Team = 5,
        XianJi  = 6,
    }


    public class UIPetSelectComponent : Entity, IAwake
    {
        public PetOperationType OperationType;

        public GameObject Btn_Close;
        public GameObject PetListNode;
    }

    [ObjectSystem]
    public class UIPetSelectComponentAwakeSystem : AwakeSystem<UIPetSelectComponent>
    {
        public override void Awake(UIPetSelectComponent self)
        {

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.PetListNode = rc.Get<GameObject>("PetListNode");

            self.Btn_Close.GetComponent<Button>().onClick.AddListener(()=> { self.OnClickCoseButton(); });
        }
    }


    public static class UIPetSelectComponentSystem
    {
        public static void OnSetType(this UIPetSelectComponent self, PetOperationType bagOperationType)
        {
            self.OperationType = bagOperationType;
            self.OnInitData();
        }

        public static List<long> GetSelectedPet(this UIPetSelectComponent self)
        {
            List<long> selected = new List<long>();
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            RolePetInfo fightPetInfo = petComponent.GetFightPet();
            List<long> petTeamList = new List<long>();
            //petTeamList.AddRange(petComponent.TeamPetList);
            //petTeamList.AddRange(petComponent.PetFormations);
            if (self.OperationType == PetOperationType.HeCheng)
            {
                UI uipet = UIHelper.GetUI(self.DomainScene(), UIType.UIPet);
                selected = uipet.GetComponent<UIPetComponent>().UIPageView.UISubViewList[(int)PetPageEnum.PetHeCheng].GetComponent<UIPetHeChengComponent>().GetSelectedPet();
                selected.AddRange(petTeamList);
            }
            if (self.OperationType == PetOperationType.UpStar_FuZh)
            {
                UI uipet = UIHelper.GetUI(self.DomainScene(), UIType.UIPet);
                selected = uipet.GetComponent<UIPetComponent>().UIPageView.UISubViewList[(int)PetPageEnum.PetUpStar].GetComponent<UIPetUpStarComponent>().GetSelectedPet();
                selected.AddRange(petTeamList);
            }
            if (self.OperationType == PetOperationType.XianJi)
            {
                UI uipet = UIHelper.GetUI(self.DomainScene(), UIType.UIPet);
                long petinfoId = uipet.GetComponent<UIPetComponent>().UIPageView.UISubViewList[(int)PetPageEnum.PetList].GetComponent<UIPetListComponent>().LastSelectItem.Id;
                selected.Add(petinfoId);
            }
            if (fightPetInfo != null)
            {
                selected.Add(fightPetInfo.Id);
            }
            return selected;
        }

        public static  void OnInitData(this UIPetSelectComponent self)
        {
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            List<RolePetInfo> list = petComponent.RolePetInfos;

            var path = ABPathHelper.GetUGUIPath("Main/Pet/UIPetSelectItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            List<long> selected = self.GetSelectedPet();
            for (int i = 0; i < list.Count; i++)
            {
                if (selected.Contains(list[i].Id))
                {
                    continue;
                }

                if (self.OperationType == PetOperationType.UpStar_FuZh)
                {
                    UI uipet = UIHelper.GetUI(self.DomainScene(), UIType.UIPet);
                    UIPetUpStarComponent uIPetUpStarComponent = uipet.GetComponent<UIPetComponent>().UIPageView.UISubViewList[(int)PetPageEnum.PetUpStar].GetComponent<UIPetUpStarComponent>();
                    RolePetInfo rolePetInfo = uIPetUpStarComponent.MainPetInfo;
                    if (list[i].Star != rolePetInfo.Star)
                    {
                        continue;
                    }
                }

                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.PetListNode);

                UI uiitem = self.AddChild<UI, string, GameObject>( "UIPetXuanZeItem_" + i, go);
                UIPetSelectItemComponent uIPetHeChengXuanZeItemComponent = uiitem.AddComponent<UIPetSelectItemComponent>();
                uIPetHeChengXuanZeItemComponent.OnInitData(list[i]);
                uIPetHeChengXuanZeItemComponent.OperationType  = self.OperationType;
            }
        }

        public static void OnClickCoseButton(this UIPetSelectComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIPetSelect);
        }

    }
}
