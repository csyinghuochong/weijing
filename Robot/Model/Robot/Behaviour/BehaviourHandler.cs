namespace ET
{

    public static class BehaviourType
    {
        public const string Behaviour_Task = "Behaviour_Task";
        public const string Behaviour_Stroll = "Behaviour_Stroll";
        public const string Behaviour_ZhuiJi = "Behaviour_ZhuiJi";
        public const string Behaviour_Attack = "Behaviour_Attack";
        public const string Behaviour_TeamDungeon = "Behaviour_TeamDungeon";
    }

    public class BehaviourHandlerAttribute : BaseAttribute
    {

    }

    [BehaviourHandler]
    public abstract class BehaviourHandler
    {
        // 检查是否满足条件
        public abstract int Check(BehaviourComponent aiComponent, AIConfig aiConfig);

        // 协程编写必须可以取消
        public abstract ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken);

        public abstract string BehaviourId();
    }
}
