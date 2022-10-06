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
            self.InitInCircle = true;
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
            Vector3 vector3 = self.GetParent<Unit>().Position;
            if (self.InitInCircle && PositionHelper.Distance2D(vector3, myUnit.Position) > 1.2f)
            {
                self.InitInCircle = false;
            }

            self.PassTime += Time.deltaTime;
            if (self.PassTime <= 3f)
                return;

            if (self.InitInCircle)
                return;

            //检测目标是否在技能范围
            if (PositionHelper.Distance2D(vector3, myUnit.Position) > 1.5f)
            {
               return;
            }
            self.ChuanSongOpen = false;

            //EnterFubenHelp.EnterSonFubenRequest(self.ZoneScene(), self.CellIndex, self.DirectionType).Coroutine();
            int transfer = self.GetParent<Unit>().GetComponent<UnitInfoComponent>().UnitCondigID;
            EnterFubenHelp.RequestTransfer(self.ZoneScene(), (int)SceneTypeEnum.LocalDungeon,  0, transfer).Coroutine();
        }
    }
#endif
}
