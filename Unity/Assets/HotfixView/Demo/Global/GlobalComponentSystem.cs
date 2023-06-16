using UnityEngine;

namespace ET
{

    public class GlobalComponentAwakeSystem: AwakeSystem<GlobalComponent>
    {
        public override void Awake(GlobalComponent self)
        {
            GlobalComponent.Instance = self;

            self.Global = GameObject.Find("/Global").transform;
            self.Unit = GameObject.Find("/Global/Unit").transform;
            self.UI = GameObject.Find("/Global/UI").transform;
            self.Pool = GameObject.Find("/Global/Pool").transform;

            self.UnitPlayer = new GameObject("UnitPlayer").transform;
            UICommonHelper.SetParent(self.UnitPlayer.gameObject, self.Unit.gameObject);

            self.UnitEffect = new GameObject("UnitEffect").transform;
            UICommonHelper.SetParent(self.UnitEffect.gameObject, self.Unit.gameObject);
        }
    }
}