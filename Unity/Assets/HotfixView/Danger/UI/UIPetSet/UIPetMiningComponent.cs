using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class UIPetMiningComponent : Entity, IAwake
    {
        public GameObject ButtonReward_2;

        public GameObject UIPetMiningItem;
        public GameObject PetMiningNode;
        public UIPageButtonComponent UIPageButton;
        public GameObject PetMiningTeamButton;

        public List<UIPetMiningItemComponent> PetMiningItemList = new List<UIPetMiningItemComponent>(); 
    }

    public class UIPetMiningComponentAwake : AwakeSystem<UIPetMiningComponent>
    {
        public override void Awake(UIPetMiningComponent self)
        {
            self.PetMiningItemList.Clear();
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.UIPetMiningItem = rc.Get<GameObject>("UIPetMiningItem");
            self.UIPetMiningItem.SetActive(false);

            self.PetMiningTeamButton = rc.Get<GameObject>("PetMiningTeamButton");
            self.PetMiningTeamButton.GetComponent<Button>().onClick.AddListener(() => { UIHelper.Create( self.ZoneScene(),UIType.UIPetMiningTeam ).Coroutine();  } );


            self.PetMiningNode = rc.Get<GameObject>("PetMiningNode");

            self.ButtonReward_2 = rc.Get<GameObject>("ButtonReward_2");
            self.ButtonReward_2.GetComponent<Button>().onClick.AddListener(self.OnButtonReward_2);

           //单选组件
           GameObject BtnItemTypeSet = rc.Get<GameObject>("BtnItemTypeSet");
            UI uiPage = self.AddChild<UI, string, GameObject>("BtnItemTypeSet", BtnItemTypeSet);
            UIPageButtonComponent uIPageViewComponent = uiPage.AddComponent<UIPageButtonComponent>();
            uIPageViewComponent.SetClickHandler((int page) => {
                self.OnClickPageButton(page);
            });
            self.UIPageButton = uIPageViewComponent;
            self.UIPageButton.ClickEnabled = false;

            self.GetParent<UI>().OnUpdateUI = () => { self.RequestMingList().Coroutine(); };
        }
    }

    public static class UIPetMiningComponentSystem
    {
        public static void OnButtonReward_2(this UIPetMiningComponent self)
        {
            UIHelper.Create(self.ZoneScene(), UIType.UIPetMiningReward).Coroutine();
        }

        public static async ETTask RequestMingList(this UIPetMiningComponent self)
        {
            long intanceid = self.InstanceId;
            C2A_PetMingListRequest request = new C2A_PetMingListRequest() { };
            A2C_PetMingListResponse response = (A2C_PetMingListResponse)await self.ZoneScene().GetComponent<SessionComponent>().Session.Call(request);
            if (intanceid != self.InstanceId || response.Error != ErrorCode.ERR_Success)
            {
                return;
            }

            self.UIPageButton.ClickEnabled = true;
            self.UIPageButton.OnSelectIndex(0);
        }

        public static void OnClickPageButton(this UIPetMiningComponent self, int page)
        {
            float maxWidth = 0;
            List<PetMiningItem> miningItems = ConfigHelper.PetMiningList[page + 1];

            for (int i = 0; i < miningItems.Count; i++)
            {
                UIPetMiningItemComponent uIPetMiningItem = null;
                if ( i < self.PetMiningItemList.Count)
                {
                    uIPetMiningItem = self.PetMiningItemList[i];
                    uIPetMiningItem.GameObject.SetActive(true);
                }
                else
                {
                    GameObject gameObject = GameObject.Instantiate( self.UIPetMiningItem );
                    gameObject.SetActive(true);
                    uIPetMiningItem = self.AddChild<UIPetMiningItemComponent, GameObject>(gameObject);
                    UICommonHelper.SetParent(gameObject, self.PetMiningNode);
                    self.PetMiningItemList.Add(uIPetMiningItem);
                    gameObject.GetComponent<RectTransform>().anchoredPosition = new Vector3(miningItems[i].X, miningItems[i].Y, 0f);
                }

                maxWidth = miningItems[i].X + 300;
            }
            for ( int i= miningItems.Count; i < self.PetMiningItemList.Count; i++ )
            {
                self.PetMiningItemList[i].GameObject.SetActive(false);
            }


            self.PetMiningNode.GetComponent<RectTransform>().sizeDelta = new Vector2(maxWidth, self.PetMiningNode.GetComponent<RectTransform>().sizeDelta.y);
        }
    }
}