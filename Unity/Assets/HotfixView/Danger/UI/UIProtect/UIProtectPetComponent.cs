using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIProtectPetComponent : Entity, IAwake
    {

        public GameObject PetIcon;
        public GameObject Text_Name;
        public GameObject PetListNode;
        public GameObject UnlockButton;
        public GameObject XiLianButton;

        public PetComponent PetComponent;
        public List<UIPetListItemComponent> PetUIList = new List<UIPetListItemComponent>();

        public long PetInfoId;
    }

    public class UIProtectPetComponentAwake : AwakeSystem<UIProtectPetComponent>
    {
        public override void Awake(UIProtectPetComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.PetListNode    = rc.Get<GameObject>("EquipListNode");

            self.UnlockButton   = rc.Get<GameObject>("UnlockButton");
            ButtonHelp.AddListenerEx(self.UnlockButton, () => { self.RequestProtect(false).Coroutine();   });

            self.XiLianButton   = rc.Get<GameObject>("XiLianButton");
            ButtonHelp.AddListenerEx(self.XiLianButton, () => { self.RequestProtect(true).Coroutine(); });

            self.PetIcon         = rc.Get<GameObject>("PetIcon");
            self.Text_Name      = rc.Get<GameObject>("Text_Name");

            self.PetComponent = self.ZoneScene().GetComponent<PetComponent>();
            self.GetParent<UI>().OnUpdateUI = self.OnUpdateUI;
        }
    }

    public static class UIProtectPetComponentSystem
    {

        public static void OnUpdateUI(this UIProtectPetComponent self)
        {
            self.PetInfoId = 0;
            self.OnInitPetList();
            if (self.PetUIList.Count > 0)
            {
                self.PetUIList[0].OnClickPetItem();
            }
        }

        public static void OnClickPetHandler(this UIProtectPetComponent self, long petId)
        {
            RolePetInfo rolePetInfo = self.PetComponent.GetPetInfoByID(petId);
            if (rolePetInfo == null)
            {
                return;
            }
            for (int i = 0; i < self.PetUIList.Count; i++)
            {
                self.PetUIList[i].OnSelectUI(rolePetInfo);
            }
            self.PetInfoId = petId;
            self.XiLianButton.SetActive(!rolePetInfo.IsProtect);
            self.UnlockButton.SetActive(rolePetInfo.IsProtect);
            self.Text_Name.GetComponent<Text>().text = rolePetInfo.PetName;
            PetSkinConfig petSkinConfig = PetSkinConfigCategory.Instance.Get(rolePetInfo.SkinId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petSkinConfig.IconID.ToString());
            self.PetIcon.GetComponent<Image>().sprite = sp;
        }

        public static async ETTask RequestProtect(this UIProtectPetComponent self, bool isprotect)
        {
            C2M_RolePetProtect c2M_RolePetProtect = new C2M_RolePetProtect() { PetInfoId = self.PetInfoId, IsProtect = isprotect };
            M2C_RolePetProtect m2C_RolePetProtect = (M2C_RolePetProtect)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_RolePetProtect);

            if (self.IsDisposed)
            {
                return;
            }
            self.PetComponent.OnPetProtect( self.PetInfoId, isprotect );
            self.OnInitPetList();
            self.OnClickPetHandler(self.PetInfoId);
        }

        public static  void OnInitPetList(this UIProtectPetComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Pet/UIPetListItem");
            var bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            List<RolePetInfo> rolePetInfos = self.PetComponent.RolePetInfos;

            List<RolePetInfo> showList = new List<RolePetInfo>();
            showList.AddRange(rolePetInfos);
            for (int i = 0; i < showList.Count; i++)
            {
                UIPetListItemComponent ui_pet = null;
                if (i < self.PetUIList.Count)
                {
                    ui_pet = self.PetUIList[i];
                    ui_pet.GameObject.SetActive(true);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(bundleGameObject);
                    UICommonHelper.SetParent(go, self.PetListNode);
                    ui_pet = self.AddChild<UIPetListItemComponent, GameObject>(go);
                    ui_pet.SetClickHandler((long petId) => { self.OnClickPetHandler(petId); });
                    self.PetUIList.Add(ui_pet);
                }
                ui_pet.OnInitData(showList[i], 0);
            }

            for (int i = showList.Count; i < self.PetUIList.Count; i++)
            {
                self.PetUIList[i].GameObject.SetActive(false);
            }
        }

    }
}
