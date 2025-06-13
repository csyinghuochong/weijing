using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using ProtoBuf;

namespace ET
{
    public class ExcelExporterWindow : EditorWindow
    {

        Vector2 scrollPosition;
        GameObject ExcelExportGameObject;
        List<string> ExcelExporterName = new List<string>();

        //构造函数用来设置窗口的名字
        ExcelExporterWindow()
        {
            this.titleContent = new GUIContent("ExcelExporter");
        }

        [MenuItem("Tools/ExcelExporterSingle")]
        public static void ExcelExporterSingle()
        {
#if UNITY_EDITOR_OSX
            const string tools = "./Tools";
#else
            const string tools = ".\\Tools.exe";
#endif
            //ShellHelper.Run($"{tools} --AppType=ExcelExporter --Console=1 --Process 1", "../Bin/");
            UnityEngine.Debug.Log(tools);
            EditorWindow.GetWindow(typeof(ExcelExporterWindow));
        }

        //回执窗口界面的函数
        private void OnGUI()
        {
            GUILayout.BeginVertical();
            //绘制标题
            GUILayout.Space(10);
            GUI.skin.label.fontSize = 24;
            GUI.skin.label.alignment = TextAnchor.MiddleCenter;
            GUILayout.Label("ExcelExporter");
            //绘制⽂本
            //GUILayout.Space(10);
            //ExcelExporterName = EditorGUILayout.TextField("Excel Name", ExcelExporterName);
            ////绘制当前正在编辑的场景
            //GUILayout.Space(10);
            //GUI.skin.label.fontSize = 12;
            //GUI.skin.label.alignment = TextAnchor.UpperLeft;
            //GUILayout.Label("Currently Scene:" + EditorSceneManager.GetActiveScene().name);
            ////绘制当前时间
            //GUILayout.Space(10);
            //GUILayout.Label("Time:" + System.DateTime.Now);
            ////绘制对象
            //GUILayout.Space(10);
            //ExcelExportGameObject = (GameObject)EditorGUILayout.ObjectField(
            //    "Buggy Game Object", ExcelExportGameObject, typeof(GameObject), true);
            ////绘制描述⽂本区域
            //GUILayout.Space(10);
            //GUILayout.BeginHorizontal();
            //GUILayout.Label("Describtion", GUILayout.MaxWidth(80));
            //description = EditorGUILayout.TextArea(description, GUILayout.MaxHeight(75));
            //GUILayout.EndHorizontal();
            //EditorGUILayout.Space();
            scrollPosition = GUILayout.BeginScrollView(scrollPosition);
            string excelDir = "../Excel";
            foreach (string path in Directory.GetFiles(excelDir))
            {
                string dir = Path.GetDirectoryName(path);
                string fileName = Path.GetFileName(path);
                if (!fileName.Contains(".xlsx"))
                {
                    continue;
                }
                if (GUILayout.Button(fileName))
                {
                    //UnityEngine.Debug.Log(fileName);//TaskCountryConfig.xlsx
                    if (!ExcelExporterName.Contains(fileName))
                    {
                        ExcelExporterName.Add(fileName);
                    }
                }
            }
            //"../Excel\\ActivityConfig.xlsx"
            if (GUILayout.Button("Export", GUILayout.Height(50)))
            {
                string excels = "";
                for (int i = 0; i < ExcelExporterName.Count; i++)
                {
                    excels += ExcelExporterName[i] + "#";
                }
                if (excels.Length == 0)
                {
                    return;
                }
                excels = excels.Substring(0, excels.Length - 1);

                string tools = ".\\Tools.exe";
                ShellHelper.Run($"{tools} --AppType=ExcelExporter --Console=1 --StartConfig={excels}", "../Bin/");
            }
            GUILayout.EndScrollView();
            GUILayout.EndVertical();
        }

    }
}