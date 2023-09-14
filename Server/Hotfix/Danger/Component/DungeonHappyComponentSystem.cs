using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
   
    [ObjectSystem]
    public class DungeonHappyComponentAwake : AwakeSystem<DungeonHappyComponent>
    {
        public override void Awake(DungeonHappyComponent self)
        {
            //先刷新一次
            self.OnTimer();
        }
    }

    public static class DungeonHappyComponentSystem
    {
        public static int GetDropId(this DungeonHappyComponent self, int openDay)
        {
            string dropinfo = GlobalValueConfigCategory.Instance.Get(102).Value;
            string[] dropList = dropinfo.Split('@');

            for (int i = dropList.Length - 1; i >= 0; i--)
            {
                string[] dropitem = dropList[i].Split(';');
                int day = int.Parse(dropitem[0]);
                int dropid = int.Parse((dropitem[1]));

                if (openDay >= day)
                {
                    return dropid;
                }
            }
            return int.Parse(dropList[0].Split(';')[1]);
        }

        public static void OnTimer(this DungeonHappyComponent self)
        {
            List<int> dropcells = new List<int>();
            List<Unit> droplist = UnitHelper.GetUnitList(self.DomainScene(), UnitType.DropItem);
            for (int i = 0; i < droplist.Count; i++)
            {
                int dropindex = droplist[i].GetComponent<DropComponent>().CellIndex;
                if (!dropcells.Contains(dropindex))
                {
                    dropcells.Add(dropindex);
                }
            }

            int openDay = ServerHelper.GetOpenServerDay(false, self.DomainZone());
            int dropid = self.GetDropId(openDay);

            for (int p = 0; p < HappyHelper.PositionList.Count; p++)
            {
                //空格子的概率
                if (RandomHelper.RandFloat01() < 0.3f)
                {
                    continue;
                }
                //该格子有道具
                if (dropcells.Contains(p + 1))
                {
                    continue;
                }

                List<RewardItem> rewardist = new List<RewardItem>();
                DropHelper.DropIDToDropItem(dropid, rewardist);

                for (int i = 0; i < rewardist.Count; i++)
                {
                    UnitComponent unitComponent = self.DomainScene().GetComponent<UnitComponent>();
                    Unit dropitem = unitComponent.AddChildWithId<Unit, int>(IdGenerater.Instance.GenerateId(), 1);
                    unitComponent.Add(dropitem);
                    dropitem.AddComponent<UnitInfoComponent>();
                    dropitem.Type = UnitType.DropItem;
                    DropComponent dropComponent = dropitem.AddComponent<DropComponent>();
                    dropComponent.SetItemInfo(rewardist[i].ItemID, rewardist[i].ItemNum);
                    dropComponent.CellIndex = p + 1;

                    Vector3 vector3 = HappyHelper.PositionList[p];
                    dropitem.Position = vector3;
                    dropitem.AddComponent<AOIEntity, int, Vector3>(2 * 1000, dropitem.Position);
                    dropComponent.DropType = 0;
                }
            }
        }
    }
}
