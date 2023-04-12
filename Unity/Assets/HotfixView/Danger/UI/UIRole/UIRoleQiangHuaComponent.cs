using System;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

namespace ET 
{
    
    public class UIRoleQiangHuaComponent: Entity, IAwake
    {
        public GameObject ImageSelect;

        public GameObject Text_QiangHuaLv;
        public GameObject Text_QiangHuaName;

        public GameObject NextNode;
        public GameObject MaxNode;

        public GameObject TextQiangHuaName;
        public GameObject TextAttribute1;
        public GameObject QiangHuaCostNode;
        public GameObject TextSuccessAddition;
        public GameObject TextSuccessRate;
        public GameObject TextAttribute2;
        public GameObject ButtonQiangHua;
        public GameObject QiangHuaLevelList;
        public GameObject EquipSet;

        public int ItemSubType;
        public UIEquipSetItemComponent QiangHuaEquipItem;
        public List<UIRoleQiangHuaItemComponent> QiangHuaItemList = new List<UIRoleQiangHuaItemComponent>();
    }


    public class UIRoleQiangHuaComponentAwakeSystem : AwakeSystem<UIRoleQiangHuaComponent>
    {
        public override void Awake(UIRoleQiangHuaComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageSelect = rc.Get<GameObject>("ImageSelect");
            self.Text_QiangHuaLv = rc.Get<GameObject>("Text_QiangHuaLv");
            self.Text_QiangHuaName = rc.Get<GameObject>("Text_QiangHuaName");

            self.NextNode = rc.Get<GameObject>("NextNode");
            self.MaxNode = rc.Get<GameObject>("MaxNode");
            self.TextQiangHuaName = rc.Get<GameObject>("TextQiangHuaName");

            self.TextAttribute1 = rc.Get<GameObject>("TextAttribute1");
            self.QiangHuaCostNode = rc.Get<GameObject>("QiangHuaCostNode");
            self.TextSuccessAddition = rc.Get<GameObject>("TextSuccessAddition");
            self.TextSuccessRate = rc.Get<GameObject>("TextSuccessRate");
            self.TextAttribute2 = rc.Get<GameObject>("TextAttribute2");

            self.ButtonQiangHua = rc.Get<GameObject>("ButtonQiangHua");
            ButtonHelp.AddListenerEx( self.ButtonQiangHua, () => { self.OnButtonQiangHua().Coroutine(); });

            GameObject qiangHuaEquipItem = rc.Get<GameObject>("QiangHuaEquipItem");
            self.QiangHuaEquipItem = self.AddChild<UIEquipSetItemComponent, GameObject>(qiangHuaEquipItem);
            self.QiangHuaLevelList = rc.Get<GameObject>("QiangHuaLevelList");

            self.EquipSet = rc.Get<GameObject>("EquipSet");

            for (int i = 0; i < 11; i++)
            {
                GameObject gameObject = self.EquipSet.transform.Find($"Equip_{i+1}").gameObject;
                UIRoleQiangHuaItemComponent qianghuaItem = self.AddChild<UIRoleQiangHuaItemComponent,GameObject>(gameObject);
                qianghuaItem.OnInitUI(i + 1);
                qianghuaItem.SetClickHandler(self.OnBtn_EquipHandler);
                self.QiangHuaItemList.Add(qianghuaItem);
            }

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };
        }
    }

    public static class UIRoleQiangHuaComponentSystem
    {
        public static void OnUpdateUI(this UIRoleQiangHuaComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            for (int i = 0; i < self.QiangHuaItemList.Count; i++)
            {
                self.QiangHuaItemList[i].OnUpateUI(bagComponent.QiangHuaLevel[i+1]);
            }
            self.QiangHuaItemList[0].OnBtn_Equip();
        }

        public static void OnBtn_EquipHandler(this UIRoleQiangHuaComponent self, int index)
        { 
            self.ItemSubType = index;
            self.OnUpdateQiangHuaUI(index);
        }

        public static void OnUpdateQiangHuaUI(this UIRoleQiangHuaComponent self, int subType)
        {
            self.QiangHuaEquipItem.InitUI(subType);

            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            int qianghuaLevel = bagComponent.QiangHuaLevel[subType];
            int maxLevel = QiangHuaHelper.GetQiangHuaMaxLevel(subType);
           
            self.MaxNode.SetActive(qianghuaLevel >= maxLevel - 1);
            self.NextNode.SetActive(!self.MaxNode.activeSelf);

            UICommonHelper.SetParent(self.ImageSelect, self.QiangHuaItemList[subType-1].GameObject);
            self.ImageSelect.transform.localPosition = new Vector3(1f, -2f, 0f);
            string qianghuaName = ItemViewHelp.EquipWeiZhiToName[subType].Name;
            self.TextQiangHuaName.GetComponent<Text>().text = $"{qianghuaName}强化 +{qianghuaLevel}";
            EquipQiangHuaConfig equipQiangHuaConfig = QiangHuaHelper.GetQiangHuaConfig(subType, qianghuaLevel);

            float fvalue = float.Parse( equipQiangHuaConfig.EquipPropreAdd )* 100f;
            //string svalue = string.Format("{0:F}", fvalue);
            string svalue = fvalue.ToString("0.#####");
            self.TextAttribute1.GetComponent<Text>().text = $"对应部位提升 { svalue}%属性";

            self.Text_QiangHuaLv.GetComponent<Text>().text = $"+{qianghuaLevel}";
            self.Text_QiangHuaName.GetComponent<Text>().text = ItemViewHelp.EquipWeiZhiToName[subType].Name;
            self.QiangHuaItemList[subType - 1].OnUpateUI(qianghuaLevel);

            for (int i = 0; i < self.QiangHuaLevelList.transform.childCount; i++)
            {
                self.QiangHuaLevelList.transform.GetChild(i).gameObject.SetActive(i < qianghuaLevel);
            }
            if (qianghuaLevel >= maxLevel - 1)
            {
                return;
            }
            EquipQiangHuaConfig next_equipQiangHuaConfig = QiangHuaHelper.GetQiangHuaConfig(subType, qianghuaLevel+1);
            fvalue = float.Parse(next_equipQiangHuaConfig.EquipPropreAdd) * 100f;
            svalue = fvalue.ToString("0.#####"); ;/// string.Format("{0:P}", fvalue);
            self.TextAttribute2.GetComponent<Text>().text = $"对应部位提升 { svalue}%属性";

            string costItems = equipQiangHuaConfig.CostItem;
            costItems += $"@1;{equipQiangHuaConfig.CostGold}";
            UICommonHelper.DestoryChild(self.QiangHuaCostNode);
            UICommonHelper.ShowCostItemList(costItems, self.QiangHuaCostNode, self, 1f);

            self.TextSuccessRate.GetComponent<Text>().text = $"强化成功率: {(int)(equipQiangHuaConfig.SuccessPro * 100)}%";
            double addPro = QiangHuaHelper.GetQiangHuaConfig(subType, qianghuaLevel).AdditionPro * bagComponent.QiangHuaFails[subType];
            self.TextSuccessAddition.GetComponent<Text>().text = $"附加成功率 { (int)(addPro *100)}%";
        }

        public static async ETTask OnButtonQiangHua(this UIRoleQiangHuaComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            int qianghuaLevel = bagComponent.QiangHuaLevel[self.ItemSubType];
            int maxLevel = QiangHuaHelper.GetQiangHuaMaxLevel(self.ItemSubType);
            if (qianghuaLevel >= maxLevel - 1)
            {
                FloatTipManager.Instance.ShowFloatTip("已经强化到最大等级！");
                return;
            }

            EquipQiangHuaConfig equipQiangHuaConfig = QiangHuaHelper.GetQiangHuaConfig(self.ItemSubType, qianghuaLevel);
            string costItems = equipQiangHuaConfig.CostItem;
            costItems += $"@1;{equipQiangHuaConfig.CostGold}";
            if (!bagComponent.CheckNeedItem(costItems))
            {
                FloatTipManager.Instance.ShowFloatTip("道具不足！");
                return;
            }

            C2M_ItemQiangHuaRequest c2M_ItemQiangHuaRequest = new C2M_ItemQiangHuaRequest()
            { 
                WeiZhi = self.ItemSubType,
            };
            M2C_ItemQiangHuaResponse m2C_ItemQiangHuaResponse = (M2C_ItemQiangHuaResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemQiangHuaRequest);
            if (m2C_ItemQiangHuaResponse.Error != ErrorCore.ERR_Success)
            {
                return;
            }

            if (bagComponent.QiangHuaLevel[self.ItemSubType] == m2C_ItemQiangHuaResponse.QiangHuaLevel)
            {
                bagComponent.QiangHuaFails[self.ItemSubType]++;
                FloatTipManager.Instance.ShowFloatTip("强化失败！");
            }
            else
            {
                bagComponent.QiangHuaLevel[self.ItemSubType] = m2C_ItemQiangHuaResponse.QiangHuaLevel;
                bagComponent.QiangHuaFails[self.ItemSubType] = 0;
            }
            self.OnUpdateQiangHuaUI(self.ItemSubType);
        }

    }
}
