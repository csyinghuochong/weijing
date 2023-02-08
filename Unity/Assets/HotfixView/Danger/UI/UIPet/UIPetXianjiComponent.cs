using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace ET
{
    public class UIPetXianjiComponent : Entity, IAwake, IDestroy
    {
        public GameObject Btn_Close;
        public GameObject PetIconDi;
        public GameObject Button_Xianji;
        public GameObject PetIcon;

        public long PetUpId;
        public long PetXianjiId;
    }

    [ObjectSystem]
    public class UIPetXianjiComponentAwake : AwakeSystem<UIPetXianjiComponent>
    {
        public override void Awake(UIPetXianjiComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
        
            self.Btn_Close = rc.Get<GameObject>("Btn_Close");
            self.Btn_Close.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIPetXianji);  });

            self.PetIconDi = rc.Get<GameObject>("PetIconDi");
            ButtonHelp.AddListenerEx(self.PetIconDi, () => { self.OnPetIconDi().Coroutine(); });

            self.Button_Xianji = rc.Get<GameObject>("Button_Xianji");
            ButtonHelp.AddListenerEx(self.Button_Xianji, () => { self.OnButton_Xianji().Coroutine(); });

            self.PetIcon = rc.Get<GameObject>("PetIcon");

            DataUpdateComponent.Instance.AddListener(DataType.PetItemSelect, self);
        }
    }

    [ObjectSystem]
    public class UIPetXianjiComponentDestroy: DestroySystem<UIPetXianjiComponent>
    {
        public override void Destroy(UIPetXianjiComponent self)
        {
            DataUpdateComponent.Instance.RemoveListener(DataType.PetItemSelect, self);
        }
    }

    public static class UIPetXianjiComponentSystem
    {
        public static void OnInitUI(this UIPetXianjiComponent self, long petId)
        {
            self.PetUpId = petId;
        }

        public static void PetItemSelect(this UIPetXianjiComponent self, string dataParams)
        {
            string[] paramsList = dataParams.Split('@');

            self.PetXianjiId = long.Parse(paramsList[1]);
            RolePetInfo rolePetInfo = self.ZoneScene().GetComponent<PetComponent>().GetPetInfoByID(self.PetXianjiId);

            PetSkinConfig petSkinConfig = PetSkinConfigCategory.Instance.Get(rolePetInfo.SkinId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petSkinConfig.IconID.ToString());
            self.PetIcon.GetComponent<Image>().sprite = sp;
            self.PetIcon.SetActive(true);
        }

        public static async ETTask OnPetIconDi(this UIPetXianjiComponent self)
        {
            UI ui = await UIHelper.Create(self.DomainScene(), UIType.UIPetSelect);
            ui.GetComponent<UIPetSelectComponent>().OnSetType(PetOperationType.XianJi);

        }

        public static async ETTask OnButton_Xianji(this UIPetXianjiComponent self)
        {
            await ETTask.CompletedTask;

        }
    }
}