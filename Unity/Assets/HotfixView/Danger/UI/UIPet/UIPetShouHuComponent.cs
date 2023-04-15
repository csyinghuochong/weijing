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

            self.OnUpdateUI().Coroutine();
        }
    }

    public static class UIPetShouHuComponentSystem
    {
        public static async ETTask OnUpdateUI(this UIPetShouHuComponent self)
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
                    self.ShouHuItemList.Add(ui_pet);
                }
            }
        }
    }
}
