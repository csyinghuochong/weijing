
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public class ChangeEquipComponent : Entity, IAwake
    {
        public int num;
        public Animation animator;
        public GameObject target;
        public List<Transform> oldBones = new List<Transform>();

        public Transform weaponParent;
        public string lianPaths;
        public string shangyiPaths;
        public string meimaoPaths;
        public string pifengPaths;
        public string toufaPaths;
        public string xiashenPaths;
        public string xieziPaths;
        public string yangjingPaths;

        public GameObject weapon;

        public List<SkinnedMeshRenderer> skinnedMeshRenderers = new List<SkinnedMeshRenderer>();
    }
}
