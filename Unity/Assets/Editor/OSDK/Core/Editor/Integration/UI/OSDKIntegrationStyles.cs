using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    public static class OSDKIntegrationStyles
    {
        // 标题样式
        internal static GUIStyle getTitleStyle()
        {
            return new GUIStyle()
            {
                fontSize = 20,
                fontStyle = FontStyle.BoldAndItalic,
                alignment = TextAnchor.MiddleCenter,
            };
        }
        // Section样式
        internal static GUIStyle getSectionStyle()
        {
            return new GUIStyle(EditorStyles.foldout)
            {
                fontSize = 14,
                fontStyle = FontStyle.Bold,
            };
        }
        // Step样式
        internal static GUIStyle getStepStyle(int fontSize = 13, FontStyle style = FontStyle.Italic)
        {
            return new GUIStyle(EditorStyles.foldout)
            {
                fontSize = fontSize,
                fontStyle = style
            };
        }
        // label样式
        internal static GUIStyle getLabelStyle()
        {
            GUIStyle labelStyle = new GUIStyle(EditorStyles.label);
            labelStyle.fontSize = 12;
            return labelStyle; 
        }
    }
}