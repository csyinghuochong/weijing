using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

namespace ET
{


    public class UIPetMiningChallengeTeamComponent : Entity, IAwake<GameObject>,IDestroy
    {

        public int TeamId = 0;   //0 1 2
        public GameObject GameObject;

        public GameObject TextTip11;
        public GameObject TextTip12;
        public GameObject TextTip13;

        public PetComponent PetComponent;

        public Image[] PetIcon_List = new Image[5];

        public GameObject ButtonSelect;
        public GameObject ImageSelect;

        public Action<int> SelectHandler;

        public bool Defend;
        public int PetNumber = 0;
        
        public List<string> AssetPath = new List<string>();
    }

    public class UIPetMiningChallengeTeamComponentAwake : AwakeSystem<UIPetMiningChallengeTeamComponent, GameObject>
    {
        public override void Awake(UIPetMiningChallengeTeamComponent self, GameObject gameObject)
        {

            self.GameObject = gameObject;

            self.TextTip11 = gameObject.transform.Find("TextTip11").gameObject;
            self.TextTip12 = gameObject.transform.Find("TextTip12").gameObject;
            self.TextTip13 = gameObject.transform.Find("TextTip13").gameObject;

            for (int i = 0; i < self.PetIcon_List.Length; i++)
            {
                GameObject iconitem = gameObject.transform.Find($"PetIcon_{i}").gameObject;
                self.PetIcon_List[i] = iconitem.GetComponent<Image>();
            }

            self.ButtonSelect = gameObject.transform.Find("ButtonSelect").gameObject;
            self.ButtonSelect.GetComponent<Button>().onClick.AddListener(self.OnButtonSelect); 

            self.ImageSelect = gameObject.transform.Find("ImageSelect").gameObject;

            self.PetComponent = self.ZoneScene().GetComponent<PetComponent>();
        }
    }
    public class UIPetMiningChallengeTeamComponentDestroy : DestroySystem<UIPetMiningChallengeTeamComponent>
    {
        public override void Destroy(UIPetMiningChallengeTeamComponent self)
        {
            for(int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]); 
                }
            }
            self.AssetPath = null;
        }
    }
    public static class UIPetMiningChallengeTeamComponentSystem
    {

        public static void OnButtonSelect(this UIPetMiningChallengeTeamComponent self)
        {
            if (self.PetNumber == 0)
            {
                FloatTipManager.Instance.ShowFloatTip("出战队伍不能为空！");
                return;
            }
            if (self.Defend)
            {
                FloatTipManager.Instance.ShowFloatTip("抢矿后原占有矿会变成无人看守的矿！");
            }
            self.SelectHandler.Invoke(self.TeamId);
        }

        public static void OnUpdateUI(this UIPetMiningChallengeTeamComponent self, bool defend)
        {
            self.Defend = defend;

            int playerLv = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Lv;
            int openLv = ConfigHelper.PetMiningTeamOpenLevel[self.TeamId];
            self.TextTip12.GetComponent<Text>().text = $"{openLv}级开启";

            bool isopen = playerLv >= openLv;

            for (int i = 0; i < 5; i++ )
            {
                if (!isopen)
                {
                    self.PetIcon_List[i].gameObject.SetActive(false);
                    continue;
                }

                long petid = self.PetComponent.PetMingList[i + self.TeamId * 5];
                RolePetInfo  rolePetInfo = self.PetComponent.GetPetInfoByID(petid);
                if (rolePetInfo == null)
                {
                    self.PetIcon_List[i].gameObject.SetActive(false);
                }
                else
                {
                    self.PetIcon_List[i].gameObject.SetActive(true);
                    PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
                    string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
                    Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                    if (!self.AssetPath.Contains(path))
                    {
                        self.AssetPath.Add(path);
                    }
                    self.PetIcon_List[i].sprite = sp;
                    self.PetNumber++;
                }
            }

            self.TextTip13.SetActive(defend);
            self.ButtonSelect.SetActive(true);
            self.ImageSelect.SetActive(false);

            self.TextTip12.gameObject.SetActive( !isopen);
        }

       
        public static void OnUpdateSelect(this UIPetMiningChallengeTeamComponent self, int teamid)
        { 
            
        }
    }
}