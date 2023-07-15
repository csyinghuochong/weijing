using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIPetQuickFightItemComponent : Entity, IAwake<GameObject>
    {
        public GameObject Icon;
        public GameObject Button;
        public GameObject Text;

        public Action<long> ClickHandler;
        public long PetId;
    }

    public class UIPetQuickFightItemComponentAwake : AwakeSystem<UIPetQuickFightItemComponent, GameObject>
    {
        public override void Awake(UIPetQuickFightItemComponent self, GameObject gameObject)
        {
            self.Icon = gameObject.transform.Find("Icon").gameObject;
            self.Button = gameObject.transform.Find("Button").gameObject;
            self.Text = gameObject.transform.Find("Button/Text").gameObject;

            ButtonHelp.AddListenerEx(  self.Button, () => { self.ClickHandler(self.PetId);   } );
        }
    }


    public static class UIPetQuickFightItemComponentSystem
    {

        public static void OnUpdateUI(this UIPetQuickFightItemComponent self, long fightid)
        {
            self.Text.GetComponent<Text>().text = fightid == self.PetId ? "休息" : "出战";
        }

        public static void OnInitUI2(this UIPetQuickFightItemComponent self, RolePetInfo rolePetInfo, Action<long> handler)
        {
            self.PetId = rolePetInfo.Id;
            self.ClickHandler = handler;

            PetConfig petConfig = PetConfigCategory.Instance.Get(rolePetInfo.ConfigId);
            PetSkinConfig petSkinConfig = PetSkinConfigCategory.Instance.Get(rolePetInfo.SkinId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon, petSkinConfig.IconID.ToString());
            self.Icon.GetComponent<Image>().sprite = sp;
        }
    }
}