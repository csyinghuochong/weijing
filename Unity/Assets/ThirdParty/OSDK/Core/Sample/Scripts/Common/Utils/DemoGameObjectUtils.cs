using UnityEngine;

namespace Demo.Douyin.Game
{
    public class DemoGameObjectUtils : MonoBehaviour
    {
        private const string DEMO_GAME_OBJECT_NAME = "DemoGameObjectManager";

        public static T GetOrCreateGameObject<T>() where T : Component
        {
            var adGameObject = GameObject.Find(DEMO_GAME_OBJECT_NAME);
            if (adGameObject == null)
            {
                adGameObject = new GameObject(DEMO_GAME_OBJECT_NAME);
                DontDestroyOnLoad(adGameObject);
            }

            var currentComponent = adGameObject.GetComponent<T>();
            if (currentComponent == null)
            {
                currentComponent = adGameObject.AddComponent<T>();
            }

            return currentComponent;
        }
    }
}