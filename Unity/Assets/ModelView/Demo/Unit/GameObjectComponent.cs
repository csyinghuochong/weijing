using UnityEngine;

namespace ET
{
    public class GameObjectComponent: Entity, IAwake, IDestroy
    {
        public string UnitAssetsPath;
        public GameObject GameObject;
        public string HorseAssetsPath;
        public GameObject ObjectHorse;
        public GameObject ObjectMove;
        public GameObject BaiTan;
        public Material Material;
    }
}