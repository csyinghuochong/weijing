namespace ET
{

    public static class BehaviourType
    {
        public const int Behaviour_Stroll = 1;              //闲逛
        public const int Behaviour_Task = 2;                //任务
        public const int Behaviour_ZhuiJi = 3;              //追击
        public const int Behaviour_Attack = 4;              //攻击
        public const int Behaviour_Battle = 5;              //战场
        public const int Behaviour_TeamDungeon = 6;         //组队
        public const int Behaviour_Target = 7;
        public const int Behaviour_YeWaiBoss = 8;
        public const int Behaviour_Arena = 9;
        public const int Behaviour_Solo = 10;   
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
