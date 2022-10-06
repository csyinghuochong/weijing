
using System.Collections.Generic;

namespace ET
{

    public class ItemStarInfo
    {
        public int ItemId;
        public int Star;
        public int Chapter;
    }

    public class ShouJiChapterInfoComponent : Entity, IAwake, ILoad, IDestroy
    {
        public static ShouJiChapterInfoComponent Instance;
        public List<ItemStarInfo> ItemStarInfos = new List<ItemStarInfo>();
    }
}
