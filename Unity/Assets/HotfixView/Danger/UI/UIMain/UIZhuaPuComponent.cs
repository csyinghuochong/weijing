using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    [Timer(TimerType.UIZhuaPuTimer)]
    public class UIZhuaPuTimer : ATimer<UIZhuaPuComponent>
    {
        public override void Run(UIZhuaPuComponent self)
        {
            try
            {
                self.OnTimer();
            }
            catch (Exception e)
            {
                Log.Error($"move timer error: {self.Id}\n{e}");
            }
        }
    }

    public class UIZhuaPuComponent: Entity, IAwake, IDestroy
    {
        public GameObject ButtonClose;
        public GameObject Img_Node;
        public GameObject Img_ChanZi;
        public GameObject ButtonDig;   
        public GameObject Img_Pos;
        public GameObject TextGaiLv;
        public GameObject BuildingList;

        public float PassTime = 0f;
        public float MoveSpeed = 150f;
        public int ItemId;
        public long Timer;
        public int MonsterId;
        public long MonsterUnitid;

        public List<UIItemComponent> uIItems = new List<UIItemComponent>();
        public BagComponent BagComponent;
    }

    [ObjectSystem]
    public class UIZhuaPuComponentAwake : AwakeSystem<UIZhuaPuComponent>
    {
        public override void Awake(UIZhuaPuComponent self)
        {
            self.ItemId = 0;
            self.MonsterUnitid = 0;
            self.uIItems.Clear();

            GameObject go = self.GetParent<UI>().GameObject;

            self.Img_Pos = go.Get<GameObject>("Img_Pos");
            self.ButtonDig = go.Get<GameObject>("ButtonDig");
            ButtonHelp.AddListenerEx(self.ButtonDig, () => { self.OnButtonDig().Coroutine(); });

            self.Img_ChanZi = go.Get<GameObject>("Img_ChanZi");
            self.Img_Node = go.Get<GameObject>("Img_Node");

            self.TextGaiLv = go.Get<GameObject>("TextGaiLv");

            self.ButtonClose = go.Get<GameObject>("ButtonClose");
            self.ButtonClose.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Remove(self.ZoneScene(), UIType.UIZhuaPu); });

            self.BuildingList = go.Get<GameObject>("BuildingList");
            self.BagComponent = self.ZoneScene().GetComponent<BagComponent>();

            self.InitItemlist();
            self.UpdateItemList();
        }
    }

    [ObjectSystem]
    public class UIZhuaPuComponentDestroy : DestroySystem<UIZhuaPuComponent>
    {
        public override void Destroy(UIZhuaPuComponent self)
        {
            TimerComponent.Instance?.Remove(ref self.Timer);
        }
    }

    public static class UIZhuaPuComponentSystem
    {
        public static void InitItemlist(this UIZhuaPuComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            foreach (var item in GlobalValueConfigCategory.Instance.ZhuaPuItem)
            {
                GameObject go = GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.BuildingList);
                go.transform.localScale = Vector3.one;

                UIItemComponent uI_1 = self.AddChild<UIItemComponent, GameObject>(go);
                uI_1.ShowTip = false;
                uI_1.SetClickHandler(self.OnClickItem);
                self.uIItems.Add(uI_1);
                uI_1.UpdateItem(new BagInfo() { ItemID = item.Key }, ItemOperateEnum.None);
            }
        }

        public static void UpdateItemList(this UIZhuaPuComponent self)
        {
            for (int i = 0; i < self.uIItems.Count; i++)
            { 
                int itemid = self.uIItems[i].ItemID;    
                long number = self.BagComponent.GetItemNumber(itemid);

                self.uIItems[i].Label_ItemNum.GetComponent<Text>().text  = ComHelp.ReturnNumStr(number);
                UICommonHelper.SetImageGray(self.uIItems[i].Image_ItemIcon, number <= 0);
                UICommonHelper.SetImageGray(self.uIItems[i].Image_ItemQuality, number <= 0);
            }
        }

        public static void SelectItemList(this UIZhuaPuComponent self, int itemid)
        {
            for (int i = 0; i < self.uIItems.Count; i++)
            {
                self.uIItems[i].Image_XuanZhong.SetActive(itemid == self.uIItems[i].ItemID);
            }
        }

        public static void OnClickItem(this UIZhuaPuComponent self, BagInfo bagInfo)
        {
            long leftnumber = self.BagComponent.GetItemNumber(bagInfo.ItemID);
            if (leftnumber <= 0)
            {
                FloatTipManager.Instance.ShowFloatTip("道具不足！");
                return;
            }

            if (self.ItemId == bagInfo.ItemID)
            {
                self.ItemId = 0;
            }
            else
            {
                self.ItemId = bagInfo.ItemID;
            }
            self.SelectItemList(self.ItemId);
            self.UpdateGailv();
        }

        public static void OnTimer(this UIZhuaPuComponent self)
        {
            self.PassTime += Time.deltaTime;
            float posX = self.PassTime * self.MoveSpeed;
            if (posX > 580f)
            {
                posX = 0;
                self.PassTime = 0;
            }
            self.Img_ChanZi.transform.localPosition = new Vector3(posX, 0f, 0f);
        }

        public static void UpdateGailv(this UIZhuaPuComponent self)
        {
            if (self.MonsterId == 0)
            {
                return;
            }

            int gailv = ComHelp.GetZhuPuGaiLv(self.MonsterId, self.ItemId, 1);
            self.TextGaiLv.GetComponent<Text>().text = $"抓捕成功率： {gailv*0.01f}%";
        }

        public static void OnInitUI(this UIZhuaPuComponent self, Unit unitmonster)
        {
            self.MonsterId = unitmonster.ConfigId;
            self.MonsterUnitid = unitmonster.Id;
            float size = RandomHelper.RandFloat01();
            self.Img_Pos.transform.localPosition = new Vector3(size * 300f, 0f, 0f);
            TimerComponent.Instance.Remove(ref self.Timer);
            self.Timer = TimerComponent.Instance.NewFrameTimer(TimerType.UIZhuaPuTimer, self);

            self.UpdateGailv();
        }

        public static async ETTask OnButtonDig(this UIZhuaPuComponent self)
        {
            float distance = Vector3.Distance(self.Img_ChanZi.transform.localPosition, self.Img_Pos.transform.localPosition);
            string jiacheng = distance <= 10f ? "2" : "1";
            TimerComponent.Instance?.Remove(ref self.Timer);
            C2M_JingLingCatchRequest request  = new C2M_JingLingCatchRequest() { JingLingId = self.MonsterUnitid , ItemId = self.ItemId, OperateType = jiacheng  };
            M2C_JingLingCatchResponse response = (M2C_JingLingCatchResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (response.Error == ErrorCore.ERR_Success)
            {
                FloatTipManager.Instance.ShowFloatTip("恭喜你,抓捕成功！");
            }

            if (response.Error == ErrorCore.ERR_ZhuaBuFail)
            {
                List<string> strList = new List<string>();
                strList.Add("它趁你不注意,偷偷的溜走了!");
                strList.Add("抓铺的动作太大,被他发现后马上的逃走了!");

                int randInt = RandomHelper.RandomNumber(0, strList.Count);
                FloatTipManager.Instance.ShowFloatTip(strList[randInt]);
            }

            UIHelper.Remove(self.ZoneScene(), UIType.UIZhuaPu);
        }
    }
}
