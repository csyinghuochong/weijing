using UnityEngine;
using UnityEngine.UI;

namespace Douyin.Game
{
    // UI 相关工具类
    public static class UiUtil
    {
        // 通过Font获取文本的宽度
        public static float GetTextWidth(string text, Font font, int fontSize)
        {
            font.RequestCharactersInTexture(text, fontSize, FontStyle.Normal);
            var width = 0f;
            foreach (var t in text)
            {
                CharacterInfo info;
                font.GetCharacterInfo(t, out info, fontSize);
                width += info.advance;
            }

            return width;
        }


        // 重制GameObject的 posZ 为0
        public static void ResetPosZTo0(GameObject gameObject)
        {
            var rectTransform = gameObject.GetComponent<RectTransform>();
            var anchoredPosition3D = rectTransform.anchoredPosition3D;
            var x = anchoredPosition3D.x;
            var y = anchoredPosition3D.y;
            anchoredPosition3D = new Vector3(x, y, 0);
            rectTransform.anchoredPosition3D = anchoredPosition3D;
        }

        // 仅仅现实一行，文本过长显示省略号
        public static void SetTextWithEllipsis(this Text textComponent, string value)
        {
            var generator = new TextGenerator();
            var rectTransform = textComponent.GetComponent<RectTransform>();
            var settings = textComponent.GetGenerationSettings(rectTransform.rect.size);
            generator.Populate(value, settings);
            var characterCountVisible = generator.characterCountVisible;
            var updatedText = value;
            if (value.Length > characterCountVisible)
            {
                updatedText = value.Substring(0, characterCountVisible - 3);
                updatedText += "…";
            }

            textComponent.text = updatedText;
        }
    }
}