using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIWearWeaponComponent : Entity, IAwake, IDestroy
    {

        public GameObject SkillItemShow;
        public GameObject TextTip3;
        public GameObject RawImage;
        public GameObject ButtonClose;
        public GameObject ImgClose;
        public UIModelDynamicComponent UIModelShowComponent;
        public RenderTexture RenderTexture;
    }

    public class UIWearWeaponComponentAwake : AwakeSystem<UIWearWeaponComponent>
    {
        public override void Awake(UIWearWeaponComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.TextTip3 = rc.Get<GameObject>("TextTip3");
            self.RawImage = rc.Get<GameObject>("RawImage");
            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            self.ImgClose = rc.Get<GameObject>("ImgClose");

            self.SkillItemShow = rc.Get<GameObject>("SkillItemShow");

            ButtonHelp.AddListenerEx(self.ButtonClose, self.OnButtonClose);
            ButtonHelp.AddListenerEx(self.ImgClose, self.OnButtonClose);
            self.OnInitUI();
        }
    }

    public class UIWearWeaponComponentDestroy : DestroySystem<UIWearWeaponComponent>
    {
        public override void Destroy(UIWearWeaponComponent self)
        {
            if (self.UIModelShowComponent!=null)
            {
                self.UIModelShowComponent.ReleaseRenderTexture();
            }
            if (self.RenderTexture != null)
            {
                self.RenderTexture.Release();
                GameObject.Destroy(self.RenderTexture);
                self.RenderTexture = null;
                //RenderTexture.ReleaseTemporary(self.RenderTexture);
            }
        }
    }

    public static class UIWearWeaponComponentSystem
    {

        public static void OnButtonClose(this UIWearWeaponComponent self)
        {
            UIHelper.Remove( self.ZoneScene(), UIType.UIWearWeapon );
        }

        public static void ShowSkillList(this UIWearWeaponComponent self,  int itemid)
        {
            var path_1 = ABPathHelper.GetUGUIPath("Main/Common/UICommonSkillItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path_1);
            int occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            OccupationConfig occupationConfig = OccupationConfigCategory.Instance.Get(occ);
            int[] initskilllist = occupationConfig.InitSkillID;

            int weapontype = ItemConfigCategory.Instance.Get(itemid).EquipType;

            for (int i = 0; i < initskilllist.Length; i++)
            {
                GameObject skillItem = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(skillItem, self.SkillItemShow);
                skillItem.SetActive(true);
                skillItem.transform.localScale = Vector3.one * 1f;

                int showskillid = SkillHelp.GetWeaponSkill(initskilllist[i], weapontype, null);

                UICommonSkillItemComponent ui_item = self.AddChild<UICommonSkillItemComponent, GameObject>(skillItem);
                ui_item.OnUpdateUI(showskillid);
                ui_item.TextSkillName.SetActive(true);
                ui_item.TextSkillName.GetComponent<Text>().color = new Color(192 / 255f, 255 / 255f, 23 / 255f);
            }
        }

        public static void OnInitUI(this UIWearWeaponComponent self)
        {
            Unit unit = UnitHelper.GetMyUnitFromZoneScene( self.ZoneScene() );
            int weaponid = unit.GetComponent<NumericComponent>().GetAsInt( NumericType.Now_Weapon );
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(weaponid);

            string tip = string.Empty;

            tip = itemConfig.GetItemName();
            self.TextTip3.GetComponent<Text>().text = string.Format(GameSettingLanguge.LoadLocalization("恭喜你获得了{0}!\n它可以让你的技能产生变化!\n不同类型的武器对应不同的技能哦!"), tip);

            self.ShowSkillList(weaponid);   

            if (!ComHelp.IfNull(itemConfig.ItemModelID))
            {
                self.RenderTexture = null;
                self.RenderTexture = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
                self.RenderTexture.Create();
                self.RawImage.GetComponent<RawImage>().texture = self.RenderTexture;

                //显示模型
                var path = ABPathHelper.GetUGUIPath("Common/UIModelDynamic");
                GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
                GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
                self.UIModelShowComponent = self.AddChild<UIModelDynamicComponent, GameObject>(gameObject);
                self.UIModelShowComponent.OnInitUI(self.RawImage, self.RenderTexture);
                self.UIModelShowComponent.ShowModel("ItemModel/" + itemConfig.ItemModelID).Coroutine();

                gameObject.transform.Find("Camera").localPosition = new Vector3(5.4f, 40.2f, 214.8f);
                gameObject.transform.Find("Camera").GetComponent<Camera>().fieldOfView = 25;
                gameObject.transform.localPosition = new Vector2(10000, 0);
                gameObject.transform.Find("Model").localRotation = Quaternion.Euler(0f, -45f, 0f);
            }

        }
    }
}
