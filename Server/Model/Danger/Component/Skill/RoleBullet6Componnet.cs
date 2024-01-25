namespace ET
{
    public class RoleBullet6Componnet: Entity, IAwake, IDestroy
    {
        public long PassTime;
        public long BuffEndTime;
        public long BeginTime;
        public long DelayTime;
        public float DamageRange;
        public long Masterid;
        public SkillHandler SkillHandler;
        public BuffState BuffState;
        public long Timer;
        public int IsStop;
    }
}