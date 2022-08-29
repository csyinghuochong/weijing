using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRankPetItemComponent : Entity, IAwake
    {
        public GameObject Lab_Owner;
        public GameObject Lab_TeamName;
        public GameObject Lab_PaiMing;
        public GameObject[] ImageIconList;
        public GameObject ImageIcon2;
        public GameObject ImageIcon1;
        public GameObject Btn_PVP;

        public RankPetInfo RankPetInfo;
    }

    [ObjectSystem]
    public class UIRankPetItemComponentAwakeSystem : AwakeSystem<UIRankPetItemComponent>
    {
        public override void Awake(UIRankPetItemComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            
            self.Lab_Owner = rc.Get<GameObject>("Lab_Owner");
            self.Lab_TeamName = rc.Get<GameObject>("Lab_TeamName");
            self.Lab_PaiMing = rc.Get<GameObject>("Lab_PaiMing");

            self.ImageIconList = new GameObject[3];
            self.ImageIconList[2] = rc.Get<GameObject>("ImageIcon3");
            self.ImageIconList[1] = rc.Get<GameObject>("ImageIcon2");
            self.ImageIconList[0] = rc.Get<GameObject>("ImageIcon1");

            self.Btn_PVP = rc.Get<GameObject>("Btn_PVP");
            ButtonHelp.AddListenerEx(self.Btn_PVP, () => { self.OnClickBtn_PVP(); });
        }
    }

    public static class UIRankPetItemComponentSystem
    {

        public static void OnInitUI(this UIRankPetItemComponent self, RankPetInfo rankPetInfo)
        {
            self.RankPetInfo = rankPetInfo;
            self.Lab_TeamName.GetComponent<Text>().text = rankPetInfo.TeamName;

            for (int i = 0; i < rankPetInfo.PetConfigId.Count; i++ )
            {
                PetConfig petConfig = PetConfigCategory.Instance.Get(rankPetInfo.PetConfigId[i]);
                Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
                self.ImageIconList[i].GetComponent<Image>().sprite = sp;

                self.Lab_PaiMing.GetComponent<Text>().text = rankPetInfo.RankId.ToString();
            }
        }

        public static void OnClickBtn_PVP(this UIRankPetItemComponent self)
        {
            if (self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.PiLao <= 0)
            {
                FloatTipManager.Instance.ShowFloatTip("体力不足!");
                return;
            }
            if (self.ZoneScene().GetComponent<PetComponent>().TeamPetList.Contains(0))
            {
                FloatTipManager.Instance.ShowFloatTip("上阵宠物不足三只!");
                return;
            }

            EnterFubenHelp.RequestTransfer(self.DomainScene(), (int)SceneTypeEnum.PetTianTi, 0).Coroutine();
            UIHelper.Remove( self.DomainScene(), UIType.UIRank).Coroutine();
        }

    }
}
