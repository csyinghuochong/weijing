using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UISeasonJingHeItemComponent: Entity, IAwake<GameObject>
    {
        public GameObject GameObject;
        public GameObject IconImg;
        public GameObject LockImg;
        public GameObject NameText;
        public GameObject OutLineImg;
        public GameObject ClickBtn;

        public int JingHeId;
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

            List<BagInfo> equiplist = self.ZoneScene().GetComponent<BagComponent>().GetEquipList();

            self.IconImg.SetActive(false);
            for (int i = 0; i < equiplist.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(equiplist[i].ItemID);
                if (itemConfig.ItemType == ItemTypeEnum.Equipment && itemConfig.EquipType == 201 && itemConfig.ItemSubType == 2000 + self.JingHeId)
                {
                    self.IconImg.SetActive(true);
                    self.IconImg.GetComponent<Image>().sprite = ABAtlasHelp.GetIconSprite(ABAtlasTypes.ItemIcon, itemConfig.Icon);
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