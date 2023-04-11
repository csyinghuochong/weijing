using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanRecordComponent : Entity, IAwake, IDestroy
    {
        public GameObject ImageClose;
        public GameObject UIJiaYuanRecordItem;
        public GameObject BuildingList2;
    }


    public class UIJiaYuanRecordComponentAwake : AwakeSystem<UIJiaYuanRecordComponent>
    {
        public override void Awake(UIJiaYuanRecordComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageClose = rc.Get<GameObject>("ImageClose");
            self.ImageClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove( self.ZoneScene(), UIType.UIJiaYuanRecord ); });

            self.UIJiaYuanRecordItem = rc.Get<GameObject>("UIJiaYuanRecordItem");
            self.UIJiaYuanRecordItem.SetActive(false);
            self.BuildingList2 = rc.Get<GameObject>("BuildingList2");

            self.OnInitUI().Coroutine();
        }
    }

    public static class UIJiaYuanRecordComponentSystem
    {
        public static async ETTask OnInitUI(this UIJiaYuanRecordComponent self)
        {
            C2M_JiaYuanRecordListRequest  request = new C2M_JiaYuanRecordListRequest();
            M2C_JiaYuanRecordListResponse response = (M2C_JiaYuanRecordListResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (self.IsDisposed)
            {
                return;
            }

            for (int i = 0; i < response.JiaYuanRecordList.Count; i++)
            {
                GameObject gameObject = GameObject.Instantiate( self.UIJiaYuanRecordItem );
                gameObject.SetActive(true);
                UICommonHelper.SetParent( gameObject, self.BuildingList2 );
                JiaYuanRecord jiaYuanRecord = response.JiaYuanRecordList[i];
                string time = TimeInfo.Instance.ToDateTime(jiaYuanRecord.Time).ToString();
                time = time.Split(' ')[1];
                Text Text = gameObject.transform.Find("Text").GetComponent<Text>();
                string tip = string.Empty;
                tip = $"{time} 玩家<color=#9CA606>{jiaYuanRecord.PlayerName}</color>";
                switch (jiaYuanRecord.OperateType)
                {
                    case JiaYuanOperateType.Visit:
                        tip += " 来到你的家园逛了一圈。";
                        break;
                    case JiaYuanOperateType.GatherPlant:
                        tip += $" 在你的家园拾取了<color=#9CA606> {JiaYuanFarmConfigCategory.Instance.Get(jiaYuanRecord.OperateId).Name}</color>";
                        break;
                    case JiaYuanOperateType.GatherPasture:
                        tip += $" 在你的家园拾取了<color=#9CA606> {JiaYuanPastureConfigCategory.Instance.Get(jiaYuanRecord.OperateId).Name}</color>";
                        break;
                    case JiaYuanOperateType.Pick:
                        tip += $" 在你的家园清理了<color=#9CA606> {MonsterConfigCategory.Instance.Get(jiaYuanRecord.OperateId).MonsterName}</color>";
                        break;
                    default:
                        break;
                }

                Text.text = tip;
            }
        }
    }
}

