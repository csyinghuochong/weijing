using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{

    public class UIPetShouHuComponent : Entity, IAwake, IDestroy
    {
        public GameObject PetListNode;

        public GameObject ButtonSet;

        public GameObject[] shouhuInfoList = new GameObject[4];

        public List<UIPetShouHuItemComponent> ShouHuItemList = new List<UIPetShouHuItemComponent>();
    }

    public class UIPetShouHuComponentAwake : AwakeSystem<UIPetShouHuComponent>
    {
        public override void Awake(UIPetShouHuComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.PetListNode = rc.Get<GameObject>("PetListNode");
            for (int i = 0; i < self.shouhuInfoList.Length; i++)
            {
                self.shouhuInfoList[i] = rc.Get<GameObject>($"shouhuInfo{i}");
            }
            self.ButtonSet = rc.Get<GameObject>("ButtonSet");

            self.OnUpdateUI();
        }
    }

    public static class UIPetShouHuComponentSystem
    {

        public static async void OnButtonShouHuHandler(this UIPetShouHuComponent self, long petid)
        {
            C2M_PetShouHuRequest    request = new C2M_PetShouHuRequest() { PetInfoId = petid };
            M2C_PetShouHuResponse response = (M2C_PetShouHuResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);

            self.ZoneScene().GetComponent<PetComponent>().PetShouHuList = response.PetShouHuList;

            self.OnUpdateUI();
        }

        public static async ETTask UpdatePetList(this UIPetShouHuComponent self)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Pet/UIPetShouHuItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            List<RolePetInfo> rolePetInfos = petComponent.RolePetInfos;

            for (int i = 0; i < rolePetInfos.Count; i++)
            {
                UIPetShouHuItemComponent ui_pet = null;
                if (i < self.ShouHuItemList.Count)
                {
                    ui_pet = self.ShouHuItemList[i];
                    ui_pet.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.PetListNode);
                    ui_pet = self.AddChild<UIPetShouHuItemComponent, GameObject>(go);
                    ui_pet.SetButtonShouHuHandler(self.OnButtonShouHuHandler);
                    self.ShouHuItemList.Add(ui_pet);
                }

                ui_pet.OnInitUI(rolePetInfos[i]);
            }
        }

        public static void UpdateShouwHuInfo(this UIPetShouHuComponent self)
        { 
            
        }

        public static  void OnUpdateUI(this UIPetShouHuComponent self)
        {
            self.UpdatePetList().Coroutine();
            self.UpdateShouwHuInfo();
        }
    }
}
