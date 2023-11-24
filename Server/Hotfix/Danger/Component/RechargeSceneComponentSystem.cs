namespace ET
{

    [ObjectSystem]
    public class RechargeSceneComponentAwake : AwakeSystem<RechargeSceneComponent>
    {
        public override void Awake(RechargeSceneComponent self)
        {
            Scene scene = self.DomainScene();
            Game.EventSystem.Publish(new EventType.RechargeScene() { DomainScene = scene });
        }
    }

    public static class RechargeSceneComponentSystem
    {
    }
}
