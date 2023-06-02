using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIPetCangKuComponent : Entity, IAwake, IDestroy
    {
        public GameObject BuildingList;
        public GameObject PetListNode;
        public GameObject ButtonClose;

        public List<UIPetCangKuDefendComponent> UIDefendList = new List<UIPetCangKuDefendComponent>();
        public List<UIPetCangKuItemComponent> UICangKuItemList = new List<UIPetCangKuItemComponent>();
    }

    public class UIPetCangKuComponentAwake : AwakeSystem<UIPetCangKuComponent>
    {
        public override void Awake(UIPetCangKuComponent self)
        {
            self.UIDefendList.Clear();
            self.UICangKuItemList.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.BuildingList = rc.Get<GameObject>("BuildingList");
            self.PetListNode = rc.Get<GameObject>("PetListNode");
            self.ButtonClose = rc.Get<GameObject>("ButtonClose");

            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIPetCangKu); });

            self.OnInitUI();
        }
    }

    public static class UIPetCangKuComponentSystem
    {
        public static void OnInitUI(this UIPetCangKuComponent self)
        {
            bool gm = GMHelp.GmAccount.Contains(self.ZoneScene().GetComponent<AccountInfoComponent>().Account);
            if (!gm)
            {
                return;
            }
            self.UpdatePetCangKuDefend().Coroutine();
            self.UpdatePetCangKuItemList().Coroutine();
        }

        public static async ETTask UpdatePetCangKuDefend(this UIPetCangKuComponent self)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Pet/UIPetCangKuDefend");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            int openindex = 0;
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            for (int i = 0; i < 6; i++)
            {
                UIPetCangKuDefendComponent ui_1 = null;
                if (i < self.UIDefendList.Count)
                {
                    ui_1 = self.UIDefendList[i];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.BuildingList);
                    ui_1 = self.AddChild<UIPetCangKuDefendComponent, GameObject>(go);
                    ui_1.SetAction( self.OnPetPutCangku );
                    self.UIDefendList.Add(ui_1);
                }
                if (petComponent.PetCangKuOpen.Contains(i))
                {
                    openindex++;
                }

                ui_1.OnUpdateUI(userInfoComponent.UserInfo.JiaYuanLv, i + 1, openindex);
            }
        }

        public static void OnPetPutCangku(this UIPetCangKuComponent self)
        {
            self.UpdatePetCangKuDefend().Coroutine();
            self.UpdatePetCangKuItemList().Coroutine();
        }

        public static async ETTask UpdatePetCangKuItemList(this UIPetCangKuComponent self)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/Pet/UIPetCangKuItem");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }

            int shounumber = 0;
            PetComponent petComponent = self.ZoneScene().GetComponent<PetComponent>();
            for (int i = 0; i < petComponent.RolePetInfos.Count; i++)
            {
                RolePetInfo rolePetInfo = petComponent.RolePetInfos[i];
                if (rolePetInfo.PetStatus != 0)
                {
                    continue;
                }

                UIPetCangKuItemComponent ui_1 = null;
                if (shounumber < self.UICangKuItemList.Count)
                {
                    ui_1 = self.UICangKuItemList[shounumber];
                    ui_1.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.PetListNode);
                    ui_1 = self.AddChild<UIPetCangKuItemComponent, GameObject>(go);
                    ui_1.SetAction( self.OnPetPutCangku);
                    self.UICangKuItemList.Add(ui_1);
                }
                shounumber++;
                ui_1.OnUpdateUI(rolePetInfo);
            }
            for (int i = shounumber; i < self.UICangKuItemList.Count; i++)
            {
                self.UICangKuItemList[i].GameObject.SetActive(false);
            }
        }
    }
}
