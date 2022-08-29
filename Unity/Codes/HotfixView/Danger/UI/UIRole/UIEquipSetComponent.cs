using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;


namespace ET
{
    public class UIEquipSetComponent : Entity, IAwake, IAwake<int>
    {
        public GameObject RawImage;
        public UIModelShowComponent UIModelShowComponent;
        public List<UIEquipSetItemComponent> EquipList = new List<UIEquipSetItemComponent>();
        public int Index;
    }

    [ObjectSystem]
    public class UIEquipSetComponentAwakeSystem : AwakeSystem<UIEquipSetComponent, int>
    {
        public override void Awake(UIEquipSetComponent self, int index)
        {
            self.EquipList.Clear();

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            GameObject gameObject = self.GetParent<UI>().GameObject;
            for (int i = 1; i <= 13; i++)
            {
                GameObject go = gameObject.transform.Find("Equip_" + i).gameObject;
                UIEquipSetItemComponent uiitem = self.AddChild<UIEquipSetItemComponent, GameObject>(go);
                self.EquipList.Add(uiitem);
            }
            if (!GlobalHelp.IsBanHaoMode)
            {
                gameObject.transform.Find("Equip_6").gameObject.SetActive(true);
                gameObject.transform.Find("Equip_7").gameObject.SetActive(true);
            }

            self.RawImage = gameObject.transform.Find("EquipSetHide/RawImage").gameObject;
            self.RawImage.SetActive(false);
            self.UIModelShowComponent = null;
            self.Index = index;
        }
    }

    public static class UIEquipSetComponentSystem
    {
        public static async ETTask InitModelShowView(this UIEquipSetComponent self, int index)
        {
            //模型展示界面
            long instance = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Common/UIModelShow" + (index+1).ToString());
            GameObject bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(gameObject, self.RawImage);
            gameObject.transform.localPosition = new Vector3(index * 1000, 0, 0);
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 70f, 150f);

            UI ui = self.AddChild<UI, string, GameObject>( "UIModelShow", gameObject);
            self.UIModelShowComponent = ui.AddComponent<UIModelShowComponent, GameObject>(self.RawImage);

            await TimerComponent.Instance.WaitAsync(200);
            if (instance != self.InstanceId)
            {
                return;
            }
            self.RawImage.SetActive(true);
        }

        public static async ETTask PlayShowIdelAnimate(this UIEquipSetComponent self, BagInfo bagInfo)
        {
            if (self.UIModelShowComponent == null)
            {
               await self.InitModelShowView(self.Index);
            }
            self.UIModelShowComponent.PlayShowIdelAnimate();
        }

        public static async ETTask ShowPlayerModel(this UIEquipSetComponent self, BagInfo bagInfo, int occ)
        {
            if (self.UIModelShowComponent == null)
            {
                await self.InitModelShowView(self.Index);
            }
            self.UIModelShowComponent.ShowPlayerModel(bagInfo, occ).Coroutine();
        }

        public static async ETTask ChangeWeapon(this UIEquipSetComponent self, BagInfo bagInfo, int occ)
        {
            if (self.UIModelShowComponent == null)
            {
                await self.InitModelShowView(self.Index);
            }
            self.UIModelShowComponent.ChangeWeapon(bagInfo, occ);
        }

        public static void ResetEquipShow(this UIEquipSetComponent self)
        {
            for (int i = 0; i < self.EquipList.Count; i++)
            {
                self.EquipList[i].InitUI(i);
            }
        }

        public static void EquipSetHide(this UIEquipSetComponent self, bool value)
        {
            self.GetParent<UI>().GameObject.transform.Find("EquipSetHide").gameObject.SetActive(value);
        }

        public static void PlayerLv(this UIEquipSetComponent self, int lv)
        {
            self.GetParent<UI>().GameObject.transform.Find("EquipSetHide/RoseNameLv/Lab_RoseLv").GetComponent<Text>().text = lv.ToString();
        }

        public static void PlayerName(this UIEquipSetComponent self, string playerName)
        {
            self.GetParent<UI>().GameObject.transform.Find("EquipSetHide/RoseNameLv/Lab_RoseName").GetComponent<Text>().text = playerName;
        }

        public static void UpdateBagUI(this UIEquipSetComponent self, List<BagInfo> equiplist, int occ, ItemOperateEnum itemOperateEnum)
        {
            self.ResetEquipShow();

            int shipingIndex = 0;
            for (int i = 0; i < equiplist.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(equiplist[i].ItemID);
                int pos =  ItemHelper.ReturnEquipSpaceNum(itemConfig.ItemSubType) - 1;

                if (pos == 4)
                {
                    self.EquipList[pos + shipingIndex].UpdateData(equiplist[i], occ, itemOperateEnum);
                    shipingIndex++;
                }
                else
                {
                    self.EquipList[pos].UpdateData(equiplist[i], occ, itemOperateEnum);
                }
            }
        }
    }

}
