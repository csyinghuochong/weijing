using System;
using UnityEngine;

namespace ET
{

    public class FingerTouchComponent : Entity, IAwake, IDestroy, IUpdate
    {
        //手指第一次触摸点的位置
        public Vector2 m_scenePos = new Vector2();
        //摄像机
        public Transform cameraTarget;
    }
}
