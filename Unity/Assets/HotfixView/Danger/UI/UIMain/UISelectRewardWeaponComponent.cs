using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UISelectRewardWeaponComponent : Entity, IAwake, IDestroy
    {

        public GameObject Weapon_1;
        public GameObject Weapon_2;
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

        public int Key;
        public int Type; // 0等级领取 1击败领取
    }

    public class UISelectRewardWeaponComponentAwake : AwakeSystem<UISelectRewardWeaponComponent>
    {
        public override void Awake(UISelectRewardWeaponComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ButtonClose = rc.Get<GameObject>("ButtonClose");
            ButtonHelp.AddListenerEx(self.ButtonClose, self.OnButtonClose);

            self.Weapon_1 = rc.Get<GameObject>("Weapon_1");
            self.Weapon_2 = rc.Get<GameObject>("Weapon_2");

            Transform Weapon_1 = rc.Get<GameObject>("Weapon_1").transform;
            Transform Weapon_2 = rc.Get<GameObject>("Weapon_2").transform;

            self.RawImage_1 = Weapon_1.Find("RawImage").gameObject;
            self.RenderTexture_1 = new RenderTexture(256, 256, 16, RenderTextureFormat.ARGB32);
            self.RenderTexture_1.Create();
            self.RawImage_1.GetComponent<RawImage>().texture = self.RenderTexture_1;
            self.UIItemComponent_1 = self.AddChild<UIItemComponent, GameObject>(Weapon_1.Find("UICommonItem").gameObject);
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

    public class UISelectRewardWeaponComponentDestroy : DestroySystem<UISelectRewardWeaponComponent>
    {
        public override void Destroy(UISelectRewardWeaponComponent self)
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

    public static class UISelectRewardWeaponComponentSystem
    {

        public static void OnButtonClose(this UISelectRewardWeaponComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UISelectRewardWeapon);
        }

        public static async ETTask OnButtonSelect(this UISelectRewardWeaponComponent self, int index)
        {
            if (self.Type !=0 || self.Key!= 8)
            {
                return;
            }

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();

            if (bagComponent.GetBagLeftCell() < 1)
            {
                FloatTipManager.Instance.ShowFloatTip(GameSettingLanguge.LoadLocalization("背包空间不足！"));
                return;
            }
            long instanceid = self.InstanceId;

            C2M_LeavlRewardRequest request = new C2M_LeavlRewardRequest() { LvKey = self.Key, Index = index };
            M2C_LeavlRewardResponse response =
                    await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request) as M2C_LeavlRewardResponse;
            if (instanceid != self.InstanceId)
            {
                return;
            }
            if (self.IsDisposed)
            {
                return;
            }
            UIHelper.GetUI(self.ZoneScene(), UIType.UIMain).GetComponent<UIMainComponent>().UpdateLvReward();
            self.OnButtonClose();

            await ETTask.CompletedTask;
        }

        public static void UpdateInfo(this UISelectRewardWeaponComponent self, int key, int type)
        {
            self.Key = key;
            self.Type = type;

            string[] occItems;
            switch (type)
            {
                case 0:
                    
                    occItems = ConfigHelper.LevelRewardItem[key].Split('&');
                    break;
                case 1:
    
                    occItems = ConfigHelper.KillMonsterReward[key].Split('&');
                    break;
                default:
                    return;
            }

            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            string[] items;
            if (occItems.Length > 1)
            {
                items = occItems[userInfoComponent.UserInfo.Occ - 1].Split('@');
            }
            else
            {
                items = occItems[0].Split('@');
            }

            //14100021;1

            string[] item_1 = items[0].Split(';');
            string[] item_2 = null;

            if (items.Length > 1)
            {
                item_2 = items[1].Split(';');
            }
            else
            {
                item_2 = item_1;
                self.Weapon_1.transform.localPosition = new Vector3(400f,0f,0f);
                self.Weapon_2.SetActive(false);
            }
 
            int weaponid_1 = int.Parse(item_1[0]);
            int weaponid_2 = int.Parse(item_2[0]);
            self.UIModelShowComponent_1 = self.ShowWeaponModel(weaponid_1, self.RawImage_1, self.RenderTexture_1);
            self.UIModelShowComponent_2 = self.ShowWeaponModel(weaponid_2, self.RawImage_2, self.RenderTexture_2);

            self.UIItemComponent_1.UpdateItem(new BagInfo() { ItemID = weaponid_1 }, ItemOperateEnum.None);
            self.UIItemComponent_2.UpdateItem(new BagInfo() { ItemID = weaponid_2 }, ItemOperateEnum.None);

            self.UIItemComponent_1.Label_ItemName.GetComponent<Text>().color = new Color(192 / 255f, 255 / 255f, 23 / 255f);
            self.UIItemComponent_2.Label_ItemName.GetComponent<Text>().color = new Color(192 / 255f, 255 / 255f, 23 / 255f);

            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonSkillItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            OccupationConfig occupationConfig = OccupationConfigCategory.Instance.Get(userInfoComponent.UserInfo.Occ);
            int[] initskilllist = occupationConfig.InitSkillID;

            self.ShowSkillList(bundleGameObject, self.SkillItemShow_1, weaponid_1, initskilllist);
            self.ShowSkillList(bundleGameObject, self.SkillItemShow_2, weaponid_2, initskilllist);
        }

        public static void ShowSkillList(this UISelectRewardWeaponComponent self, GameObject bundleGameObject, GameObject skillshownode, int itemid, int[] initskilllist)
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
                ui_item.TextSkillName.GetComponent<Text>().color = new Color(192 / 255f, 255 / 255f, 23 / 255f);
            }
        }

        public static UIModelDynamicComponent ShowWeaponModel(this UISelectRewardWeaponComponent self, int weaponid, GameObject rawImage, RenderTexture renderTexture)
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
