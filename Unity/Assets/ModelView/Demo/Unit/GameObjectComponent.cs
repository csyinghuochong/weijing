using UnityEngine;

namespace ET
{
    public class GameObjectComponent: Entity, IAwake, IDestroy
    {
        public string UnitAssetsPath;
        public GameObject GameObject;
        public string HorseAssetsPath;
        public GameObject ObjectHorse;
        public Material Material;
        public long DelayShow;

        public long HighLightTimer;
        public long DelayShowTimer;
        public string OldShader;

        public bool BianShenEffect;
    }
}