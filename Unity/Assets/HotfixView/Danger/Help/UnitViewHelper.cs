using UnityEngine;

namespace ET
{
    public static class UnitViewHelper
    {

        public static void ShowWeapon(this Unit self, bool show)
        {
            GameObjectComponent gameObjectComponent  = self.GetComponent<GameObjectComponent>();
            if (gameObjectComponent == null)
            {
                return;
            }
            gameObjectComponent.GameObject.Get<GameObject>("Wuqi001").SetActive(show);
        }

    }
}
