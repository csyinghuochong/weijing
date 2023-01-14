using ET;

namespace ET
{

    [ObjectSystem]
    public class DropComponentAwakeSystem : AwakeSystem<DropComponent>
    {
        public override void Awake(DropComponent self)
        {
            self.OwnerId = 0;   
            self.ProtectTime = 0;
#if SERVER
            self.BeAttackPlayerList.Clear();
#endif
        }
    }

    public static class DropComponentSystem
    {
        public static void SetItemInfo(this DropComponent self, int itemid, int itemnum)
        {
            self.ItemID = itemid;
            self.ItemNum = itemnum;
        }
    }
}
