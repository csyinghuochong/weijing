using System;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UITowerOfSealMainComponent: Entity, IAwake, IDestroy
    {
        /// <summary>
        /// 开始挑战按钮
        /// </summary>
        public GameObject StartBtn;

        /// <summary>
        /// 当前关卡层数
        /// </summary>
        public GameObject LevelNumText;
    }

    public class UITowerOfSealMainComponentAwakeSystem: AwakeSystem<UITowerOfSealMainComponent>
    {
        public override void Awake(UITowerOfSealMainComponent self)
        {
            self.Awake();
        }
    }

    public class UITowerOfSealMainComponentDestroySystem: DestroySystem<UITowerOfSealMainComponent>
    {
        public override void Destroy(UITowerOfSealMainComponent self)
        {
            self.Destroy();
        }
    }

    public static class UITowerOfSealMainComponentSystem
    {
        public static void Awake(this UITowerOfSealMainComponent self)
        {
            GameObject gameObject = self.GetParent<UI>().GameObject;
            ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();

            self.StartBtn = rc.Get<GameObject>("StartBtn");
            self.LevelNumText = rc.Get<GameObject>("LevelNumText");

            self.StartBtn.GetComponent<Button>().onClick.AddListener(self.OnStartBtn);
            self.UpdateInfo();
        }

        /// <summary>
        /// 更新UI信息
        /// </summary>
        /// <param name="self"></param>
        public static void UpdateInfo(this UITowerOfSealMainComponent self)
        {
            self.LevelNumText.GetComponent<Text>().text = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>()
                    .GetAsInt(NumericType.TowerOfSealArrived).ToString();
        }

        /// <summary>
        /// 开始挑战
        /// </summary>
        /// <param name="self"></param>
        public static void OnStartBtn(this UITowerOfSealMainComponent self)
        {
            NumericComponent numericComponent = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene()).GetComponent<NumericComponent>();

            // 如果已经通关塔顶
            if (numericComponent.GetAsInt(NumericType.TowerOfSealFinished) >= 100)
            {
                FloatTipManager.Instance.ShowFloatTip("已经通关塔顶，请明日再来挑战!");
                return;
            }

            // 如果该层的Boss未击败
            if (numericComponent.GetAsInt(NumericType.TowerOfSealArrived) > numericComponent.GetAsInt(NumericType.TowerOfSealFinished))
            {
                FloatTipManager.Instance.ShowFloatTip("该层boss并未击败，请击败本次boss再继续挑战!!!");
                return;
            }

            // 打开花费道具继续挑战UI
            UIHelper.Create(self.ZoneScene(), UIType.UITowerOfSealCost).Coroutine();
        }

        public static void Destroy(this UITowerOfSealMainComponent self)
        {
        }
    }
}