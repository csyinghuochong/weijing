using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace ET
{
    public class UITiaoZhanComponent : Entity, IAwake<GameObject>
    {
        public GameObject TextTip;
    }

    [ObjectSystem]
    public class UITiaoZhanComponentAwakeSystem : AwakeSystem<UITiaoZhanComponent, GameObject>
    {
        public override void Awake(UITiaoZhanComponent self, GameObject go)
        {
            ReferenceCollector rc = go.GetComponent<ReferenceCollector>();
            self.TextTip = rc.Get<GameObject>("TextTip");

            self.OnUpdateUI(10001);
        }
    }

    public static class UITiaoZhanComponentSystem
    {
        public static void OnUpdateUI(this UITiaoZhanComponent self,int towerId)
        {
            self.TextTip.GetComponent<Text>().text = "挑战之地：" + TowerConfigCategory.Instance.Get(towerId).CengNum + "/" + "30";
        }
    }
}
