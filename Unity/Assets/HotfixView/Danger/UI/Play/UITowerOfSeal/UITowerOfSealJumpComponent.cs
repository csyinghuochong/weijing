using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITowerOfSealJumpComponent: Entity, IAwake
    {
        public GameObject YesBtn;
        public GameObject NoBtn;
        public GameObject TipText;

        public int Finished;
        public int DiceResult;
        public int CostType; // 10之前花钻石 11之前花门票
    }

    public class UITowerOfSealJumpComponentAwakeSystem: AwakeSystem<UITowerOfSealJumpComponent>
    {
        public override void Awake(UITowerOfSealJumpComponent self)
        {
            self.Awake();
        }
    }

    public static class UITowerOfSealJumpComponentSystem
    {
        public static void Awake(this UITowerOfSealJumpComponent self)
        {
            GameObject gameObject = self.GetParent<UI>().GameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.YesBtn = rc.Get<GameObject>("YesBtn");
            self.NoBtn = rc.Get<GameObject>("NoBtn");
            self.TipText = rc.Get<GameObject>("TipText");

            self.YesBtn.GetComponent<Button>().onClick.AddListener(() => self.OnYesBtn().Coroutine());
            self.NoBtn.GetComponent<Button>().onClick.AddListener(() => self.OnNoBtn().Coroutine());
        }

        public static void InitUI(this UITowerOfSealJumpComponent self, int diceResult , int costType)
        {
            self.DiceResult = diceResult;
            self.CostType = costType;

            Unit myUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            self.Finished = myUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.TowerOfSealFinished);
            self.TipText.GetComponent<Text>().text = $"是否花费350钻石去到第{(self.Finished + diceResult) / 10 * 10}层";
        }

        public static async ETTask OnYesBtn(this UITowerOfSealJumpComponent self)
        {
            // 客户端先判断一边道具数量是否足够
            int needGold;
            if (self.CostType == 0) 
            {
                GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(89);
                needGold = int.Parse(globalValueConfig.Value) + 350;
            }
            else
            {
                needGold = 350;
            }
            UserInfoComponent userInfoComponent = self.ZoneScene().GetComponent<UserInfoComponent>();
            if (userInfoComponent.UserInfo.Diamond < needGold)
            {
                FloatTipManager.Instance.ShowFloatTip("钻石数量不够");
                self.OnNoBtn().Coroutine();
                return;
            }

            M2C_TowerOfSealNextResponse m2CTowerOfSealNextResponse = (M2C_TowerOfSealNextResponse)await self.ZoneScene()
                    .GetComponent<SessionComponent>().Session
                    .Call(new C2M_TowerOfSealNextRequest() { DiceResult = 10 - self.Finished % 10, CostType = 10 + self.CostType });
            if (m2CTowerOfSealNextResponse.Error != ErrorCode.ERR_Success)
            {
                FloatTipManager.Instance.ShowFloatTip("操作错误！！");
                return;
            }

            // 更新面板信息
            UI uITowerOfSealMain = UIHelper.GetUI(self.ZoneScene(), UIType.UITowerOfSealMain);
            uITowerOfSealMain.GetComponent<UITowerOfSealMainComponent>().UpdateInfo();

            UIHelper.Remove(self.ZoneScene(), UIType.UITowerOfSealJump);
            await ETTask.CompletedTask;
        }

        public static async ETTask OnNoBtn(this UITowerOfSealJumpComponent self)
        {
            M2C_TowerOfSealNextResponse m2CTowerOfSealNextResponse = (M2C_TowerOfSealNextResponse)await self.ZoneScene()
                    .GetComponent<SessionComponent>().Session
                    .Call(new C2M_TowerOfSealNextRequest() { DiceResult = self.DiceResult, CostType = self.CostType });
            if (m2CTowerOfSealNextResponse.Error != ErrorCode.ERR_Success)
            {
                FloatTipManager.Instance.ShowFloatTip("操作错误！！");
                return;
            }

            // 更新面板信息
            UI uITowerOfSealMain = UIHelper.GetUI(self.ZoneScene(), UIType.UITowerOfSealMain);
            uITowerOfSealMain.GetComponent<UITowerOfSealMainComponent>().UpdateInfo();

            UIHelper.Remove(self.ZoneScene(), UIType.UITowerOfSealJump);
            await ETTask.CompletedTask;
        }
    }
}