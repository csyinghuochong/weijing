using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Douyin.Game
{
    // Toast 脚本
    public class ToastLayoutScript : MonoBehaviour
    {
        // 最大宽度,单位为像素，按照设计图来算出来的
        private const int MaxWidth = 933;

        [Header("文本框")] [SerializeField] private Text contentText;

        // 设置聊天文本
        public void SetToastContent(string message)
        {
            var textWidth = UiUtil.GetTextWidth(message, this.contentText.font, this.contentText.fontSize);
            this.ResetPreferred(textWidth);
            this.contentText.text = message;
            this.StopAllCoroutines();
            this.StartCoroutine(this.HideToast());
        }


        // 3秒之后关闭
        private IEnumerator HideToast()
        {
            yield return new WaitForSeconds(3f);
            ToastManager.Instance.HideToast();
        }

        // 重置Preferred 的宽度屬性
        private void ResetPreferred(float textWidth)
        {
            if (textWidth > MaxWidth)
            {
                this.contentText.GetComponent<LayoutElement>().preferredWidth = MaxWidth;
            }
        }
    }
}