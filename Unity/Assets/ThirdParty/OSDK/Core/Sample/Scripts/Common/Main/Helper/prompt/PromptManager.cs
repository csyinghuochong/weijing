using UnityEngine;

namespace Douyin.Game
{
    /// <summary>
    /// 提示类.
    /// </summary>
    public class PromptManager : CommonCanvasScript<PromptManager>
    {
        private GameObject _promptLayoutGameObject;


        public void Show(string text = null, Sprite sprite = null)
        {
            // android 中的主线程和unity中的主线程不是一个线程
            UnitThreadUtil.QueueOnMainThread(() =>
            {
                var promptScript = this.GetPromptScript();
                if (promptScript != null)
                {
                    var okSprite = Resources.Load<Sprite>("Common/prompt_ok");
                    var spriteResult = sprite == null ? okSprite : sprite;
                    var textResult = string.IsNullOrEmpty(text) ? "OK" : text;
                    promptScript.Show(spriteResult, textResult);
                }
            });
        }

        // 获取toast布局脚本
        private PromptLayoutScript GetPromptScript()
        {
            if (this._commonCanvasTransform == null)
            {
                DemoLog.E("_commonCanvasTransform is null...");
                return null;
            }

            if (this._promptLayoutGameObject == null)
            {
                this._promptLayoutGameObject =
                    Instantiate(PrefabLoader.LoadPromptPrefab(), this._commonCanvasTransform);
            }

            return this._promptLayoutGameObject == null
                ? null
                : this._promptLayoutGameObject.GetComponent<PromptLayoutScript>();
        }

        // 关闭ToastUI
        public void HideUI()
        {
            if (this._promptLayoutGameObject != null)
            {
                Destroy(this._promptLayoutGameObject);
                this._promptLayoutGameObject = null;
            }
        }
    }
}