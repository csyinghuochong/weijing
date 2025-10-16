using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UISelectWeaponComponent : Entity, IAwake, IDestroy
    {
        public GameObject ButtonClose;

        public GameObject RawImage_1;
        public RenderTexture RenderTexture_1;
        public UIModelDynamicComponent UIModelShowComponent_1;
        public UIItemComponent UIItemComponent_1;
        public GameObject SkillItemShow_1;

        public GameObject RawImage_2;
        public RenderTexture RenderTexture_2;
        public UIModelDynamicComponent UIModelShowComponent_2;
        public UIItemComponent UIItemComponent_2;
        public GameObject SkillItemShow_2;

        public long UseBagInfoId;
    }

    public class UISelectWeaponComponentAwake : AwakeSystem<UISelectWeaponComponent>
    {
        public override void Awake(UISelectWeaponComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            ButtonHelp.AddListenerEx(self.ButtonClose, self.OnButtonClose);

            Transform Weapon_1 = rc.Get<GameObject>("Weapon_1").transform;
            Transform Weapon_2 = rc.Get<GameObject>("Weapon_2").transform;

            self.RawImage_1 = Weapon_1.Find("RawImage").gameObject;
            self.RenderTexture_1 = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
            self.RenderTexture_1.Create();
            self.RawImage_1.GetComponent<RawImage>().texture = self.RenderTexture_1;
            self.UIItemComponent_1 =  self.AddChild<UIItemComponent, GameObject>(Weapon_1.Find("UICommonItem").gameObject);
            self.SkillItemShow_1 = Weapon_1.Find("SkillItemShow").gameObject;
            ButtonHelp.AddListenerEx(Weapon_1.Find("ButtonSelect").gameObject, () => { self.OnButtonSelect(0).Coroutine(); });

            self.RawImage_2 = Weapon_2.Find("RawImage").gameObject;
            self.RenderTexture_2 = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
            self.RenderTexture_2.Create();
            self.RawImage_2.GetComponent<RawImage>().texture = self.RenderTexture_2;
            self.UIItemComponent_2 = self.AddChild<UIItemComponent, GameObject>(Weapon_2.Find("UICommonItem").gameObject);
            self.SkillItemShow_2 = Weapon_2.Find("SkillItemShow").gameObject;
            ButtonHelp.AddListenerEx(Weapon_2.Find("ButtonSelect").gameObject, () => { self.OnButtonSelect(1).Coroutine(); });
        }
    }

    public class UISelectWeaponComponentDestroy : DestroySystem<UISelectWeaponComponent>
    {
        public override void Destroy(UISelectWeaponComponent self)
        {
            if (self.UIModelShowComponent_1 != null)
            {
                self.UIModelShowComponent_1.ReleaseRenderTexture();
            }
            if (self.RenderTexture_1 != null)
            {
                self.RenderTexture_1.Release();
                GameObject.Destroy(self.RenderTexture_1);
                self.RenderTexture_1 = null;
                //RenderTexture.ReleaseTemporary(self.RenderTexture);
            }

            if (self.UIModelShowComponent_2 != null)
            {
                self.UIModelShowComponent_2.ReleaseRenderTexture();
            }
            if (self.RenderTexture_2 != null)
            {
                self.RenderTexture_2.Release();
                GameObject.Destroy(self.RenderTexture_2);
                self.RenderTexture_2 = null;
                //RenderTexture.ReleaseTemporary(self.RenderTexture);
            }

        }
    }

    public static class UISelectWeaponComponentSystem
    {

        public static void OnButtonClose(this UISelectWeaponComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UISelectWeapon);
        }

        public static async ETTask OnButtonSelect(this UISelectWeaponComponent self, int index)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            BagInfo bagInfo = bagComponent.GetBagInfo(self.UseBagInfoId);
            if (bagInfo == null)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("道具不足"));
                return;
            }
            if (bagComponent.GetBagLeftCell() < 1)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("背包空间不足！"));
                return;
            }
            int errorcode = await bagComponent.SendUseItem(bagInfo, index.ToString());
            if (self.IsDisposed)
            {
                return;
            }
            if (errorcode == ErrorCode.ERR_Success)
            {
                self.OnButtonClose();
            }

            await ETTask.CompletedTask;
        }

        public static void OnInitUI(this UISelectWeaponComponent self,int occ,  int itemid, long baginfoid)
        {
            self.UseBagInfoId = baginfoid;
            List<int> weaponids = ItemHelper.GetSealWeaponList(occ,itemid);

            self.UIModelShowComponent_1 = self.ShowWeaponModel(weaponids[0], self.RawImage_1, self.RenderTexture_1);
            self.UIModelShowComponent_2 = self.ShowWeaponModel(weaponids[1], self.RawImage_2, self.RenderTexture_2);

            self.UIItemComponent_1.UpdateItem(new BagInfo() { ItemID = weaponids[0] }, ItemOperateEnum.None);
            self.UIItemComponent_2.UpdateItem(new BagInfo() { ItemID = weaponids[1] }, ItemOperateEnum.None);

            self.UIItemComponent_1.Label_ItemName.GetComponent<Text>().color = new Color(192 / 255f, 255 / 255f, 23 / 255f);
            self.UIItemComponent_2.Label_ItemName.GetComponent<Text>().color = new Color(192 / 255f, 255 / 255f, 23 / 255f);

            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonSkillItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            OccupationConfig occupationConfig = OccupationConfigCategory.Instance.Get(occ);
            int[] initskilllist = occupationConfig.InitSkillID;
            self.ShowSkillList(bundleGameObject, self.SkillItemShow_1, weaponids[0], initskilllist);
            self.ShowSkillList(bundleGameObject, self.SkillItemShow_2, weaponids[1], initskilllist);
        }

        public static void ShowSkillList(this UISelectWeaponComponent self, GameObject bundleGameObject, GameObject skillshownode,  int itemid, int[] initskilllist)
        {
            int weapontype = ItemConfigCategory.Instance.Get(itemid).EquipType;

            for (int i = 0; i < initskilllist.Length; i++)
            {
                GameObject skillItem = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(skillItem, skillshownode);
                skillItem.SetActive(true);
                skillItem.transform.localScale = Vector3.one * 1f;

                int showskillid = SkillHelp.GetWeaponSkill(initskilllist[i], weapontype, null);

                UICommonSkillItemComponent ui_item = self.AddChild<UICommonSkillItemComponent, GameObject>(skillItem);
                ui_item.OnUpdateUI(showskillid);
                ui_item.TextSkillName.SetActive(true);
                ui_item.TextSkillName.GetComponent<Text>().color = new Color(192/255f,255/255f,23/255f);
            }
        }

        public static UIModelDynamicComponent ShowWeaponModel(this UISelectWeaponComponent self, int weaponid, GameObject rawImage, RenderTexture renderTexture)
        {
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(weaponid);

            //显示模型
            var path = ABPathHelper.GetUGUIPath("Common/UIModelDynamic");
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UIModelDynamicComponent uIModelShowComponent = self.AddChild<UIModelDynamicComponent, GameObject>(gameObject);
            uIModelShowComponent.OnInitUI(rawImage, renderTexture);
            uIModelShowComponent.ShowModel("ItemModel/" + itemConfig.ItemModelID).Coroutine();

            gameObject.transform.Find("Camera").localPosition = new Vector3(5.4f, 40.2f, 214.8f);
            gameObject.transform.Find("Camera").GetComponent<Camera>().fieldOfView = 25;
            gameObject.transform.localPosition = new Vector2(10000, 0);
            gameObject.transform.Find("Model").localRotation = Quaternion.Euler(0f, -45f, 0f);

            return uIModelShowComponent;
        }
    }
}
