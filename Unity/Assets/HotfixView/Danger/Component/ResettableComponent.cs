using UnityEngine;
using System.Collections.Generic;

namespace ET
{
    public interface IResettable
    {
        void Reset(object src, object dst);
    }

    public abstract class ResettableComponent<T> where T : UnityEngine.Component, IResettable
    {
        public T Instance;

        public ResettableComponent(GameObject gameObject)
        {
            Instance = gameObject.AddComponent<T>();
        }

        public abstract void Reset(T src, T dst);

        public void Reset(object src, object dst)
        {
            Reset((T)src, (T)dst);
        }
    }

    public static class ResettableComponentMgr
    {
        private static Dictionary<GameObject, HashSet<IResettable>> GameObjectResettableComponents = new Dictionary<GameObject, HashSet<IResettable>>();
    }
}

