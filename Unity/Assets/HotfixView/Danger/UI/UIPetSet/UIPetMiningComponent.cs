using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ET
{

    public class UIPetMiningComponent : Entity, IAwake
    {

        public GameObject ButtonReward_2;

        public GameObject UIPetMiningItem;
        public GameObject PetMiningNode;
        public UIPageButtonComponent UIPageButton;

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
            uIPageViewComponent.OnSelectIndex(0);
        }
    }

    public static class UIPetMiningComponentSystem
    {
        public static  void OnButtonReward_2(this UIPetMiningComponent self)
        {
            UIHelper.Create(self.ZoneScene(), UIType.UIPetMiningReward  ).Coroutine();
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