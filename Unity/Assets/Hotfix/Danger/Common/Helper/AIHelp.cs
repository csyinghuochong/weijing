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

        public static Unit GetNearestEnemy(Unit main, float maxdis = 0f)
        {
            Unit nearest = null;
            float distance = -1f;
            List<Unit> units = main.GetParent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                Unit unit = units[i];
                if (unit.IsDisposed || main.Id == unit.Id)
                {
                    continue;
                }
                if (!main.IsCanAttackUnit(unit))
                {
                    continue;
                }
                float dd = PositionHelper.Distance2D(main, unit);
                if (maxdis > 0f && maxdis < dd)
                {
                    continue;
                }
                if (distance < 0f || dd < distance)
                {
                    nearest = unit;
                    distance = dd;
                }
            }
            return nearest;
        }

        public static List<Unit> GetEnemyMonsters(Unit main, Vector3 pos, float maxdis)
        {
            List<Unit> nearest = new List<Unit>();

            List<Unit> monsters = main.GetParent<UnitComponent>().GetAll();
            for (int i = 0; i < monsters.Count; i++)
            {
                Unit unit = monsters[i];
                AIComponent aIComponent = monsters[i].GetComponent<AIComponent>();
                if (aIComponent == null || unit.Type != UnitType.Monster)
                {
                    continue;
                }
                if (!main.IsCanAttackUnit(unit))
                {
                    continue;
                }
                if (Vector3.Distance(pos, unit.Position) > maxdis)
                {
                    continue;
                }
                nearest.Add(unit);  
            }
            return nearest;
        }

        public static List<Unit> GetNearestMonsters(Unit main, float maxdis)
        {
            List<Unit> nearest = new List<Unit>();
            List<Unit> units = main.GetParent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                Unit unit = units[i];
                if (unit.IsDisposed || main.Id == unit.Id || unit.Type!=UnitType.Monster)
                {
                    continue;
                }
                if (!main.IsCanAttackUnit(unit))
                {
                    continue;
                }
                float dd = PositionHelper.Distance2D(main, unit);
                if (dd <= maxdis)
                {
                    nearest.Add(unit);  
                }
            }
            return nearest;
        }

        public static Unit GetNearestEnemyMonster(Unit main, float mindis, float maxdis)
        {
            Unit nearest = null;
            float distance = -1f;
            List<Unit> units = main.GetParent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                Unit unit = units[i];
                if (unit.IsDisposed || main.Id == unit.Id || unit.Type != UnitType.Monster)
                {
                    continue;
                }
                if (!main.IsCanAttackUnit(unit))
                {
                    continue;
                }
                float dd = PositionHelper.Distance2D(main, unit);
                if (dd < mindis || dd > maxdis)
                {
                    continue;
                }
                nearest = unit;
                distance = dd;
                break;
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
        /// <param name="main"></param>
        /// <param name="maxdis"></param>
        /// <param name="numberType"></param>
        /// <returns></returns>
        public static List<long> GetNearestEnemy(Unit main, float maxdis, int numberType)
        {
            List<long> unitIdList = new List<long>();
            List<EnemyUnitInfo> enemyUnitInfos = new List<EnemyUnitInfo>();
            List<Unit> units = main.GetParent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                Unit unit = units[i];
                if (unit.IsDisposed || main.Id == unit.Id)
                {
                    continue;
                }
                if (!main.IsCanAttackUnit(unit))
                {
                    continue;
                }
                float dd = PositionHelper.Distance2D(main, unit);
                if (dd < maxdis)
                {
                    enemyUnitInfos.Add(new EnemyUnitInfo() { Distacne = dd, UnitID = unit.Id });
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