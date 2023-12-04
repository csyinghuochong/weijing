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


        /// <summary>
        /// 每个格子对应的搜索顺序
        /// </summary>

        public static readonly List<int>[] PetPositionAttack = new List<int>[]
        {
            new List<int>(){  0, 1, 2, 3, 4, 5, 6, 7, 8   },
            new List<int>(){ 1, 3, 4, 5, 6, 7, 8, 0, 1  },
            new List<int>(){ 3, 4, 5, 6, 7, 8, 0, 1, 2  },
            new List<int>(){ 4, 5, 6, 7, 8, 0, 1, 2, 3  },
            new List<int>(){ 5, 6, 7, 8, 0, 1, 2, 3, 4  },
            new List<int>(){ 6, 7, 8, 0, 1, 2, 3, 4, 5  },
            new List<int>(){ 7, 8, 0, 1, 2, 3, 4, 5, 6 },
            new List<int>(){ 8, 0, 1, 2, 3, 4, 5, 6, 7},
            new List<int>(){ 0, 1, 2, 3, 4, 5, 6, 7, 8 }
        };

        //摄像机位置
        public static readonly Vector3 FuBenCameraPosition = new Vector3(14, 22f, 0f);
        public static readonly Quaternion FuBenCameraRotation = Quaternion.Euler(60f, -90f, 0);
        //拖动位置
        public static readonly float FuBenCameraPositionMin_X = -50f;
        public static readonly float FuBenCameraPositionMax_X = 50f;
        public static readonly float FuBenCameraPositionMin_Z = -50f;
        public static readonly float FuBenCameraPositionMax_Z = 50f;

        public static Unit GetNearestEnemy_Client(Unit main, float maxdis)
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
                float dd = PositionHelper.Distance2D(main, unit);
                if (dd > maxdis || !main.IsCanAttackUnit(unit))
                {
                    continue;
                }

                //找到目标直接跳出来
                if (dd < distance || distance < 0f)
                {
                    distance = dd;
                    nearest = unit;
                }
            }
            return nearest;
        }

        /// <summary>
        /// 宠物副本，对位攻击。寻找对面的格子
        /// </summary>
        /// <param name="main"></param>
        /// <returns></returns>
        public static Unit GetNearestCell(Unit main)
        {
            int selfCell = main.GetComponent<NumericComponent>().GetAsInt(NumericType.UnitPositon);

            ////对位攻击顺序
            List<int> postionAttack = PetPositionAttack[selfCell];

            Unit[] enemyUnit = new Unit[9];
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

                int position = unit.GetComponent<NumericComponent>().GetAsInt(NumericType.UnitPositon);
                enemyUnit[position] = unit; 
            }

            for (int i = 0; i < postionAttack.Count; i++)
            {
                Unit enemy = enemyUnit[postionAttack[i]];
                if (enemy != null)
                {
                    return enemy;
                }
            }

            return null;
        }

        /// <summary>
        /// 服务器使用。不需要找最近的
        /// </summary>
        /// <param name="main"></param>
        /// <param name="maxdis"></param>
        /// <param name="isMini">是否要最小距离</param>
        /// <returns></returns>
        public static Unit GetNearestEnemy(Unit main, float maxdis , bool isMini = false)
        {
            Unit nearest = null;
            float minDistance = maxdis;
            List<Unit> units = main.GetParent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                Unit unit = units[i];
                if (unit.IsDisposed || main.Id == unit.Id)
                {
                    continue;
                }
                float dd = PositionHelper.Distance2D(main, unit);
                if (dd > maxdis ||  !main.IsCanAttackUnit(unit))
                {
                    continue;
                }

                if (!isMini)
                {
                    //找到目标直接跳出来
                    nearest = unit;
                    break;
                }

                if (dd < minDistance)
                {
                    minDistance = dd;
                    nearest = unit;
                }
            }

            return nearest;
        }


        public static Unit GetNearestEnemyByPosition(Unit main, Vector3 position, float maxdis)
        {
            Unit nearest = null;
            float minDistance = maxdis;
            List<Unit> units = main.GetParent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                Unit unit = units[i];
                if (unit.IsDisposed || main.Id == unit.Id)
                {
                    continue;
                }
                float dd = Vector3.Distance(position, unit.Position);
                if (dd > maxdis || !main.IsCanAttackUnit(unit))
                {
                    continue;
                }

                if (dd < minDistance)
                {
                    minDistance = dd;
                    nearest = unit;
                }
            }

            return nearest;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="main"></param>
        /// <param name="maxdis"></param>
        /// <param name="numberType"></param>
        /// <returns></returns>
        public static List<long> GetNearestEnemyByNumber(Unit main, float maxdis, int number)
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

                float dd = PositionHelper.Distance2D(main, unit);
                if (dd > maxdis)
                {
                    continue;
                }
                if (!main.IsCanAttackUnit(unit))
                {
                    continue;
                }

                enemyUnitInfos.Add(new EnemyUnitInfo() { Distacne = dd, UnitID = unit.Id });
            }
            if (enemyUnitInfos.Count == 0)
            {
                return unitIdList;
            }

            enemyUnitInfos.Sort(delegate (EnemyUnitInfo a, EnemyUnitInfo b)
            {
                return (int)(b.Distacne - a.Distacne);
            });

            number = enemyUnitInfos.Count >= number ? number : enemyUnitInfos.Count;
            int[] index = RandomHelper.GetRandoms(number, 0, enemyUnitInfos.Count);
            for (int i = 0; i < index.Length; i++)
            {
                unitIdList.Add(enemyUnitInfos[index[i]].UnitID);
            }

            return unitIdList;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="main"></param>
        /// <param name="maxdis"></param>
        /// <param name="numberType"></param>
        /// <returns></returns>
        public static List<long> GetNearestEnemyIds(Unit main, float maxdis, int numberType)
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

                float dd = PositionHelper.Distance2D(main, unit);
                if (dd > maxdis)
                {
                    continue;
                }
                if (!main.IsCanAttackUnit(unit))
                {
                    continue;
                }

                enemyUnitInfos.Add(new EnemyUnitInfo() { Distacne = dd, UnitID = unit.Id });
            }
            if (enemyUnitInfos.Count == 0)
            {
                return unitIdList;
            }

            enemyUnitInfos.Sort(delegate (EnemyUnitInfo a, EnemyUnitInfo b)
            {
                return (int)(a.Distacne - b.Distacne);
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
                    for (int i = 0; i < index.Length; i++)
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
                default:
                    if (enemyUnitInfos.Count > 0)
                    {
                        unitIdList.Add(enemyUnitInfos[0].UnitID);
                    }
                    break;
            }

            return unitIdList;
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
                
                if (Vector3.Distance(pos, unit.Position) > maxdis)
                {
                    continue;
                }
                if (!main.IsCanAttackUnit(unit))
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
                
                float dd = PositionHelper.Distance2D(main, unit);
                if (dd > maxdis)
                {
                    continue;
                }
                if (!main.IsCanAttackUnit(unit))
                {
                    continue;
                }

                nearest.Add(unit);
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