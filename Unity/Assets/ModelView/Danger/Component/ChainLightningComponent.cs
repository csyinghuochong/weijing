using System.Collections.Generic;
using UnityEngine;

namespace ET
{

    public class ChainLightningComponent : Entity, IAwake<GameObject>, IDestroy
    {

        public long Timer;

        public float detail = 1;//增加后，线条数量会减少，每个线条会更长。  

        public float displacement = 2;//位移量，也就是线条数值方向偏移的最大值  

        public Transform End;//链接目标  

        public Transform Start;

        public bool UsePosition;
        public Vector3 EndPosition;

        public float yOffset = 0;

        public float PassTime;

        public float IntervalTime = 0.1f;

        public LineRenderer _lineRender;

        public List<Vector3> _linePosList;
    }
}
