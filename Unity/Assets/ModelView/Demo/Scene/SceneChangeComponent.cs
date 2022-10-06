using UnityEngine;

namespace ET
{
    public class SceneChangeComponent: Entity, IAwake, IDestroy
    {
        public AsyncOperation loadMapOperation;
        public ETTask tcs;
    }
}