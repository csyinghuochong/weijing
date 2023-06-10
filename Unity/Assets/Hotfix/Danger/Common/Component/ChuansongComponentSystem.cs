using UnityEngine;

namespace ET
{

    [ObjectSystem]
    public class ChuansongComponentAwakeSystem : AwakeSystem<ChuansongComponent>
    {
        public override void Awake(ChuansongComponent self)
        {
            self.PassTime = 0f;
            self.ChuanSongOpen = false;
        }
    }

#if !NOT_UNITY
    [ObjectSystem]
    public class ChuansongComponentUpdateSystem : UpdateSystem<ChuansongComponent>
    {
        public override void Update(ChuansongComponent self)
        {
            self.OnUpdate();
        }
    }

    public static class ChuansongComponentSystem
    {
        public static void OnUpdate(this ChuansongComponent self)
        {
            if (!self.ChuanSongOpen)
            {
                return;
            }

            Unit myUnit = UnitHelper.GetMyUnitFromZoneScene(self.ZoneScene());
            if (myUnit == null)
            {
                return;
            }
            self.PassTime += Time.deltaTime;
            if (self.PassTime <= 3f)
            {
                return;
            }

            Vector3 vector3 = self.GetParent<Unit>().Position;
            //检测目标是否在技能范围
            if (PositionHelper.Distance2D(vector3, myUnit.Position) > 1.5f)
            {
                return;
            }

            self.ChuanSongOpen = false;
            int transfer = self.GetParent<Unit>().ConfigId;
            EnterFubenHelp.RequestTransfer(self.ZoneScene(), (int)SceneTypeEnum.LocalDungeon,  0, 0, transfer.ToString()).Coroutine();
        }
    }
#endif
}
