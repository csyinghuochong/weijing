namespace ET
{
    public class SingingComponent : Entity, IAwake,IDestroy
    {

        public long Timer;

        public int Type = 0;
        public long PassTime;
        public long TotalTime;

        public C2M_SkillCmd c2M_SkillCmd = new C2M_SkillCmd();

       
    }
}
