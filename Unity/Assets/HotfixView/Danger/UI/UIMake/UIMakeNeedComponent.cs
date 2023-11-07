using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIMakeNeedComponent : Entity, IAwake<GameObject>,IDestroy
    {
        public GameObject Image_EventTrigger;
        public GameObject Image_ItemIcon;
        public GameObject Image_ItemQuality;
        public GameObject Label_ItemNum;
        public GameObject Label_ItemName;
        public GameObject GameObject;
        public int ItemId;
        
        public List<string> AssetPath = new List<string>();
    }


    public class UIMakeNeedComponentAwakeSystem : AwakeSystem<UIMakeNeedComponent, GameObject>
    {
        public override void Awake(UIMakeNeedComponent self, GameObject gameObject)
        {
            self.GameObject = gameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Image_EventTrigger = rc.Get<GameObject>("Image_EventTrigger");
            self.Image_ItemIcon = rc.Get<GameObject>("Image_ItemIcon");
            self.Image_ItemQuality = rc.Get<GameObject>("Image_ItemQuality");
            self.Label_ItemNum = rc.Get<GameObject>("Label_ItemNum");
            self.Label_ItemName = rc.Get<GameObject>("Label_ItemName");

            self.Image_EventTrigger.GetComponent<Button>().onClick.AddListener(() => { self.OnClickUIItem(); });
        }
    }
    public class UIMakeNeedComponentDestroy : DestroySystem<UIMakeNeedComponent>
    {
        public override void Destroy(UIMakeNeedComponent self)
        {
            for(int i = 0; i < self.AssetPath.Count; i++)
            {
                if (!string.IsNullOrEmpty(self.AssetPath[i]))
                {
                    ResourcesComponent.Instance.UnLoadAsset(self.AssetPath[i]); 
                }
            }
            self.AssetPath = null;
        }
    }
    public static class UIMakeNeedComponentSystem
    {
        public static void OnClickUIItem(this UIMakeNeedComponent self)
        {
            //弹出Tips
            EventType.ShowItemTips.Instance.ZoneScene = self.DomainScene();
            EventType.ShowItemTips.Instance.bagInfo =new BagInfo() { ItemID = self.ItemId };
            EventType.ShowItemTips.Instance.itemOperateEnum = ItemOperateEnum.None;
            EventType.ShowItemTips.Instance.inputPoint = Input.mousePosition;
            EventType.ShowItemTips.Instance.Occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            Game.EventSystem.PublishClass(EventType.ShowItemTips.Instance);
        }

        public static void UpdateItem(this UIMakeNeedComponent self, int itemId, int needNumber)
        {
            self.ItemId = itemId;
            ItemConfig itemconfig = ItemConfigCategory.Instance.Get(itemId);
            string path =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemIcon, itemconfig.Icon);
            Sprite sp = ResourcesComponent.Instance.LoadAsset<Sprite>(path);
            if (!self.AssetPath.Contains(path))
            {
                self.AssetPath.Add(path);
            }
            self.Image_ItemIcon.GetComponent<Image>().sprite = sp;
            string qualityiconStr = FunctionUI.GetInstance().ItemQualiytoPath(itemconfig.ItemQuality);
            string path2 =ABPathHelper.GetAtlasPath_2(ABAtlasTypes.ItemQualityIcon, qualityiconStr);
            Sprite sp2 = ResourcesComponent.Instance.LoadAsset<Sprite>(path2);
            if (!self.AssetPath.Contains(path2))
            {
                self.AssetPath.Add(path2);
            }
            self.Image_ItemQuality.GetComponent<Image>().sprite = sp2;

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            long haveNumber = bagComponent.GetItemNumber(itemId);
            self.Label_ItemNum.GetComponent<Text>().text = string.Format("{0}/{1}", haveNumber, needNumber);

            if (haveNumber >= needNumber)
            {
                self.Label_ItemNum.GetComponent<Text>().color = new Color(130f / 255f, 255f / 255f, 0f / 255f);
            }
            else {
                self.Label_ItemNum.GetComponent<Text>().color = new Color(255f / 255f, 255f / 255f, 255f / 255f);
            }

            self.Label_ItemName.GetComponent<Text>().text = itemconfig.ItemName;
            self.Label_ItemName.GetComponent<Text>().color = FunctionUI.GetInstance().QualityReturnColor(itemconfig.ItemQuality);

        }
    }
}
