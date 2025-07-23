using UnityEngine;

namespace Douyin.Game
{
    /// <summary>
    /// MonoBehaviour对应的实例.
    /// </summary>
    /// <typeparam name="T">继承于MonoBehaviour的脚本.</typeparam>
    public class MonoSingletonBase<T> : MonoBehaviour
        where T : MonoBehaviour
    {
        private const string GameManagerName = "GameManager";
        private static T _instance;

        /// <summary>
        /// Gets 获取单例对象.
        /// </summary>
        public static T Instance
        {
            get
            {
                var o = GameObject.Find(GameManagerName);
                if (o == null)
                {
                    o = new GameObject(GameManagerName);
                    DontDestroyOnLoad(o);
                }

                var instanceObjectScript = o.GetComponent<T>();

                if (instanceObjectScript == null)
                {
                    _instance = o.AddComponent<T>();
                }

                return _instance;
            }
        }

        /// <summary>
        /// 移除实例，可能有的地方不需要长期保存此实例.
        /// </summary>
        protected void RemoveInstance()
        {
            var o = GameObject.Find(GameManagerName);
            if (o != null)
            {
                var instanceComponent = o.GetComponent<T>();
                if (instanceComponent != null)
                {
                    Destroy(instanceComponent);
                }
            }
        }
    }
}