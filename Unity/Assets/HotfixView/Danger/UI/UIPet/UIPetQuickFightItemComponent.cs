using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetQuickFightItemComponent : Entity, IAwake<GameObject>, IDestroy
    {
        public GameObject Icon;
        public GameObject Button;
        public GameObject Text;
        public Text TexTCd;


        public Action<long> ClickHandler;
        public long PetId;
    }


    public class UIPetQuickFightItemComponentDestroy : DestroySystem<UIPetQuickFightItemComponent>
    {
        public override void Destroy(UIPetQuickFightItemComponent self)
        {        
        }
    }


    public class UIPetQuickFightItemComponentAwake : AwakeSystem<UIPetQuickFightItemComponent, GameObject>
    {
        public override void Awake(UIPetQuickFightItemComponent self, GameObject gameObject)
        {
            self.Icon = gameObject.transform.Find("Icon").gameObject;
            self.Button = gameObject.transform.Find("Button").gameObject;
            self.Text = gameObject.transform.Find("Button/Text").gameObject;
            self.TexTCd = gameObject.transform.Find("TexTCd").gameObject.GetComponent<Text>();
            self.TexTCd.text = string.Empty;
            ButtonHelp.AddListenerEx(  self.Button, () => { self.ClickHandler(self.PetId);   } );

            self.Icon.GetComponent<Button>().onClick.AddListener(() => { self.ClickHandler(self.PetId); });
        }
    }


    public static class UIPetQuickFightItemComponentSystem
    {

        public static void OnTimer(this UIPetQuickFightItemComponent self, long cdTime)
        {
            if (cdTime <= 0)
            {
                self.TexTCd.text = string.Empty;    
            }
            else
            {
                int leftsecond = Mathf.FloorToInt(cdTime * 0.001f);
                self.TexTCd.text = $"{leftsecond}秒";
            }
        }

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