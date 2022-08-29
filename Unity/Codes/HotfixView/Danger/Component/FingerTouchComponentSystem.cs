using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ET
{
	[ObjectSystem]
	public class FingerTouchComponentAwakeSystem : AwakeSystem<FingerTouchComponent>
	{
		public override void Awake(FingerTouchComponent self)
		{
			//允许多点触摸
			Input.multiTouchEnabled = true;
            self.cameraTarget = UIComponent.Instance.MainCamera.transform;

        }
    }

    [ObjectSystem]
    public class FingerTouchComponentUpdateSystem : UpdateSystem<FingerTouchComponent>
    {
        public override void Update(FingerTouchComponent self)
        {
            //self.OnUpdate();
        }
    }


    public static class FingerTouchComponentSystem
    {

        public static void OnUpdate(this FingerTouchComponent self)
		{
            //self.DesktopInput();
            self.MobileInput();
		}

        //移动端控制摄像机旋转
        public static void MobileInput(this FingerTouchComponent self)
        {
            if (Input.touchCount == 0)
            {
                return;
            }
            if (Input.touchCount != 1)
            {
                return;
            }
      
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                self.m_scenePos = Input.touches[0].position;
            }
            else if (Input.touches[0].phase == TouchPhase.Moved)
            {
                //旋转摄像机
                self.cameraTarget.Rotate(new Vector3(-Input.touches[0].deltaPosition.y, Input.touches[0].deltaPosition.x, 0), Space.Self);
            }

            if (Input.touches[0].phase == TouchPhase.Ended && Input.touches[0].phase != TouchPhase.Canceled)
            {
                Vector2 pos = Input.touches[0].position;

                //判断手指移动
                //水平移动
                if (Mathf.Abs(self.m_scenePos.x - pos.x) > Mathf.Abs(self.m_scenePos.y - pos.y))
                {
                    if (self.m_scenePos.x > pos.x)
                    {
                        Debug.Log("手指向左滑");
                    }
                    else
                    {
                        Debug.Log("手指右滑");
                    }
                }
                else
                {
                    if (self.m_scenePos.y > pos.y)
                    {
                        Debug.Log("手指下滑");
                    }
                    else
                    {
                        Debug.Log("手指上滑");
                    }
                }
            }
        }

        //Window端控制摄像机旋转
        public static void DesktopInput(this FingerTouchComponent self)
        {
            float mx = Input.GetAxis("Mouse X");
            float my = Input.GetAxis("Mouse Y");

            if (mx != 0 || my != 0)
            {
                if (Input.GetMouseButton(0))
                {
                    //cameraTarget.Rotate(new Vector3(-my * 10, mx * 10, 0), Space.Self);
                }
            }
        }
	}
}
