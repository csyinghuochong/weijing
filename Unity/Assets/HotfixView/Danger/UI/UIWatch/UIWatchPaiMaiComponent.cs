using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UIWatchPaiMaiComponent: Entity, IAwake
    {
        public GameObject ImageDi;
        public GameObject ImageBg;
        public GameObject FastSearchBtn;
        public GameObject PositionSet;

        public Action searchAction;
    }

    public class UIWatchPaiMaiComponentAwakeSystem: AwakeSystem<UIWatchPaiMaiComponent>
    {
        public override void Awake(UIWatchPaiMaiComponent self)
        {
            self.Awake();
        }
    }

    public static class UIWatchPaiMaiComponentSystem
    {
        public static void Awake(this UIWatchPaiMaiComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageDi = rc.Get<GameObject>("ImageDi");

            self.ImageBg = rc.Get<GameObject>("ImageBg");
            self.ImageBg.GetComponent<Button>().onClick.AddListener(() => { self.OnClickImageBg(); });

            self.FastSearchBtn = rc.Get<GameObject>("FastSearchBtn");
            self.FastSearchBtn.GetComponent<Button>().onClick.AddListener(() => { self.OnFastSearchBtn(); });

            self.FastSearchBtn.SetActive(false);
            self.PositionSet = rc.Get<GameObject>("PositionSet");
        }

        /// <summary>
        /// 关闭自身
        /// </summary>
        /// <param name="self"></param>
        public static void OnClickImageBg(this UIWatchPaiMaiComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIWatchPaiMai);
        }

        /// <summary>
        /// 快捷搜索拍卖行物品
        /// </summary>
        /// <param name="self"></param>
        public static void OnFastSearchBtn(this UIWatchPaiMaiComponent self)
        {
            // 讲物品的名称添加到搜索框中
            self.searchAction.Invoke();
            self.OnClickImageBg();
        }

        /// <summary>
        /// 更新UI
        /// </summary>
        /// <param name="self"></param>
        /// <param name="value">需要快捷搜索的物品名称</param>
        public static void OnUpdateUI(this UIWatchPaiMaiComponent self, Action action)
        {
            self.FastSearchBtn.SetActive(true);
            self.searchAction = action;
            self.OnUpdateDi();
            self.OnUpdatePos();
        }

        /// <summary>
        /// 根据子物体的数量动态更新尺寸
        /// </summary>
        /// <param name="self"></param>
        public static void OnUpdateDi(this UIWatchPaiMaiComponent self)
        {
            int number = 0;
            for (int i = 0; i < self.PositionSet.transform.childCount; i++)
            {
                if (self.PositionSet.transform.GetChild(i).gameObject.activeSelf)
                {
                    number++;
                }
            }

            self.ImageDi.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(220, number * 70f);
        }

        /// <summary>
        /// 移动到鼠标点击位置
        /// </summary>
        /// <param name="self"></param>
        public static void OnUpdatePos(this UIWatchPaiMaiComponent self)
        {
            Vector2 localPoint;
            RectTransform canvas = self.GetParent<UI>().GameObject.transform.parent.GetComponent<RectTransform>();
            Camera uiCamera = self.DomainScene().GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, Input.mousePosition, uiCamera, out localPoint);
            self.PositionSet.transform.localPosition = new Vector3(localPoint.x, localPoint.y, 0f);
            self.ImageDi.transform.localPosition = new Vector3(localPoint.x, localPoint.y, 0f);
            self.ImageDi.transform.GetComponent<RectTransform>().sizeDelta = new Vector2(220, 0f);
        }
    }
}