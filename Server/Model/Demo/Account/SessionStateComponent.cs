namespace ET
{
    public enum SessionState
    {
        Normal,     //C2G_LoginGameGate
        Game        //C2G_EnterGame
    }

    public class SessionStateComponent : Entity, IAwake
    {
        public SessionState State;
    }
}