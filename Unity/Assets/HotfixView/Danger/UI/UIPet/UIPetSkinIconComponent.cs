using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIPetSkinIconComponent : Entity, IAwake<GameObject>
    {
        public GameObject TextSkinName;
        public GameObject Image_ItemButton;
        public GameObject Image_XuanZhong;
        public GameObject Image_ItemIcon;
        public GameObject Image_ItemQuality;
        public Action<int> ClickHandler;
        public int SkinId;
    }

    [ObjectSystem]
    public class UIPetSkinIconComponentAwakeSystem : AwakeSystem<UIPetSkinIconComponent, GameObject>
    {
        public override void Awake(UIPetSkinIconComponent self, GameObject go)
        {
            ReferenceCollector rc = go.GetComponent<ReferenceCollector>();
            self.TextSkinName = rc.Get<GameObject>("TextSkinName");
            self.Image_ItemButton = rc.Get<GameObject>("Image_ItemButton");
            self.Image_XuanZhong = rc.Get<GameObject>("Image_XuanZhong");
            self.Image_ItemIcon = rc.Get<GameObject>("Image_ItemIcon");
            self.Image_ItemQuality = rc.Get<GameObject>("Image_ItemQuality");

            self.Image_XuanZhong.SetActive(false);
            self.Image_ItemButton.GetComponent<Button>().onClick.AddListener( self.OnImage_ItemButton);
        }
    }

    public static class UIPetSkinIconComponentSystem
    {

        public static void SetClickHandler(this UIPetSkinIconComponent self, Action<int> action)
        {
            self.ClickHandler = action;
        }

        public static void OnImage_ItemButton(this UIPetSkinIconComponent self)
        {
            self.ClickHandler( self.SkinId );
        }

        public static void OnSelected(this UIPetSkinIconComponent self, int skinId)
        {
            self.Image_XuanZhong.SetActive( self.SkinId == skinId );
        }

        public static void OnUpdateUI(this UIPetSkinIconComponent self, int skinId, bool unlocked)
        {
            self.SkinId = skinId;
            PetSkinConfig skillConfig = PetSkinConfigCategory.Instance.Get(skinId);
            Sprite sp = ABAtlasHelp.GetIconSprite(ABAtlasTypes.PetHeadIcon,  skillConfig.IconID.ToString());
            self.Image_ItemIcon.GetComponent<Image>().sprite = sp;
            self.TextSkinName.GetComponent<Text>().text = skillConfig.Name;
            UICommonHelper.SetImageGray(self.Image_ItemIcon, !unlocked);
            UICommonHelper.SetImageGray(self.Image_ItemQuality, !unlocked);
        }
    }
}
