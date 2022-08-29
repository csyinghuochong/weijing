namespace ET
{
    public class DropComponent : Entity, IAwake
    {
        public int ItemID;
        public int ItemNum;
        public int DropType;  //0 公共掉落    1私人掉落

#if !SERVER
        public DropInfo DropInfo;
#endif
    }
}
