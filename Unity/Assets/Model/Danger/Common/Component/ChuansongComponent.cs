
namespace ET
{
    public class ChuansongComponent : Entity, IAwake, IUpdate
    {

        public int CellIndex;
        public bool Triggered;
        public int DirectionType;
        public float PassTime;
        public bool ChuanSongOpen;

        //初始在能量圈
        public bool InitInCircle;
    }
}
