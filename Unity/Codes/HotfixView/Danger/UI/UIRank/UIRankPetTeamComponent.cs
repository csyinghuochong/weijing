using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIRankPetTeamComponent : Entity, IAwake,IDestroy
    {
        public GameObject ButtonName;
        public GameObject CloseBtn;
        public GameObject InputField;
        public GameObject Button_OK;

        public GameObject[] PetShowList;

        public int SelectIndex = -1;
        public List<long> PetIdList = new List<long>() { 0, 0, 0 };
        public PetComponent PetComponent;
    }

    [ObjectSystem]
    public class UIRankPetTeamComponentAwakeSystem : AwakeSystem<UIRankPetTeamComponent>
    {
        public override void Awake(UIRankPetTeamComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonName = rc.Get<GameObject>("SubViewNode");
            self.CloseBtn = rc.Get<GameObject>("CloseBtn");
            self.CloseBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseBtn(); });
            self.InputField = rc.Get<GameObject>("InputField");
            self.Button_OK = rc.Get<GameObject>("Button_OK");
            self.Button_OK.GetComponent<Button>().onClick.AddListener(() => { self.OnButton_OK().Coroutine(); });

            self.PetIdList = new List<long>() { 0, 0, 0 };
            self.PetShowList = new GameObject[3];
            self.PetShowList[2] = rc.Get<GameObject>("PetShow_3");
            self.PetShowList[1] = rc.Get<GameObject>("PetShow_2");
            self.PetShowList[0] = rc.Get<GameObject>("PetShow_1");

            self.PetShowList[0].transform.Find("ImageAdd").GetComponent<Button>().onClick.AddListener(() => { self.OnClickAddButton(0).Coroutine(); });
            self.PetShowList[1].transform.Find("ImageAdd").GetComponent<Button>().onClick.AddListener(() => { self.OnClickAddButton(1).Coroutine(); });
            self.PetShowList[2].transform.Find("ImageAdd").GetComponent<Button>().onClick.AddListener(() => { self.OnClickAddButton(2).Coroutine(); });

            self.PetComponent = self.ZoneScene().GetComponent<PetComponent>();
            self.OnInitData();

            DataUpdateComponent.Instance.AddListener(DataType.PetItemSelect, self);
        }
    }

    [ObjectSystem]
    public class UIRankPetTeamComponentDestroySystem : DestroySystem<UIRankPetTeamComponent>
    {
        public override void Destroy(UIRankPetTeamComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.PetItemSelect, self);
        }
    }


    public static class UIRankPetTeamComponentSystem
    {

        public static void OnInitData(this UIRankPetTeamComponent self)
        {
            self.PetIdList = self.PetComponent.TeamPetList;
            for (int i = 0;i < self.PetIdList.Count; i++)
            {
                RolePetInfo rolePetInfo = self.PetComponent.GetPetInfoByID(self.PetIdList[i]);
                self.UpdatePetInfo(rolePetInfo, self.PetShowList[i]);
            }
        }

        public static void PetItemSelect(this UIRankPetTeamComponent self, string dataParams)
        {
            string[] paramsList = dataParams.Split('@');
            if (paramsList[0] != PetOperationType.RankPet_Team.ToString())
            {
                Log.Error("PetItemSelect_Error");
                return;
            }
            long petId = long.Parse(paramsList[1]);
            self.PetIdList[self.SelectIndex] = petId;
           
            RolePetInfo rolePetInfo = self.ZoneScene().GetComponent<PetComponent>().GetPetInfoByID(petId);
            self.UpdatePetInfo(rolePetInfo, self.PetShowList[ self.SelectIndex ] );
        }

        public static void UpdatePetInfo(this UIRankPetTeamComponent self, RolePetInfo rolePetInfo, GameObject gameObject)
        {
            if (rolePetInfo == null)
                return;
            int configId = rolePetInfo.ConfigId;
            PetConfig petConfig = PetConfigCategory.Instance.Get(configId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petConfig.HeadIcon);
            gameObject.transform.Find("ImageIcon").GetComponent<Image>().sprite = sp;
            gameObject.transform.Find("TextName").GetComponent<Text>().text = petConfig.PetName;
            gameObject.transform.Find("TextLevel").GetComponent<Text>().text = "等级:" + petConfig.PetLv;
        }

        public static List<long> GetSelectedPet(this UIRankPetTeamComponent self)
        {
            return self.PetIdList;
        }

        public static async ETTask OnClickAddButton(this UIRankPetTeamComponent self,int index)
        {
            self.SelectIndex = index;
            UI ui = await UIHelper.Create(self.DomainScene(), UIType.UIPetSelect);
            ui.GetComponent<UIPetSelectComponent>().OnSetType(PetOperationType.RankPet_Team);
        }

        public static void OnCloseBtn(this UIRankPetTeamComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIRankPetTeam).Coroutine();
        }

        public static async ETTask OnButton_OK(this UIRankPetTeamComponent self)
        {
            if (self.PetIdList.Contains(0))
            {
                FloatTipManager.Instance.ShowFloatTip("请选择宠物！");
                return;
            }

            C2M_RankPetTeamRequest c2M_RolePetXiLian = new C2M_RankPetTeamRequest() { PetIds = self.PetIdList };
            M2C_RankPetTeamResponse m2C_RolePetXiLian = (M2C_RankPetTeamResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetXiLian);

            self.ZoneScene().GetComponent<PetComponent>().TeamPetList = self.PetIdList;

            UIHelper.Remove( self.DomainScene(), UIType.UIRankPetTeam ).Coroutine();
        }
    }

}
