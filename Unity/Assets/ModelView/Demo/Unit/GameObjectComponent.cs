using UnityEngine;

namespace ET
{
    public class GameObjectComponent: Entity, IAwake, IDestroy
    {

        public string AssetsPath;
        public GameObject GameObject;
        public GameObject BaiTan;
        public Material Material;
    }
}