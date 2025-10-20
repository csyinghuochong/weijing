using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{

    public class AutoPathEffectComponent : Entity, IAwake, IDestroy
    {
        public long Timer;

        public string EffectPath;

        public GameObject pathPoint;
        public List<GameObject> PathPointList = new List<GameObject>();

        public MoveComponent MoveComponent;

        public Vector3 InvisiblePosition = new Vector3(-3000f, -3000f, 0f);

        public GameObject UIAutoPath;
        public Text TextDistance;

        public bool IfAutoPath = false;
    }
}
