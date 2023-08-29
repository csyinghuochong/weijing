using UnityEngine;

namespace ET
{
    /// <summary>
    /// 封印之塔UI
    /// </summary>
    public class UITowerOfSealComponent: Entity, IAwake
    {
        /// <summary>
        /// 进入封印之塔按钮
        /// </summary>
        public GameObject Btn_Enter;
    }

    public class UITowerOfSealComponentAwkeSystem: AwakeSystem<UITowerOfSealComponent>
    {
        public override void Awake(UITowerOfSealComponent self)
        {
            self.Awake();
        }
    }

    public static class UITowerOfSealComponentSystem
    {
        public static void Awake(this UITowerOfSealComponent self)
        {
            GameObject gameObject = self.GetParent<UI>().GameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.Btn_Enter = rc.Get<GameObject>("Btn_Enter");
            ButtonHelp.AddListenerEx(self.Btn_Enter, () => { self.OnBtn_Enter().Coroutine(); });
        }

        /// <summary>
        /// 请求进入封印之地
        /// </summary>
        /// <param name="self"></param>
        public static async ETTask OnBtn_Enter(this UITowerOfSealComponent self)
        {
            Unit myUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            // 获取今日已经到达的封印之地的层数，如果没有则重置为0
            int finished = myUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.TowerOfSealFinished);
            // 判断是否到达100层
            if (finished >= 100)
            {
                FloatTipManager.Instance.ShowFloatTip("今日已经达到塔顶,请明天再来挑战哦!");
                return;
            }

            // 还未到达100层，可以继续闯塔
            int errorCode = await EnterFubenHelp.RequestTransfer(self.ZoneScene(), SceneTypeEnum.TowerOfSeal,
                BattleHelper.GetSceneIdByType(SceneTypeEnum.TowerOfSeal), 0, "0");
            if (errorCode == ErrorCode.ERR_Success)
            {
                UIHelper.Remove(self.ZoneScene(), UIType.UITowerOfSeal);
            }
        }
    }
}