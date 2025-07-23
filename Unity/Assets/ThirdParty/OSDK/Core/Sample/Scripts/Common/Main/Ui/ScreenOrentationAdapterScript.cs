using UnityEngine;
using UnityEngine.UI;

namespace Douyin.Game
{
    // 横竖屏切换适配器
    public class ScreenOrentationAdapterScript : MonoBehaviour
    {
        [Header("当前Canvas")] [SerializeField] private Canvas canvas;

        // 当前是竖屏
        private bool isVerticalWithScreen = true;

        private void Awake()
        {
            this.ChangeCanvasXYByScreenDirection();
        }

        private void Update()
        {
            this.ChangeCanvasXYByScreenDirection();
        }

        private void ChangeCanvasXYByScreenDirection()
        {
            if (Screen.width > Screen.height)
            {
                // 横屏
                if (this.isVerticalWithScreen)
                {
                    // 由竖屏切换为横屏的时候在做改变
                    this.ExChangeCanvasReferenceResolutionXY();
                }

                this.isVerticalWithScreen = false;
            }
            else
            {
                // 竖屏
                if (!this.isVerticalWithScreen)
                {
                    // 由横屏切换为竖屏的时候在做改变
                    this.ExChangeCanvasReferenceResolutionXY();
                }

                this.isVerticalWithScreen = true;
            }
        }


        // 交换Canvas的 x y 
        private void ExChangeCanvasReferenceResolutionXY()
        {
            var referenceResolution = this.canvas.GetComponent<CanvasScaler>().referenceResolution;
            var x = referenceResolution.y;
            var y = referenceResolution.x;
            this.canvas.GetComponent<CanvasScaler>().referenceResolution = new Vector2(x, y);
        }
    }
}