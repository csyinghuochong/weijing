using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ET
{
    /// <summary>
    /// 飘字组件，用于处理诸如伤害飘字。治疗飘字这种效果
    /// </summary>
    public class FallingFontComponent : Entity, IAwake, IDestroy
    {
        public Camera UiCamera;
        public Camera MainCamera;
        public long Timer;
    }
}
