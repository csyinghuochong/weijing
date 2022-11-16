using System;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class AIHelp
    {

        //己方位置
        public static readonly List<Vector3> Formation_1 = new List<Vector3>()
        {
            new Vector3(-1.88f, 0f, -15.33f),
            new Vector3(-1.88f, 0f, -12.16f),
            new Vector3(-1.88f, 0f, -9.11f),
            new Vector3(1.17f, 0f, -15.33f),
            new Vector3(1.17f, 0f, -12.16f),
            new Vector3(1.17f, 0f, -9.11f),
            new Vector3(4.28f, 0f, -15.33f),
            new Vector3(4.28f, 0f, -12.16f),
            new Vector3(4.28f, 0f, -9.11f),
        };

        //对方位置
        public static readonly List<Vector3> Formation_2 = new List<Vector3>()
        {
            new Vector3(-1.88f, 0f, 9.87f),
            new Vector3(1.17f, 0f, 9.87f),
            new Vector3(4.28f, 0f, 9.87f),
            new Vector3(-1.88f, 0f, 13.09f),
            new Vector3(1.17f, 0f, 13.09f),
            new Vector3(4.28f, 0f, 13.09f),
            new Vector3(-1.88f, 0f,16.14f),
            new Vector3(1.17f, 0f, 16.14f),
            new Vector3(4.28f, 0f, 16.14f),
        };

        //摄像机位置
        public static readonly Vector3 FuBenCameraPosition = new Vector3(14, 22f, 0f);
        public static readonly Quaternion FuBenCameraRotation = Quaternion.Euler(60f, -90f, 0);
        //拖动位置
        public static readonly float FuBenCameraPositionMin_X = -50f;
        public static readonly float FuBenCameraPositionMax_X = 50f;
        public static readonly float FuBenCameraPositionMin_Z = -50f;
        public static readonly float FuBenCameraPositionMax_Z = 50f;

        public static Unit GetNearestEnemy(Unit unit, float maxdis = 0f)
        {
            Unit nearest = null;
            float distance = -1f;
            List<Unit> units = unit.GetParent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                Unit uu = units[i];
                if (uu.IsDisposed || unit.Id == uu.Id)
                {
                    continue;
                }
                if (!uu.IsCanBeAttackByUnit(unit))
                {
                    continue;
                }
                float dd = PositionHelper.Distance2D(unit, uu);
                if (maxdis > 0f && maxdis < dd)
                {
                    continue;
                }
                if (distance < 0f || dd < distance)
                {
                    nearest = uu;
                    distance = dd;
                }
            }
            return nearest;
        }

        public struct EnemyUnitInfo
        {
            public float Distacne;
            public long UnitID;

            public EnemyUnitInfo(float dis, long unitid)
            {
                this.Distacne = dis;
                this.UnitID = unitid;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="unit"></param>
        /// <param name="maxdis"></param>
        /// <param name="numberType"></param>
        /// <returns></returns>
        public static List<long> GetNearestEnemy(Unit unit, float maxdis, int numberType)
        {
            List<long> unitIdList = new List<long>();
            List<EnemyUnitInfo> enemyUnitInfos = new List<EnemyUnitInfo>();
            List<Unit> units = unit.GetParent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                Unit uu = units[i];
                if (uu.IsDisposed || unit.Id == uu.Id)
                {
                    continue;
                }
                if (!uu.IsCanBeAttackByUnit(unit))
                {
                    continue;
                }
                float dd = PositionHelper.Distance2D(unit, uu);
                if (dd < maxdis)
                {
                    enemyUnitInfos.Add(new EnemyUnitInfo() { Distacne = dd, UnitID = uu.Id });
                }
            }
            if (enemyUnitInfos.Count == 0)
            {
                return unitIdList;
            }

            enemyUnitInfos.Sort(delegate (EnemyUnitInfo a, EnemyUnitInfo b)
            {
                return (int)(b.Distacne - a.Distacne);
            });
            switch (numberType)
            {
                case 1:
                    unitIdList.Add(enemyUnitInfos[RandomHelper.RandomNumber(0, enemyUnitInfos.Count)].UnitID);
                    break;
                case 2:
                    unitIdList.Add(enemyUnitInfos[0].UnitID);
                    break;
                case 3:
                    unitIdList.Add(enemyUnitInfos[enemyUnitInfos.Count - 1].UnitID);
                    break;
                case 21:
                    int number = enemyUnitInfos.Count >= 2 ? 2 : enemyUnitInfos.Count;
                    int[] index = RandomHelper.GetRandoms(number, 0, enemyUnitInfos.Count);
                    for (int i= 0; i < index.Length; i++)
                    {
                        unitIdList.Add(enemyUnitInfos[index[i]].UnitID);
                    }
                    break;
                case 101:
                    for (int i = 0; i < enemyUnitInfos.Count; i++)
                    {
                        unitIdList.Add(enemyUnitInfos[i].UnitID);
                    }
                    break;
            }

            return unitIdList;
        }

        public static Unit GetNearestUnit(Unit unit, float maxdis, List<long> ids, long mainId)
        {
            Unit nearest = null;
            float distance = maxdis;
            List<Unit> units = unit.GetParent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                Unit uu = units[i];
                if (uu.Id == unit.Id || uu.Id == mainId || ids.Contains(uu.Id))
                {
                    continue;
                }
                if (!uu.IsCanBeAttack())
                {
                    continue;
                }
                float dd = PositionHelper.Distance2D(unit, uu);
                if (dd < maxdis && dd < distance)
                {
                    nearest = uu;
                    distance = dd;
                }
            }
            return nearest;
        }
    }
}