using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ET
{
    public static class HoreseHelper
    {

        public static float GetRoleScale( int horseId)
        {
            switch (horseId)
            {
                case 10001:
                    return 1f / 6;
                default:
                    return 1f;
            }
        }

        public static GameObject GetHorseNode(GameObject ObjectHorse)
        {
            return ObjectHorse.Get<GameObject>("Head");
        }
    }
}
