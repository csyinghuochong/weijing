using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    /// <summary>
    /// 封印之地挑战花费道具页面UI
    /// </summary>
    public class UITowerOfSealCostComponent: Entity, IAwake
    {
        /// <summary>
        /// 关闭界面按钮
        /// </summary>
        public GameObject CloseBtn;

        /// <summary>
        /// 钻石挑战按钮
        /// </summary>
        public GameObject CostDiamondBtn;

        /// <summary>
        /// 凭证挑战按钮
        /// </summary>
        public GameObject CostTicketBtn;
    }

    public class UITowerOfSealCostComponentAwakeSystem: AwakeSystem<UITowerOfSealCostComponent>
    {
        public override void Awake(UITowerOfSealCostComponent self)
        {
            self.Awake();
        }
    }

    public static class UITowerOfSealCostComponentSystem
    {
        public static void Awake(this UITowerOfSealCostComponent self)
        {
            GameObject gameObject = self.GetParent<UI>().GameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.CloseBtn = rc.Get<GameObject>("CloseBtn");
            self.CostDiamondBtn = rc.Get<GameObject>("CostDiamondBtn");
            self.CostTicketBtn = rc.Get<GameObject>("CostTicketBtn");

            self.CloseBtn.GetComponent<Button>().onClick.AddListener(self.OnCloseBtn);
            self.CostDiamondBtn.GetComponent<Button>().onClick.AddListener(self.OnCostDiamondBtn);
            self.CostTicketBtn.GetComponent<Button>().onClick.AddListener(self.OnCostTicketBtn);
        }

        /// <summary>
        /// 关闭UI
        /// </summary>
        /// <param name="self"></param>
        public static void OnCloseBtn(this UITowerOfSealCostComponent self)
        {
            UIHelper.Remove(self.ZoneScene(), UIType.UITowerOfSealCost);
        }

        /// <summary>
        /// 消耗钻石挑战
        /// </summary>
        /// <param name="self"></param>
        public static void OnCostDiamondBtn(this UITowerOfSealCostComponent self)
        {
            // 客户端先判断一边道具数量是否足够
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(89);
            int needGold = int.Parse(globalValueConfig.Value);
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.Diamond < needGold)
            {
                FloatTipManager.Instance.ShowFloatTip("钻石数量不够");
                return;
            }

            // 摇骰子
            TowerOfSealHelpr.StartPlayDice(self.ZoneScene(), 0).Coroutine();

            // 隐藏开始挑战按钮
            UI uITowerOfSealMain = UIHelper.GetUI(self.ZoneScene(), UIType.UITowerOfSealMain);
            uITowerOfSealMain.GetComponent<UITowerOfSealMainComponent>().StartBtn.SetActive(false);

            self.OnCloseBtn();
        }

        /// <summary>
        /// 消耗凭证挑战
        /// </summary>
        /// <param name="self"></param>
        public static void OnCostTicketBtn(this UITowerOfSealCostComponent self)
        {
            // 客户端先判断一边道具数量是否足够
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(90);
            int itemConfigID = int.Parse(globalValueConfig.Value);
            long itemNum = self.ZoneScene().GetComponent<BagComponent>().GetItemNumber(itemConfigID);
            if (itemNum <= 0)
            {
                FloatTipManager.Instance.ShowFloatTip("凭证数量不够");
                return;
            }

            // 摇骰子
            TowerOfSealHelpr.StartPlayDice(self.ZoneScene(), 1).Coroutine();

            // 隐藏开始挑战按钮
            UI uITowerOfSealMain = UIHelper.GetUI(self.ZoneScene(), UIType.UITowerOfSealMain);
            uITowerOfSealMain.GetComponent<UITowerOfSealMainComponent>().StartBtn.SetActive(false);

            self.OnCloseBtn();
        }
    }
}