namespace ET
{

    public static class BehaviourType
    {
        public const int Behaviour_Task = 1;
        public const int Behaviour_Stroll = 2;
        public const int Behaviour_ZhuiJi = 3;
        public const int Behaviour_Attack = 4;
        public const int Behaviour_Battle = 5;
        public const int Behaviour_TeamDungeon = 6;
    }

    public class BehaviourHandlerAttribute : BaseAttribute
    {

    }

    [BehaviourHandler]
    public abstract class BehaviourHandler
    {
        // 检查是否满足条件
        public abstract bool Check(BehaviourComponent aiComponent, AIConfig aiConfig);

        // 协程编写必须可以取消
        public abstract ETTask Execute(BehaviourComponent aiComponent, AIConfig aiConfig, ETCancellationToken cancellationToken);

        public abstract int BehaviourId();
    }
}
