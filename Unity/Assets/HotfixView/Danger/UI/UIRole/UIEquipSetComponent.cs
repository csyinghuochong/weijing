using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;


namespace ET
{
    public class UIEquipSetComponent : Entity, IAwake, IAwake<GameObject, int>
    {

        public GameObject ButtonZodiac;
        public GameObject RawImage;
        public UIModelShowComponent UIModelShowComponent;
        public List<UIEquipSetItemComponent> EquipList = new List<UIEquipSetItemComponent>();
        public List<int> EquipIdList = new List<int>();
        public GameObject GameObject;
        public int Index;
        public int Position;
    }

    [ObjectSystem]
    public class UIEquipSetComponentAwakeSystem : AwakeSystem<UIEquipSetComponent, GameObject, int>
    {
        public override void Awake(UIEquipSetComponent self,GameObject gameObject, int index)
        {
            self.GameObject = gameObject;   
            self.EquipList.Clear();

            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();
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

            AccountInfoComponent accountInfoComponent = self.ZoneScene().GetComponent<AccountInfoComponent>();    
            self.ButtonZodiac = gameObject.transform.Find("ButtonZodiac").gameObject;
            self.ButtonZodiac.SetActive(GMHelp.GmAccount.Contains(accountInfoComponent.Account)) ;
            ButtonHelp.AddListenerEx(self.ButtonZodiac, () => { UIHelper.Create(self.ZoneScene(), UIType.UIRoleZodiac).Coroutine(); });

            self.RawImage = gameObject.transform.Find("EquipSetHide/RawImage").gameObject;
            self.RawImage.SetActive(false);
            self.UIModelShowComponent = null;
            self.Index = index;
            self.Position = index;
        }
    }

    public static class UIEquipSetComponentSystem
    {
        public static  void InitModelShowView(this UIEquipSetComponent self, int index)
        {
            //模型展示界面
            var path = ABPathHelper.GetUGUIPath("Common/UIModelShow" + (index+1).ToString());
            GameObject bundleGameObject =  ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            UICommonHelper.SetParent(gameObject, self.RawImage);
            gameObject.transform.localPosition = new Vector3(self.Position * 2000, 0, 0);
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 70f, 150f);

            UI ui = self.AddChild<UI, string, GameObject>( "UIModelShow", gameObject);
            self.UIModelShowComponent = ui.AddComponent<UIModelShowComponent, GameObject>(self.RawImage);
            self.RawImage.SetActive(true);
        }

        public static  void PlayShowIdelAnimate(this UIEquipSetComponent self, BagInfo bagInfo)
        {
            if (self.UIModelShowComponent == null)
            {
               self.InitModelShowView(self.Index);
            }
            self.UIModelShowComponent.PlayShowIdelAnimate();
        }

        public static void  ShowPlayerModel(this UIEquipSetComponent self, BagInfo bagInfo, int occ)
        {
            if (self.UIModelShowComponent == null)
            {
                self.InitModelShowView(self.Index);
            }
            self.UIModelShowComponent.ShowPlayerModel(bagInfo, occ);
        }

        public static  void ChangeWeapon(this UIEquipSetComponent self, BagInfo bagInfo, int occ)
        {
            if (self.UIModelShowComponent == null)
            {
                self.InitModelShowView(self.Index);
            }
            self.UIModelShowComponent.ChangeWeapon(bagInfo, occ);
        }

        public static void ResetEquipShow(this UIEquipSetComponent self)
        {
            for (int i = 0; i < self.EquipList.Count; i++)
            {
                self.EquipList[i].InitUI(FunctionUI.GetItemSubtypeByWeizhi(i));
            }
        }

        public static void EquipSetHide(this UIEquipSetComponent self, bool value)
        {
            self.GameObject.transform.Find("EquipSetHide").gameObject.SetActive(value);
        }

        public static void PlayerLv(this UIEquipSetComponent self, int lv)
        {
            self.GameObject.transform.Find("EquipSetHide/RoseNameLv/Lab_RoseLv").GetComponent<Text>().text = lv.ToString();
        }

        public static void PlayerName(this UIEquipSetComponent self, string playerName)
        {
            self.GameObject.transform.Find("EquipSetHide/RoseNameLv/Lab_RoseName").GetComponent<Text>().text = playerName;
        }

        public static void UpdateBagUI(this UIEquipSetComponent self, List<BagInfo> equiplist, int occ, ItemOperateEnum itemOperateEnum)
        {
            self.ResetEquipShow();

            int shipingIndex = 0;
            self.EquipIdList.Clear();
            for (int i = 0; i < equiplist.Count; i++)
            {
                self.EquipIdList.Add(equiplist[i].ItemID);
            }
            for (int i = 0; i < equiplist.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(equiplist[i].ItemID);

                if (itemConfig.ItemSubType < (int)ItemSubTypeEnum.Shiping)
                {
                    self.EquipList[itemConfig.ItemSubType - 1].UpdateData(equiplist[i], occ, itemOperateEnum, self.EquipIdList);
                }
                if (itemConfig.ItemSubType == (int)ItemSubTypeEnum.Shiping)
                {
                    self.EquipList[itemConfig.ItemSubType + shipingIndex - 1].UpdateData(equiplist[i], occ, itemOperateEnum, self.EquipIdList);
                    shipingIndex++;
                }
                if (itemConfig.ItemSubType > (int)ItemSubTypeEnum.Shiping)
                {
                    self.EquipList[itemConfig.ItemSubType + 1].UpdateData(equiplist[i], occ, itemOperateEnum, self.EquipIdList);
                }
            }
        }
    }

}
