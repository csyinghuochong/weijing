using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    public class UICountryChestComponent : Entity, IAwake
    {

    }


    public class UICountryChestComponenttAwakeSystem : AwakeSystem<UICountryChestComponent>
    {

        public override void Awake(UICountryChestComponent self)
        {
            //ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
        }
    }

    public static class UICountryChestComponentSystem
    {


    }
}
