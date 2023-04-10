using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{
    public class UIJiaYuanPetFeedComponent : Entity, IAwake, IDestroy
    {
        public GameObject ImageClose;
        public GameObject ButtonEat;
        public GameObject BuildingList2;

        public GameObject Text_PetName;
        public GameObject RawImage;

        public RenderTexture RenderTexture;
        public UIModelDynamicComponent UIModelShowComponent;

        public GameObject Text_HourExp;
        public GameObject[] MoodList = new GameObject[5];
        public UIItemComponent[] CostItemList = new UIItemComponent[3];
        public List<UIItemComponent> ItemUIlist = new List<UIItemComponent>();

        public JiaYuanPet JiaYuanPet;
        public bool IsHoldDown;
    }

    public class UIJiaYuanPetFeedComponentAwake : AwakeSystem<UIJiaYuanPetFeedComponent>
    {
        public override void Awake(UIJiaYuanPetFeedComponent self)
        {
            self.IsHoldDown = false;
            self.JiaYuanPet = null;
            self.ItemUIlist.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageClose = rc.Get<GameObject>("ImageClose");
            self.ImageClose.GetComponent<Button>().onClick.AddListener(self.OnImageClose);

            self.Text_HourExp = rc.Get<GameObject>("Text_HourExp");

            self.ButtonEat = rc.Get<GameObject>("ButtonEat");
            ButtonHelp.AddListenerEx( self.ButtonEat, () => { self.OnButtonEat().Coroutine(); } );

            for (int i = 0; i < self.MoodList.Length; i++)
            {
                self.MoodList[i] = rc.Get<GameObject>($"Image_Mood_{i}");
            }

            self.BuildingList2 = rc.Get<GameObject>("BuildingList2");
            self.Text_PetName = rc.Get<GameObject>("Text_PetName");

            self.RawImage = rc.Get<GameObject>("RawImage");
            var path = ABPathHelper.GetUGUIPath("Common/UIModelDynamic");
            GameObject bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject);
            self.UIModelShowComponent = self.AddChild<UIModelDynamicComponent, GameObject>(gameObject);

            for (int i = 0; i < self.CostItemList.Length; i++)
            {
                GameObject item = rc.Get<GameObject>($"UICommonItem_{i}");
                self.CostItemList[i] = self.AddChild<UIItemComponent, GameObject>(item);
            }

            DataUpdateComponent.Instance.AddListener(DataType.HuiShouSelect, self);
        }
    }

    public class UIJiaYuanPetFeedComponentDestroy : DestroySystem<UIJiaYuanPetFeedComponent>
    {
        public override void Destroy(UIJiaYuanPetFeedComponent self)
        {
            self.UIModelShowComponent.ReleaseRenderTexture();
            self.RenderTexture.Release();
            GameObject.Destroy(self.RenderTexture);
            self.RenderTexture = null;
            //RenderTexture.ReleaseTemporary(self.RenderTexture);

            DataUpdateComponent.Instance.RemoveListener(DataType.HuiShouSelect, self);
        }
    }

    public static class UIJiaYuanPetFeedComponentSystem
    {

        public static void OnImageClose(this UIJiaYuanPetFeedComponent self)
        {
            UI uI = UIHelper.GetUI( self.ZoneScene(), UIType.UIJiaYuanMain );
            uI.GetComponent<UIJiaYuanMainComponent>().WaitPetWalk(self.JiaYuanPet);
            UIHelper.Remove(self.ZoneScene(), UIType.UIJiaYuanPetFeed);
        }

        public static void OnInitUI(this UIJiaYuanPetFeedComponent self, JiaYuanPet jiaYuanPet)
        {
            self.JiaYuanPet = jiaYuanPet;
            self.RenderTexture = new RenderTexture(512, 512, 16, RenderTextureFormat.ARGB32);
            self.RenderTexture.Create();
            self.RawImage.GetComponent<RawImage>().texture = self.RenderTexture;

            GameObject gameObject = self.UIModelShowComponent.GameObject;
            self.UIModelShowComponent.OnInitUI(self.RawImage, self.RenderTexture);
            PetConfig petConfig = PetConfigCategory.Instance.Get(jiaYuanPet.ConfigId);
            self.UIModelShowComponent.ShowModel("Pet/" + petConfig.PetModel).Coroutine();
            gameObject.transform.Find("Camera").localPosition = new Vector3(0f, 100f, 450f);
            gameObject.transform.Find("Camera").GetComponent<Camera>().fieldOfView = 30;
            gameObject.transform.localPosition = new Vector2(1000, 0);
            gameObject.transform.Find("Model").localRotation = Quaternion.Euler(0f, -45f, 0f);

            self.OnUpdateItemList();
            self.OnUpdatePetInfo();
        }

        public static void OnUpdatePetInfo(this UIJiaYuanPetFeedComponent self)
        {
            JiaYuanComponent jiaYuanComponent = self.ZoneScene().GetComponent<JiaYuanComponent>();
            JiaYuanPet jiaYuanPet = jiaYuanComponent.GetJiaYuanPet(self.JiaYuanPet.unitId);

            for (int i = 0; i < self.MoodList.Length; i++)
            {
                self.MoodList[i].SetActive( i < JiaYuanHelper.GetPetMoodStar(jiaYuanPet.MoodValue));
            }

            ExpConfig expConfig = ExpConfigCategory.Instance.Get(jiaYuanPet.PetLv);
            //int addExp = (int)(expConfig.PetItemUpExp * JiaYuanHelper.GetPetExpCoff(jiaYuanPet.MoodValue));
            int addExp = ComHelp.GetJiaYuanPetExp(jiaYuanPet.PetLv, jiaYuanPet.MoodValue);
            self.Text_HourExp.GetComponent<Text>().text = $"经验收益: {addExp}/小时";
        }

        public static void OnUpdateItemList(this UIJiaYuanPetFeedComponent self)
        {
            var path = ABPathHelper.GetUGUIPath("Main/Common/UICommonItem");
            var bundleGameObject = ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            List<BagInfo> bagInfos = bagComponent.GetBagList();

            int number = 0;
            for (int i = 0; i < bagInfos.Count; i++)
            {
                ItemConfig itemConfig = ItemConfigCategory.Instance.Get(bagInfos[i].ItemID);
                bool ifShow = false;
                if (!ifShow && itemConfig.ItemType == 1 && itemConfig.ItemSubType == 131)
                {
                    ifShow = true;
                    //continue;
                }

                if (!ifShow && itemConfig.ItemType == 2 && itemConfig.ItemSubType == 101 || itemConfig.ItemSubType == 201 && itemConfig.ItemSubType == 301)
                {
                    ifShow = true;
                    //continue;
                }

                if (ifShow)
                {
                    UIItemComponent uI_1 = null;
                    if (number < self.ItemUIlist.Count)
                    {
                        uI_1 = self.ItemUIlist[number];
                        uI_1.GameObject.SetActive(true);
                    }
                    else
                    {
                        GameObject gameObject = GameObject.Instantiate(bundleGameObject);
                        UICommonHelper.SetParent(gameObject, self.BuildingList2);
                        uI_1 = self.AddChild<UIItemComponent, GameObject>(gameObject);
                        uI_1.PointerDownHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerDown(binfo, pdata).Coroutine(); };
                        uI_1.PointerUpHandler = (BagInfo binfo, PointerEventData pdata) => { self.OnPointerUp(binfo, pdata); };
                        uI_1.SetEventTrigger(true);
                        self.ItemUIlist.Add(uI_1);
                    }
                    uI_1.UpdateItem(bagInfos[i], ItemOperateEnum.HuishouBag);

                    number++;
                }
            }
            for (int i = number; i < self.ItemUIlist.Count; i++)
            {
                self.ItemUIlist[i].GameObject.SetActive(false);
            }
        }

        public static void OnHuiShouSelect(this UIJiaYuanPetFeedComponent self, string dataparams)
        {
            string[] huishouInfo = dataparams.Split('_');
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            BagInfo bagInfo = bagComponent.GetBagInfo(long.Parse(huishouInfo[1]));
            if (bagInfo == null)
            {
                return;
            }

            for (int i = 0; i < self.CostItemList.Length; i++)
            {
                if (self.CostItemList[i].Baginfo == null)
                {
                    continue;
                }
                if (self.CostItemList[i].Baginfo.BagInfoID == bagInfo.BagInfoID)
                {
                    self.CostItemList[i].UpdateItem(null, ItemOperateEnum.None);
                    self.CostItemList[i].Label_ItemName.SetActive(false);
                }
            }

            //1新增  2移除 
            if (huishouInfo[0] == "1")
            {
                for (int i = 0; i < self.CostItemList.Length; i++)
                {
                    if (self.CostItemList[i].Baginfo == null)
                    {
                        self.CostItemList[i].UpdateItem(bagInfo, ItemOperateEnum.HuishouShow);
                        self.CostItemList[i].Label_ItemNum.GetComponent<Text>().text = "1";
                        self.CostItemList[i].Label_ItemName.SetActive(true);
                        break;
                    }
                }
            }
               
            self.UpdateSelected();
        }

        public static async ETTask OnButtonEat(this UIJiaYuanPetFeedComponent self)
        {
            List<long> idslist = new List<long>();
            for (int h = 0; h < self.CostItemList.Length; h++)
            {
                if (self.CostItemList[h].Baginfo != null)
                {
                    idslist.Add(self.CostItemList[h].Baginfo.BagInfoID);
                }
            }

            C2M_JiaYuanPetFeedRequest   request = new C2M_JiaYuanPetFeedRequest() { PetId = self.JiaYuanPet.unitId,  BagInfoIDs = idslist };
            M2C_JiaYuanPetFeedResponse response = (M2C_JiaYuanPetFeedResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            self.ZoneScene().GetComponent<JiaYuanComponent>().JiaYuanPetList_2 = response.JiaYuanPetList;

            FloatTipManager.Instance.ShowFloatTip($"宠物增加 {response.MoodAdd}心情值");

            self.OnUpdateItemList();
            self.OnUpdatePetInfo();
            self.UpdateCostList();
            self.UpdateSelected();
        }

        public static void UpdateCostList(this UIJiaYuanPetFeedComponent self)
        {
            BagComponent bagComponent = self.ZoneScene().GetComponent<BagComponent>();
            for (int h = 0; h < self.CostItemList.Length; h++)
            {
                if (self.CostItemList[h].Baginfo == null)
                {
                    continue;
                }
                if (null == bagComponent.GetBagInfo(self.CostItemList[h].Baginfo.BagInfoID))
                {
                    self.CostItemList[h].UpdateItem(null, ItemOperateEnum.None);
                    self.CostItemList[h].Label_ItemName.SetActive(false);
                }
            }
        }

        public static void UpdateSelected(this UIJiaYuanPetFeedComponent self)
        {
            for (int i = 0; i < self.ItemUIlist.Count; i++)
            {
                UIItemComponent uIItemComponent = self.ItemUIlist[i];
                BagInfo bagInfo = uIItemComponent.Baginfo;
                if (bagInfo == null)
                {
                    continue;
                }
                bool have = false;
                for (int h = 0; h < self.CostItemList.Length; h++)
                {
                    if (self.CostItemList[h].Baginfo != null
                     && self.CostItemList[h].Baginfo.BagInfoID == bagInfo.BagInfoID)
                    {
                        have = true;
                    }
                }
                uIItemComponent.Image_XuanZhong.SetActive(have);
            }
        }

        public static async ETTask OnPointerDown(this UIJiaYuanPetFeedComponent self, BagInfo binfo, PointerEventData pdata)
        {
            if (binfo == null)
            {
                return;
            }

            self.IsHoldDown = true;
            HintHelp.GetInstance().DataUpdate(DataType.HuiShouSelect, $"1_{binfo.BagInfoID}");
            await TimerComponent.Instance.WaitAsync(500);
            if (!self.IsHoldDown)
            {
                return;
            }
            EventType.ShowItemTips.Instance.ZoneScene = self.DomainScene();
            EventType.ShowItemTips.Instance.bagInfo = binfo;
            EventType.ShowItemTips.Instance.itemOperateEnum = ItemOperateEnum.None;
            EventType.ShowItemTips.Instance.inputPoint = Input.mousePosition;
            EventType.ShowItemTips.Instance.Occ = self.ZoneScene().GetComponent<UserInfoComponent>().UserInfo.Occ;
            Game.EventSystem.PublishClass(EventType.ShowItemTips.Instance);
        }

        public static void OnPointerUp(this UIJiaYuanPetFeedComponent self, BagInfo binfo, PointerEventData pdata)
        {
            self.IsHoldDown = false;
            UIHelper.Remove(self.DomainScene(), UIType.UIEquipDuiBiTips);
        }

    }
}
