using System.Text;
using UnityEditor;
using UnityEngine;

namespace Douyin.Game
{
    internal static class OSDKMargin
    {
        internal const int TextTab = 5;
        internal const int Tab1 = 20;
        internal const int Tab2 = 32;
        internal const int Tab3 = 44;
        internal const int Tab4 = 50;
    }
    
    public class OSDKIntegrationLayout
    {
        public delegate void ButtonClickCallback();
        
        // 1.【勾选框 + 文本 + 提示】
        internal static bool ToggleTipsLayout(bool select, string label, string tips = null, int marginLeft = 0, bool enable = true)
        {
            EditorGUILayout.BeginHorizontal();
            if (enable == false)
            {
                GUI.enabled = false;
            }
            var value = GUILayout.Toggle(select, label, new GUIStyle(EditorStyles.toggle)
            {
                fontSize = 12,
                stretchWidth = false,
                margin = { left = marginLeft }
            });
            if (enable == false)
            {
                GUI.enabled = true;
            }
            if (tips != null)
            {
                var image = OSDKIntegrationUtils.GetQuestionTexture();
                GUILayout.Label(new GUIContent(image, tips), new GUIStyle(EditorStyles.label)
                {
                    stretchWidth = false,
                    wordWrap = true
                });
            }
            EditorGUILayout.EndHorizontal();
            return value;
        }

        // 2.【文本 + 提示文案 + 选择框】 样式
        internal static int LabelEnumPopupTipsLayout(string label, string[] enumStrings, int index, string tips = null, int marginLeft = 0)
        {
            EditorGUILayout.BeginHorizontal();
            LabelTipsLayout(label, tips, marginLeft);
            GUILayout.Space(10);
            index = EnumPopupLayout(index, enumStrings, 0);
            GUILayout.FlexibleSpace();
            EditorGUILayout.EndHorizontal();
            return index;
        }
        
        // 3.【文本 + 提示文案】 样式
        internal static void LabelTipsLayout(string label, string tips = null, int marginLeft = 0)
        {
            var tipsIsNotEmpty = !string.IsNullOrWhiteSpace(tips);
            if (tipsIsNotEmpty)
            {
                EditorGUILayout.BeginHorizontal();    
            }
            GUILayout.Label(new GUIContent(label, tips), new GUIStyle(EditorStyles.label)
            {
                margin = {left = marginLeft},
                fontSize = 12,
                stretchWidth = false,
                wordWrap = true
            });
            if (tipsIsNotEmpty)
            {
                var image = OSDKIntegrationUtils.GetQuestionTexture();
                GUILayout.Label(new GUIContent(image, tips), new GUIStyle(EditorStyles.label)
                {
                    stretchWidth = false,
                    wordWrap = true
                });
            }
            if (tipsIsNotEmpty)
            {
                EditorGUILayout.EndHorizontal();       
            }
        }
        
        // 4. 广告专属【文本 + 按钮】样式
        internal static void AdComponentTitleLayout(string label, int marginLeft, 
            string button1Title, bool button1Enable, ButtonClickCallback button1Callback, string disableWarningText = null)
        {
            EditorGUILayout.BeginHorizontal();
            LabelTipsLayout(label, null, marginLeft);
            GUILayout.FlexibleSpace();
            if (button1Enable == false)
            {
                GUI.enabled = false;
            }
            var enable = GUI.enabled;
            GUI.enabled = button1Enable;
            var width = GetStringWidth(button1Title);
            var clicked = GUILayout.Button(button1Title, new GUIStyle("Button"){fixedWidth = width});
            GUI.enabled = enable;
            if (clicked)
            {
                button1Callback();
            }
            GUILayout.Space(OSDKMargin.Tab2);
            EditorGUILayout.EndHorizontal();
            if (!enable && disableWarningText != null)
            {
                EditorGUILayout.HelpBox(disableWarningText, MessageType.Warning);
            }
        }

        internal static bool Button(string buttonTitle, int marginLR = 0, bool enable = true, bool layoutLeft = true)
        {
            EditorGUILayout.BeginHorizontal();
            if (enable == false)
            {
                GUI.enabled = false;    
            }
            var width = GetStringWidth(buttonTitle);
            var clicked = GUILayout.Button(buttonTitle, new GUIStyle("Button")
            {
                fixedWidth = width,
                margin = {left = marginLR}
            });
            if (enable == false)
            {
                GUI.enabled = true;    
            }
            EditorGUILayout.EndHorizontal();
            if (clicked)
            {
                GUIUtility.keyboardControl = 0;
            }
            return clicked;
        }

        // 5.【文本 + 提示文案 + 按钮】样式
        internal static bool LabelButtonTipsLayout(string label, string buttonTitle, string tips = null,
            int marginLR = 0, bool enable = true, bool layoutLeft = true, string disableWarningText = null)
        {
            EditorGUILayout.BeginHorizontal();
            LabelTipsLayout(label, tips, marginLR);
            if (layoutLeft)
            {
                GUILayout.Space(30);
            }
            else
            {
                GUILayout.FlexibleSpace();    
            }
            if (enable == false)
            {
                GUI.enabled = false;    
            }
            var width = GetStringWidth(buttonTitle);
            var clicked = GUILayout.Button(buttonTitle, new GUIStyle("Button"){fixedWidth = width});
            if (enable == false)
            {
                GUI.enabled = true;    
            }

            if (layoutLeft)
            {
                GUILayout.FlexibleSpace(); 
            }
            else
            {
                GUILayout.Space(30);    
            }
            EditorGUILayout.EndHorizontal();
            if (!enable && disableWarningText != null)
            {
                EditorGUILayout.HelpBox(disableWarningText, MessageType.Warning);
            }
            if (clicked)
            {
                GUIUtility.keyboardControl = 0;
            }
            return clicked;
        }
        
        // 6.【选择框】样式
        internal static int EnumPopupLayout(int selected, string[] enumStrings, int marginLeft = 5)
        {
            var result = EditorGUILayout.Popup(selected, enumStrings, new GUIStyle(EditorStyles.popup)
            {
                fontSize = 12,
                fixedHeight = 18,
                fixedWidth = 150,
                margin = { left = marginLeft }
            });
            return result;
        }
        
        // 7.【输入框 带占位符】样式
        internal static string TextField(string text, string placeholder, GUIStyle style = null, bool enableEdit = true)
        {
            return TextInput(text, placeholder,false , style, enableEdit);
        }

        internal static string TextArea(string text, string placeholder, GUIStyle style = null, bool enableEdit = true)
        {
            return TextInput(text, placeholder, true, style, enableEdit);
        }

        private static string TextInput(string text, string placeholder, bool area, GUIStyle style = null, bool enableEdit = true)
        {
            if (style == null)
            {
                style = area ? EditorStyles.textArea : EditorStyles.textField;
            }

            if (enableEdit == false)
            {
                GUI.enabled = false;
            }
            var newText = area ? EditorGUILayout.TextArea(text, style) : EditorGUILayout.TextField(text, style);
            if (string.IsNullOrWhiteSpace(text) && !string.IsNullOrWhiteSpace(placeholder)) {
                const int textMargin = 2;
                var textRect = GUILayoutUtility.GetLastRect();
                var position = new Rect(textRect.x + textMargin, textRect.y, textRect.width, textRect.height);
                EditorGUI.LabelField(position, $"<color=#828282>{placeholder}</color>", new GUIStyle(EditorStyles.label)
                {
                    richText = true
                });
            }
            if (enableEdit == false)
            {
                GUI.enabled = true;
            }
            return newText;
        }
        
        // 8.【分割线】样式
        internal static void SepLine(string text = "----------------------------------------------------------", int marginLeft = 0)
        {
            GUILayout.Space(8);
            GUILayout.Label(text, new GUIStyle(EditorStyles.label)
            {
                alignment = TextAnchor.MiddleCenter,
                margin = { left = marginLeft, right = marginLeft },
            });
            GUILayout.Space(8);
        }

        internal static void SepLine(int marginLeft = 0)
        {
            SepLine("------------------------------------------------------------------", marginLeft);
        }

        internal static string LabelTextFieldLayout(string label, string text, string placeholder, int marginLeft = 0, bool enableEdit = true)
        {
            EditorGUILayout.BeginHorizontal();
            LabelTipsLayout(label, null, marginLeft);
            var result = TextField(text, placeholder, null, enableEdit);
            GUILayout.Space(marginLeft);
            EditorGUILayout.EndHorizontal();
            return result;
        }
        
        #region 辅助函数

        public static float GetStringWidth(string str)
        {
            var count = Encoding.GetEncoding("gb2312").GetByteCount(str);
            return (float)(count * 5.5 + 28);
        }

        #endregion
    }
}