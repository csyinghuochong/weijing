using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Douyin.Game
{
    public class PromptLayoutScript : MonoBehaviour
    {
        [Header("图片")] [SerializeField] private Image PromptImage;
        [Header("文本")] [SerializeField] private Text PromptText;


        public void Show(Sprite sprite, string text)
        {
            this.PromptImage.sprite = sprite;
            this.PromptText.text = text;
            this.StopAllCoroutines();
            this.StartCoroutine(HideUI());
        }

        // 3秒之后关闭
        private static IEnumerator HideUI()
        {
            yield return new WaitForSeconds(3f);
            PromptManager.Instance.HideUI();
        }
    }
}