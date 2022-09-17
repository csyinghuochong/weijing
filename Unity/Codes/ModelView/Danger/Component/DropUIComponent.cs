using UnityEngine;

namespace ET
{ 

    public class DropUIComponent : Entity, IAwake, IDestroy
    {
        public Unit MyUnit;
        public int PositionIndex;      //曲线点的索引
        public Vector3 StartPoint;
        public Vector3 EndPoint;
        public Vector3[] LinepointList;
        public GameObject HeadBar;
        public Transform UIPosition;
        public Camera UICamera;
        public Camera MainCamera;
        public MeshRenderer ModelMesh;              //AI材质
        public int Resolution;
        public DropInfo DropInfoData;               //掉落数据
        public bool IfShowStatus;
        public float LastTime;
        public HeadBarUI HeadBarUI;
        public long Timer;

        public string AssetPath;
    }

}
