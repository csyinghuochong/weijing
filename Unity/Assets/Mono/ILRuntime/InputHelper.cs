using UnityEngine;

namespace ET
{
    public static class InputHelper
    {
        public static bool GetKey(int code)
        {
            return Input.GetKey((KeyCode)code);
        }

        public static bool GetKeyDown(int code)
        {
            return Input.GetKeyDown((KeyCode)code);
        }

        public static bool GetMouseButtonDown(int code)
        {
            return Input.GetMouseButtonDown(code);
        }

        public static bool Check_GetMouseButtonDown0()
        {
            return (GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began));
        }

        public static bool IsPointerOverGameObject()
        {
            return false;//// UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId);
        }
    }
}