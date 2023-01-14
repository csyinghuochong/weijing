using UnityEngine;

namespace ET
{
    public class UINewYearCollectionWordComponent : Entity, IAwake, IDestroy
    {
        public GameObject FriendNodeList;
    }

    [ObjectSystem]
    public class UINewYearCollectionWordComponentAwake : AwakeSystem<UINewYearCollectionWordComponent>
    {
        public override void Awake(UINewYearCollectionWordComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
            self.FriendNodeList = rc.Get<GameObject>("FriendNodeList");

            //self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI().Coroutine(); };
        }
    }

    public static class UINewYearCollectionWordComponentSystem
    { 
    }
}
