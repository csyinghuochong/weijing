using ET;

namespace ET
{

    [ObjectSystem]
    public class DropComponentAwakeSystem : AwakeSystem<DropComponent>
    {
        public override void Awake(DropComponent self)
        {
            self.Awake();
        }
    }

    public static class DropComponentSystem
    {

        public static void Awake(this DropComponent self)
        {
        }

        public static void SetItemInfo(this DropComponent self, int itemid, int itemnum)
        {
            self.ItemID = itemid;
            self.ItemNum = itemnum;
        }
    }
}
