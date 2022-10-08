using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public  class UIEquipDuiBiTipsComponent : Entity, IAwake
    {
        public GameObject ImageButton;
        public GameObject Tips2;
        public GameObject Tips1;

        public UI UI_1;
        public UI UI_2;
    }

    [ObjectSystem]
    public class UIEquipDuiBiTipsComponentAwakeSystem : AwakeSystem<UIEquipDuiBiTipsComponent>
    {
        public override void Awake(UIEquipDuiBiTipsComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ImageButton = rc.Get<GameObject>("ImageButton");
            self.ImageButton.GetComponent<Button>().onClick.AddListener(() => { self.OnCloseTips(); });

            self.Tips2 = rc.Get<GameObject>("Tips2");
            self.Tips1 = rc.Get<GameObject>("Tips1");
        }
    }

    public static class UIEquipDuiBiTipsComponentSystem
    {
       
        public static void OnCloseTips(this UIEquipDuiBiTipsComponent self)
        {
            UIHelper.Remove(self.DomainScene(), UIType.UIEquipDuiBiTips);
        }

        public static async ETTask OnUpdateEquipUI(this UIEquipDuiBiTipsComponent self, EventType.ShowItemTips args)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/ItemTips/UIEquipTips");
            GameObject bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            UI ui_1 = self.AddChild<UI, string, GameObject>( "UIEquipTips_1", UnityEngine.Object.Instantiate(bundleGameObject));
            self.UI_1 = ui_1;
            UIEquipTipsComponent UIPetInfoShow_1 = ui_1.AddComponent<UIEquipTipsComponent>();
            UIPetInfoShow_1.Img_back_btn.SetActive(false);
            UIPetInfoShow_1.InitData(args.bagInfo, args.itemOperateEnum, 0, args.EquipList);
            UICommonHelper.SetParent(ui_1.GameObject, self.Tips1);
        }

        public static async ETTask OnUpdateAppraisalUI(this UIEquipDuiBiTipsComponent self, EventType.ShowItemTips args)
        {
            long instanceid = self.InstanceId;
            var path = ABPathHelper.GetUGUIPath("Main/ItemTips/UIItemAppraisalTips");
            await ETTask.CompletedTask;
            GameObject  bundleGameObject =ResourcesComponent.Instance.LoadAsset<GameObject>(path);
            if (instanceid != self.InstanceId)
            {
                return;
            }
            UI ui_1 = self.AddChild<UI, string, GameObject>("UIEquipTips_2", UnityEngine.Object.Instantiate(bundleGameObject));
            UIItemAppraisalTipsComponent uIItemAppraisalTipsComponent = ui_1.AddComponent<UIItemAppraisalTipsComponent>();
            uIItemAppraisalTipsComponent.InitData(args.bagInfo, args.itemOperateEnum);
            uIItemAppraisalTipsComponent.Imagebg.SetActive(false);
            UICommonHelper.SetParent(ui_1.GameObject, self.Tips1);
        }

        public static async ETTask OnUpdateDuiBiUI(this UIEquipDuiBiTipsComponent self, BagInfo bagInfo_1, EventType.ShowItemTips args, int weight)
        {
            float height_1 = 0;
            float height_2 = 0;

            BagInfo bagInfo_2 = args.bagInfo;
            var path = ABPathHelper.GetUGUIPath("Main/ItemTips/UIEquipTips");
            GameObject bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);

            UI ui_1 = self.AddChild<UI, string, GameObject>( "UIEquipTips_1", UnityEngine.Object.Instantiate(bundleGameObject));
            self.UI_1 = ui_1;
            UIEquipTipsComponent UIPetInfoShow_1 = ui_1.AddComponent<UIEquipTipsComponent>();
            UIPetInfoShow_1.Img_back_btn.SetActive(false);
            UIPetInfoShow_1.InitData(bagInfo_1, ItemOperateEnum.None, 0, args.EquipList);
            height_1 = UIPetInfoShow_1.Img_back.GetComponent<RectTransform>().sizeDelta.y;

            UI ui_2 = null;
            if (bagInfo_2.IfJianDing == false)
            {
                ui_2 = self.AddChild<UI, string, GameObject>( "UIEquipTips_2", UnityEngine.Object.Instantiate(bundleGameObject));
                UIEquipTipsComponent UIPetInfoShow_2 = ui_2.AddComponent<UIEquipTipsComponent>();
                UIPetInfoShow_2.InitData(bagInfo_2, ItemOperateEnum.Bag, 0, args.EquipList);
                UIPetInfoShow_2.Img_back_btn.SetActive(false);
                height_2 = UIPetInfoShow_2.Img_back.GetComponent<RectTransform>().sizeDelta.y;
            }
            else
            {
                path = ABPathHelper.GetUGUIPath("Main/ItemTips/UIItemAppraisalTips");
                bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
                ui_2 = self.AddChild<UI, string, GameObject>( "UIEquipTips_2", UnityEngine.Object.Instantiate(bundleGameObject));
                UIItemAppraisalTipsComponent uIItemAppraisalTipsComponent = ui_2.AddComponent<UIItemAppraisalTipsComponent>();
                uIItemAppraisalTipsComponent.InitData(bagInfo_2, ItemOperateEnum.Bag);
                uIItemAppraisalTipsComponent.Imagebg.SetActive(false);
                height_2 = uIItemAppraisalTipsComponent.Img_back.GetComponent<RectTransform>().sizeDelta.y;
            }
            self.UI_2 = ui_2;
            height_1 *= 1f;
            height_2 *= 1f;

            UICommonHelper.SetParent(ui_1.GameObject, self.Tips1);
            UICommonHelper.SetParent(ui_2.GameObject, self.Tips2);
          
            Vector2 vectorPoint;
            RectTransform canvas = UIEventComponent.Instance.UILayers[(int)UILayer.Low].GetComponent<RectTransform>();
            Camera uiCamera = args.ZoneScene.GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, args.inputPoint, uiCamera, out vectorPoint);

            if (vectorPoint.x <= 0)
            {
                vectorPoint.x += (int)(weight * 0.5);
                //vectorPoint.x -= 50;
                vectorPoint.y = (height_2 - height_1) * 0.5f;
                self.Tips1.GetComponent<RectTransform>().anchoredPosition = vectorPoint;
                vectorPoint.x += weight;
                vectorPoint.y = 0;
                self.Tips2.GetComponent<RectTransform>().anchoredPosition = vectorPoint;
            }
            else
            {
                vectorPoint.x -= (int)(weight * 0.5);
                vectorPoint.y = 0f;
                self.Tips2.GetComponent<RectTransform>().anchoredPosition = vectorPoint;
                vectorPoint.x -= (20+ weight);
                vectorPoint.y = (height_2 - height_1) * 0.5f;
                vectorPoint.x -= 30;
                self.Tips1.GetComponent<RectTransform>().anchoredPosition = vectorPoint;
            }
        }
    }

}
