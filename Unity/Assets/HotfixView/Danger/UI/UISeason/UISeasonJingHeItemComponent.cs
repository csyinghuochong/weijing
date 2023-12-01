using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISeasonJingHeItemComponent: Entity, IAwake<GameObject>,IDestroy
    {
        public GameObject GameObject;
        public GameObject IconImg;
        public GameObject LockImg;
        public GameObject NameText;
        public GameObject OutLineImg;
        public GameObject ClickBtn;

        public int JingHeId;
        public BagInfo BagInfo;
        public List<string> AssetPath = new List<string>();
    }

    public class UISeasonJingHeItemComponentAwakeSystem: AwakeSystem<UISeasonJingHeItemComponent, GameObject>
    {
        public override void Awake(UISeasonJingHeItemComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.IconImg = rc.Get<GameObject>("IconImg");
            self.LockImg = rc.Get<GameObject>("LockImg");
            self.NameText = rc.Get<GameObject>("NameText");
            self.OutLineImg = rc.Get<GameObject>("OutLineImg");
            self.ClickBtn = rc.Get<GameObject>("ClickBtn");

            self.ClickBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnClickBtn(); });
        }
    }
    public class UISeasonJingHeItemComponentDestroy: DestroySystem<UISeasonJingHeItemComponent>
    {
        public override void Destroy(UISeasonJingHeItemComponent self)
        {
            for (int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]);
                }
            }

            self.AssetPath = null;
        }
    }
    public static class UISeasonJingHeItemComponentSystem
    {
        public static void OnClickBtn(this UISeasonJingHeItemComponent self)
        {
            self.GetParent<UISeasonJingHeComponent>().UpdateInfo(self.JingHeId).Coroutine();
        }

        public static void OnUpdateData(this UISeasonJingHeItemComponent self)
        {
            if (self.JingHeId == 0)
            {
                return;
            }

            ///应该放入SeasonJingHe。 穿戴和卸下晶核给单独协议
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<BagInfo> equiplist = bagComponent.GetCurJingHeList(  );

            // bagComponent.SeasonJingHePlan

            self.IconImg.SetActive(false);
            for (int i = 0; i < equiplist.Count; i++)
            {
                ///equiplist[i].EquipPlan; 第几套晶核

                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(equiplist[i].ItemID);
                if (itemConfig.ItemType == ItemTypeEnum.Equipment && itemConfig.EquipType == 201 && equiplist[i].EquipIndex == self.JingHeId)
                {
                    self.BagInfo = equiplist[i];
                    self.IconImg.SetActive(true);
                    string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, itemConfig.Icon);
                    Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
                    if (!self.AssetPath.Contains(path))
                    {
                        self.AssetPath.Add(path);
                    }
                    self.IconImg.GetComponent<Image>().sprite = sp;
                    self.NameText.GetComponent<Text>().text = itemConfig.ItemName;
                    break;
                }
            }

            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            
            if (userInfoComponent.UserInfo.OpenJingHeIds.Contains(self.JingHeId))
            {
                self.LockImg.SetActive(false);
            }
            else
            {
                self.LockImg.SetActive(true);
            }
        }
    }
}