using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIShouJiChapterComponent : Entity, IAwake<GameObject>
    {
        public GameObject GameObject;

        public GameObject ImageProgress;
        public GameObject ItemNode;
        public GameObject Text_Attribute3;
        public GameObject Text_Attribute2;
        public GameObject Text_Attribute1;
        public GameObject Text_Star3;
        public GameObject Text_Star2;
        public GameObject Text_Star1;

        public GameObject[] Button_Open;
        public GameObject[] Button_Close;

        public GameObject Text_StarNum;
        public GameObject Text_Name;

        public int ChapterId;
    }


    public class UIShouJiChapterComponentAwakeSystem : AwakeSystem<UIShouJiChapterComponent, GameObject>
    {
        public override void Awake(UIShouJiChapterComponent self, GameObject go)
        {
            self.GameObject = go;

            self.ImageProgress = go.Get<GameObject>("ImageProgress");
            self.ItemNode = go.Get<GameObject>("ItemNode");
            self.Text_Attribute3 = go.Get<GameObject>("Text_Attribute3");
            self.Text_Attribute2 = go.Get<GameObject>("Text_Attribute2");
            self.Text_Attribute1 = go.Get<GameObject>("Text_Attribute1");
            self.Text_Star3 = go.Get<GameObject>("Text_Star3");
            self.Text_Star2 = go.Get<GameObject>("Text_Star2");
            self.Text_Star1 = go.Get<GameObject>("Text_Star1");
            self.Text_StarNum = go.Get<GameObject>("Text_StarNum");
            self.Text_Name = go.Get<GameObject>("Text_Name");

            self.Button_Open = new GameObject[3];
            self.Button_Open[2] = go.Get<GameObject>("Img_Chest_3_Open");
            self.Button_Open[1] = go.Get<GameObject>("Img_Chest_2_Open");
            self.Button_Open[0] = go.Get<GameObject>("Img_Chest_1_Open");

            self.Button_Close = new GameObject[3];
            self.Button_Close[2] = go.Get<GameObject>("Img_Chest_3_Close");
            self.Button_Close[1] = go.Get<GameObject>("Img_Chest_2_Close");
            self.Button_Close[0] = go.Get<GameObject>("Img_Chest_1_Close");

            ButtonHelp.AddEventTriggers(self.Button_Close[2], (PointerEventData pdata) => { self.BeginDrag(pdata, 3).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Button_Close[2], (PointerEventData pdata) => { self.EndDrag(pdata, 3); }, EventTriggerType.PointerUp);

            ButtonHelp.AddEventTriggers(self.Button_Close[1], (PointerEventData pdata) => { self.BeginDrag(pdata, 2).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Button_Close[1], (PointerEventData pdata) => { self.EndDrag(pdata, 2); }, EventTriggerType.PointerUp);

            ButtonHelp.AddEventTriggers(self.Button_Close[0], (PointerEventData pdata) => { self.BeginDrag(pdata, 1).Coroutine(); }, EventTriggerType.PointerDown);
            ButtonHelp.AddEventTriggers(self.Button_Close[0], (PointerEventData pdata) => { self.EndDrag(pdata, 1); }, EventTriggerType.PointerUp);
        }
    }

    public static class UIShouJiChapterComponentSystem
    {
        public static async ETTask BeginDrag(this UIShouJiChapterComponent self, PointerEventData pdata, int index)
        {
            UI skillTips = await UIHelper.Create(self.DomainScene(), UIType.UICountryTips);

            Vector2 localPoint;
            RectTransform canvas = UIEventComponent.Instance.UILayers[(int)UILayer.Mid].gameObject.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, pdata.position, uiCamera, out localPoint);
            ShouJiConfig shouJiConfig = ShouJiConfigCategory.Instance.Get(self.ChapterId);
            string rewards = "";
            if (index == 3) rewards = shouJiConfig.RewardList_3;
            if (index == 2) rewards = shouJiConfig.RewardList_2;
            if (index == 1) rewards = shouJiConfig.RewardList_1;
            skillTips.GetComponent<UICountryTipsComponent>().OnUpdateUI(rewards, new Vector3(localPoint.x, localPoint.y, 0f));
        }

        public static void EndDrag(this UIShouJiChapterComponent self, PointerEventData pdata, int index)
        {
            self.OnBtn_Reward_Type(index);
            UIHelper.Remove(self.DomainScene(), UIType.UICountryTips);
        }

        public static void  OnBtn_Reward_Type(this UIShouJiChapterComponent self, int index)
        {
            ShouJiConfig shouJiConfig = ShouJiConfigCategory.Instance.Get(self.ChapterId);
            ShouJiChapterInfo shouJiChapterInfo = self.ZoneScene().GetComponent<ShoujiComponent>().GetShouJiChapterInfo(self.ChapterId);
            if (shouJiChapterInfo == null)
            {
                return;
            }
            if ((shouJiChapterInfo.RewardInfo & 1 << index) > 0)
            {
                return;
            }
            if (index == 1 && shouJiChapterInfo.StarNum < shouJiConfig.ProList1_StartNum)
            {
                FloatTipManager.Instance.ShowFloatTip("条件不足！");
                return;
            }
            if (index == 2 && shouJiChapterInfo.StarNum < shouJiConfig.ProList2_StartNum)
            {
                FloatTipManager.Instance.ShowFloatTip("条件不足！");
                return;
            }
            if (index == 3 && shouJiChapterInfo.StarNum < shouJiConfig.ProList3_StartNum)
            {
                FloatTipManager.Instance.ShowFloatTip("条件不足！");
                return;
            }
          
            self.ReqestShoujiReward(self.ChapterId, index).Coroutine();
        }

        public static async ETTask<int> ReqestShoujiReward(this UIShouJiChapterComponent self, int chapterId, int index)
        {
            try
            {
                C2M_ShoujiRewardRequest c2M_ItemHuiShouRequest = new C2M_ShoujiRewardRequest() { ChapterId = chapterId, RewardIndex = index };
                M2C_ShoujiRewardResponse r2c_roleEquip = (M2C_ShoujiRewardResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_ItemHuiShouRequest);

                if (r2c_roleEquip.Error == ErrorCore.ERR_Success)
                {
                    ShoujiComponent shoujiComponent = self.ZoneScene().GetComponent<ShoujiComponent>();
                    ShouJiChapterInfo shouJiChapterInfo = shoujiComponent.GetShouJiChapterInfo(chapterId);
                    shouJiChapterInfo.RewardInfo |= (1 << index);
                }
                return r2c_roleEquip.Error;
            }
            catch (Exception ex)
            {
                Log.Error(ex.ToString());
            }
            return ErrorCore.ERR_NetWorkError;
        }

        public static void UpdateStarInfo(this UIShouJiChapterComponent self, ShouJiConfig shouJiConfig)
        { 
            ShoujiComponent shoujiComponent = self.ZoneScene().GetComponent<ShoujiComponent>();
            int starNum = shoujiComponent.GetChapterStar(shouJiConfig.Id);
            float progress = starNum * 1f / shouJiConfig.ProList3_StartNum;
            progress = Mathf.Min(1f, progress);

            self.ImageProgress.GetComponent<Image>().fillAmount = progress;
            self.Text_Name.GetComponent<Text>().text = shouJiConfig.ChapterDes;
            self.Text_StarNum.GetComponent<Text>().text = $"{starNum}/{shouJiConfig.ProList3_StartNum}";
            self.Text_Star1.GetComponent<Text>().text = shouJiConfig.ProList1_StartNum.ToString();
            self.Text_Star2.GetComponent<Text>().text = shouJiConfig.ProList2_StartNum.ToString();
            self.Text_Star3.GetComponent<Text>().text = shouJiConfig.ProList3_StartNum.ToString();
            self.Text_Attribute1.GetComponent<Text>().text = ItemViewHelp.GetAttributeDesc(shoujiComponent.GetChapterPro(shouJiConfig.Id, 1));
            self.Text_Attribute2.GetComponent<Text>().text = ItemViewHelp.GetAttributeDesc(shoujiComponent.GetChapterPro(shouJiConfig.Id, 2));
            self.Text_Attribute3.GetComponent<Text>().text = ItemViewHelp.GetAttributeDesc(shoujiComponent.GetChapterPro(shouJiConfig.Id, 3));
        }

        public static async ETTask OnInitUI(this UIShouJiChapterComponent self, ShouJiConfig shouJiConfig)
        {
            self.ChapterId = shouJiConfig.Id;
            self.UpdateStarInfo(shouJiConfig);
            await ETTask.CompletedTask;
            var path = ABPathHelper.GetUGUIPath("Main/ShouJi/UIShouJiItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            int itemNum = 0;
            int itemId = shouJiConfig.ItemListID;
            long instanceId = self.InstanceId;

            int testId = itemId;
            while (testId != 0)
            {
                itemNum++;
                ShouJiItemConfig shouJiItemConfig = ShouJiItemConfigCategory.Instance.Get(testId);
                testId = shouJiItemConfig.NextID;
            }
            int row = (itemNum / 10);
            row += (itemNum % 10 > 0 ? 1 : 0);
            self.GameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(1600f, 380 + row * 300f);

            while (itemId!= 0)
            {
                if (itemNum % 10 == 0)
                {
                    await TimerComponent.Instance.WaitFrameAsync();
                }
                if (instanceId != self.InstanceId)
                {
                    return;
                }
                GameObject go =  GameObject.Instantiate(bundleGameObject);
                UICommonHelper.SetParent(go, self.ItemNode);
                ShouJiItemConfig shouJiItemConfig = ShouJiItemConfigCategory.Instance.Get(itemId);
                self.AddChild<UIShouJiItemComponent, GameObject>(go).OnUpdateUI(shouJiConfig.Id, shouJiItemConfig);
                itemId = shouJiItemConfig.NextID;
            }
        }
    }
}
