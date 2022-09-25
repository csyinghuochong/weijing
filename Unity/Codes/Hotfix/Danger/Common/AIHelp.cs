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
                if (unit.Id == uu.Id)
                    continue;
                if (!uu.GetComponent<UnitInfoComponent>().IsCanBeAttackByUnit(unit))
                    continue;
                float dd = PositionHelper.Distance2D(unit, uu);
                if (distance < 0f || dd < distance)
                {
                    nearest = uu;
                    distance = dd;
                }
            }
            return nearest;
        }

        public static Unit GetNearestUnit(Unit unit, float maxdis, List<long> ids, long mainId)
        {
            Unit nearest = null;
            float distance = maxdis;
            List<Unit> units = unit.GetParent<UnitComponent>().GetAll();
            for (int i = 0; i < units.Count; i++)
            {
                Unit uu = units[i];
                if (uu.Id  == unit.Id || uu.Id == mainId || ids.Contains(uu.Id) )
                {
                    continue;
                }
                if (!uu.GetComponent<UnitInfoComponent>().IsCanBeAttack())
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
