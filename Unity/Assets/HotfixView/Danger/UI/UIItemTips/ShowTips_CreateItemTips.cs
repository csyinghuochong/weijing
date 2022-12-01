
using UnityEngine;

namespace ET
{

    public class ShowTips_CreateItemTips : AEventClass<EventType.ShowItemTips>
    {
        //创建道具的Tips
        protected override void Run(object args)
        {
            RunAsync(args as EventType.ShowItemTips).Coroutine();
        }

        private async ETTask RunAsync(EventType.ShowItemTips args)
        {
            int itemWidth = 462;
            ItemConfig itemConfig = ItemConfigCategory.Instance.Get(args.bagInfo.ItemID);
            if (args.itemOperateEnum == ItemOperateEnum.XiangQianBag)
            {
                if (itemConfig.ItemType == (int)ItemTypeEnum.PetHeXin)
                {
                    return;
                }
                if (args.bagInfo.IfJianDing)
                {
                    return;
                }
            }

            if (args.itemOperateEnum == ItemOperateEnum.Juese)
            {
                UI uirole = UIHelper.GetUI(args.ZoneScene, UIType.UIRole);
                UIRoleComponent roleComponent = uirole.GetComponent<UIRoleComponent>();
                bool rolegem = roleComponent.UIPageButton.CurrentIndex == (int)RolePageEnum.RoleGem;
                if (rolegem)
                {
                    uirole.GetComponent<UIRoleComponent>().OnClickXiangQianItem(args.bagInfo);
                    return;
                }
            }
            if (args.itemOperateEnum == ItemOperateEnum.XiangQianBag
                && itemConfig.ItemType == (int)ItemTypeEnum.Equipment)
            {
                UI uirole = UIHelper.GetUI(args.ZoneScene, UIType.UIRole);
                uirole.GetComponent<UIRoleComponent>().OnClickXiangQianItem(args.bagInfo);
                return;
            }

            if (itemConfig.ItemType == (int)ItemTypeEnum.Equipment)
            {
                BagInfo haveEquip = args.ZoneScene.GetComponent<BagComponent>().GetEquipBySubType(itemConfig.ItemSubType);

                UI uI = await UIHelper.Create(args.ZoneScene, UIType.UIEquipDuiBiTips);
                if (haveEquip != null && args.itemOperateEnum == ItemOperateEnum.Bag)
                {
                    uI.GetComponent<UIEquipDuiBiTipsComponent>().OnUpdateDuiBiUI(haveEquip, args, itemWidth).Coroutine();
                }
                else if (args.bagInfo.IfJianDing == false)
                {
                    //鉴定后或无需鉴定的
                    uI.GetComponent<UIEquipDuiBiTipsComponent>().OnUpdateEquipUI(args).Coroutine();
                    uI.GetComponent<UIEquipDuiBiTipsComponent>().Tips1.GetComponent<RectTransform>().anchoredPosition = ReturnX(args, itemWidth);
                }
                else
                {
                    //显示未鉴定
                    uI.GetComponent<UIEquipDuiBiTipsComponent>().OnUpdateAppraisalUI(args).Coroutine();
                    uI.GetComponent<UIEquipDuiBiTipsComponent>().Tips1.GetComponent<RectTransform>().anchoredPosition = ReturnX(args, itemWidth);
                }
            }
            else
            {
                UI uiitemtips = await UIHelper.Create(args.ZoneScene, UIType.UIItemTips);
                uiitemtips.GameObject.GetComponent<RectTransform>().anchoredPosition = ReturnX(args, itemWidth);
                uiitemtips.GetComponent<UIItemTipsComponent>().InitData(args.bagInfo, args.itemOperateEnum);
            }
        }

        public Vector2 ReturnX(EventType.ShowItemTips args, float weight)
        {
            Vector2 vectorPoint;
            RectTransform canvas = UIEventComponent.Instance.UILayers[(int)UILayer.Low].GetComponent<RectTransform>();
            Camera uiCamera = args.ZoneScene.GetComponent<UIComponent>().UICamera;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas, args.inputPoint, uiCamera, out vectorPoint);

            if (vectorPoint.x <= 0)
            {
                vectorPoint.x += (int)(weight * 0.5 + 50f);
            }
            else
            {
                vectorPoint.x -= (int)(weight * 0.5 + 50f);
            }
            vectorPoint.y = 0f;
            return vectorPoint;
        }

    }
}
