using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

namespace ET
{ 

    public class UIPetMiningTeamItemComponent : Entity, IAwake<GameObject>
    {

        public int TeamId = 0;   //0 1 2
        public GameObject GameObject;

        public GameObject TextTip11;
        public GameObject TextTip12;

        public PetComponent PetComponent;

        public GameObject[] PetIcon_di_List = new GameObject[5];    
        public UIPetFormationItemComponent[] FormationItemComponents = new UIPetFormationItemComponent[5];
    }

    public class UIPetMiningTeamItemComponentAwake : AwakeSystem<UIPetMiningTeamItemComponent, GameObject>
    {
        public override void Awake(UIPetMiningTeamItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;

            self.TextTip11 = gameObject.transform.Find("TextTip11").gameObject;
            self.TextTip12 = gameObject.transform.Find("TextTip12").gameObject;

            for (int i = 0; i < self.FormationItemComponents.Length; i++)
            {
                self.PetIcon_di_List[i] = gameObject.transform.Find($"PetIcon_di_{i}").gameObject;
                self.FormationItemComponents[i] = null;
            }

            self.PetComponent = self.ZoneScene().GetComponent<PetComponent>();
        }
    }

    public static class UIPetMiningTeamItemComponentSystem
    {



        public static void OnInitUI(this UIPetMiningTeamItemComponent self,  int position)
        { 
            self.TeamId = position;
            self.TextTip11.GetComponent<Text>().text = $"{position}队";
        }

        public static void UpdatePetTeam(this UIPetMiningTeamItemComponent self, List<long> petlist)
        {
            var path = ABPathHelper.GetUGUIPath("Main/PetSet/UIPetFormationItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);

            for (int i = 0; i < self.FormationItemComponents.Length; i++)
            {
                long petId = petlist[i + self.TeamId * 5];
                RolePetInfo rolePetInfo = self.PetComponent.GetPetInfoByID(petId);
              
                if (rolePetInfo != null && self.FormationItemComponents[i] == null)
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, transform.GetChild(i).gameObject);
                    uIRolePetItemComponent = self.AddChild<UIPetFormationItemComponent, GameObject>(go);
                }
                if (rolePetInfo == null && self.FormationItemComponents[i] != null)
                {
                    self.FormationItemComponents[i].GameObject.SetActive(false);    
                }

                if (rolePetInfo != null)
                {
                    PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
                    Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
                    self.ImageList[i].GetComponent<Image>().sprite = sp;
                }
            }

        }
    }

}