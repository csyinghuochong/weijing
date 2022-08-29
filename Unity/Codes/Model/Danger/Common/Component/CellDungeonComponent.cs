using System.Collections.Generic;

namespace ET
{

    public static class CellDungeonNpc
    {
        public const int HuiFuItem = 1;
        public const int ShenMiNpc = 2;
        public const int ChestList = 3;
        public const int MoLengRoom = 4;
    }

    public enum CellDungeonStatu : byte
    {
        None = 0,
        Start,          //起点                
        End,            //终点
        Passable,       //可以通行
        Impassable      //不可通行
    }

    public enum DirectionType : byte
    {
        None,
        Up,
        Left,
        Down,
        Right
    }

    public class CellDungeonInfo
    {
        public int row;         //行
        public int line;        //列
        public int sonid;       //随机地块
        public byte ctype;      //格子属性
        public bool pass;       //是否通关
    }

    /// <summary>
    /// 副本组件
    /// </summary>
    public class CellDungeonComponent : Entity, IAwake
    {
        public int ChapterId;
        public long EnterTime;
        public long HurtValue;
        public ChapterConfig ChapterConfig;
        public int FubenDifficulty;
      
        public FubenInfo FubenInfo = new FubenInfo();
        public SonFubenInfo SonFubenInfo = new SonFubenInfo();

        public CellDungeonInfo[][] FubenCellInfoList;
#if SERVER
        //神秘商品
        public List<MysteryItemInfo> MysteryItemInfos = new List<MysteryItemInfo>();
        public CellDungeonInfo CurrentFubenCell;
        public Unit MainUnit;   //队长
#endif
    }
}
