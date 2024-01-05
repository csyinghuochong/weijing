namespace ET
{
    public class UIActivityV1TaskComponent: Entity, IAwake
    {
    }

    public class UIActivityV1TaskComponentAwake: AwakeSystem<UIActivityV1TaskComponent>
    {
        public override void Awake(UIActivityV1TaskComponent self)
        {
            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();
        }
    }

    public static class UIActivityV1TaskComponentSystem
    {
    }
}