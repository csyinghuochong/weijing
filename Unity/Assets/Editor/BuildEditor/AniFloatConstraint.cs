using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.Profiling;

public class AniFloatOptimize
{

    [MenuItem("Tools/CustomAnimation/剔除所有Scale曲线")]
    static void CullCurves()
    {
        // 需要直接选中AnimationClip
        var animation_go = Selection.activeObject;
        if (animation_go.GetType() == typeof(AnimationClip))
        {
            // clip
            var clip = animation_go as AnimationClip;
            // 获取Animation的所有Curve
            var binds = AnimationUtility.GetCurveBindings(clip);
            foreach (var bind in binds)
            {
                // 通常名称都是m_LocalScale.(x/y/z),如果是就置空
                if (bind.propertyName.Contains("Scale"))
                    AnimationUtility.SetEditorCurve(clip, bind, null);
            }
            EditorUtility.SetDirty(clip);
            // 重新保存
            AssetDatabase.SaveAssets();
        }
    }

    [MenuItem("Tools/CustomAnimation/优化小变化曲线")]
    static void OptionalConstantCurves()
    {
        // 需要直接选中AnimationClip
        var animation_go = Selection.activeObject;
        if (animation_go.GetType() == typeof(AnimationClip))
        {
            // clip
            var clip = animation_go as AnimationClip;
            // 获取Animation的所有Curve
            var binds = AnimationUtility.GetCurveBindings(clip);
            foreach (var bind in binds)
            {
                var curve = AnimationUtility.GetEditorCurve(clip, bind);
                var keys = curve.keys;
                // 移除常量曲线中的冗余帧
                //int beginIdx = -1;
                // 要移除的帧
                List<int> removeIdxs = new List<int>();
                for (int index = 0; index < keys.Length; index++)
                {
                    var keyframe = keys[index];
                    // 是否是异常量关键帧或者无限接近0
                    if ((float.IsInfinity(keyframe.inTangent) && float.IsInfinity(keyframe.outTangent))
                        || (Mathf.Abs(keyframe.inTangent) <= float.Epsilon && Mathf.Abs(keyframe.outTangent) <= float.Epsilon))
                    {
                        removeIdxs.Add(index);
                    }
                }
                // 移除
                for (int r = removeIdxs.Count - 1; r >= 0; --r)
                {
                    curve.RemoveKey(removeIdxs[r]);
                }
                // 如果curve的关键帧已经没有了，直接移除空的curve
                if (curve.length == 0)
                {
                    AnimationUtility.SetEditorCurve(clip, bind, null);
                }
                else
                {
                    // 重新指定
                    AnimationUtility.SetEditorCurve(clip, bind, curve);
                }
            }
            EditorUtility.SetDirty(clip);
            // 重新保存
            AssetDatabase.SaveAssets();
        }
    }

}

public class AniFloatConstraint: EditorWindow//继承于此,弹窗必要的属性
{


    [MenuItem("Assets/Custom/AniFloatConstraint", false, 1)]//路径
    public static void SetTextureFormat()
    {
        CheckSelection_2();
    }


    //void OnGUI()//在该窗口下作画
    //{


    //    if (Selection.objects.Length <= 0)
    //    {
    //        GUILayout.Label("请先选择一个文件夹!!! ");//做一条标签
    //    }
    //    else
    //    {
    //        GUILayout.Label("当前选中的文件夹： " + AssetDatabase.GetAssetPath(Selection.objects[0]));//未经过筛选的对象组
    //    }

    //    if (GUILayout.Button("开始设置"))//做一个按钮
    //    {
    //        if (!CheckSelection_2()) return;

    //        //AssetDatabase.SaveAssets();
    //        AssetDatabase.Refresh();//导入更改过的资源

    //        Debug.Log("完成");
    //    }
    //}
    //[MenuItem("Custom/动画精度工具", false, 1)]//路径
    //static void SetTextureFormat()
    //{
    //    Rect _rect = new Rect(0, 0, 500, 500);
    //    var temp = GetWindowWithRect<AniFloatConstraint>(_rect, false, "设置", true);

    //}

    //<格式， List<路径>>
    static Dictionary<string, List<string>> allSettings;

    /// <summary>
    /// 没有选中内容返回false
    /// </summary>
    /// <returns></returns>
    public static bool CheckSelection()
    {
        if (Selection.objects.Length <= 0)
        {
            Debug.LogError("请先选择一个文件!!! ");
            return false;
        }

        string selectPath = AssetDatabase.GetAssetPath(Selection.objects[0]);
        Debug.Log("选择了一个文件/夹!!!" + ":" + selectPath);
        SetAnimationClip(selectPath);
        return true;
    }


    /// <summary>
    /// 没有选中内容返回false
    /// </summary>
    /// <returns></returns>
    public static bool CheckSelection_2()
    {
        string selectPath = AssetDatabase.GetAssetPath(Selection.activeInstanceID);

        selectPath = Path.GetDirectoryName(selectPath);

        Debug.Log("选择了一个文件/夹!!!" + ":" + selectPath);
        SetAnimationClip(selectPath);
        return true;
    }

    public static void SetAnimationClip(string path)
    {
        List<AnimationClip> animationClipList = new List<AnimationClip>();
        List<string> animationPathList = new List<string>();
        string[] dirs = Directory.GetFiles(path, "*", SearchOption.AllDirectories);//返回目录中的文件名(含路径),获取文件夹下的所有文件,深度查找
        if (dirs == null || dirs.Length <= 0)
        {
            Debug.LogError("当前地址没有获取到任何的动画文件");
            return;
        }

        for (int i = 0; i < dirs.Length; i++)
        {
            AnimationClip objs = AssetDatabase.LoadAssetAtPath<AnimationClip>(dirs[i]);//通过路径加载资源
            if (objs != null)
            {
                animationClipList.Add(objs);
                animationPathList.Add(AssetDatabase.GetAssetPath(objs));
            }
        }

        CompressAnim_1(animationClipList);
        //CompressAnim_2(animationPathList);
    }

    public static void FixFloatAtClip(AnimationClip clip, bool excludeScale)
    {
        try
        {
            if (excludeScale)
            {
                foreach (var theCurveBinding in AnimationUtility.GetCurveBindings(clip))
                {
                    var name = theCurveBinding.propertyName.ToLower();
                    if (name.Contains("scale"))
                    {
                        AnimationUtility.SetEditorCurve(clip, theCurveBinding, null);
                    }
                }
            }

            var curves = AnimationUtility.GetCurveBindings(clip);
            foreach (var curveDate in curves)
            {
                var curve = AnimationUtility.GetEditorCurve(clip, curveDate);
                if (curve == null || curve.keys == null)
                {
                    continue;
                }

                var keyFrames = curve.keys;
                for (var i = 0; i < keyFrames.Length; i++)
                {
                    var key = keyFrames[i];
                    key.value = float.Parse(key.value.ToString("f2"));
                    key.inTangent = float.Parse(key.inTangent.ToString("f2"));
                    key.outTangent = float.Parse(key.outTangent.ToString("f2"));
                    keyFrames[i] = key;
                }

                curve.keys = keyFrames;
                clip.SetCurve(curveDate.path, curveDate.type, curveDate.propertyName, curve);

                EditorUtility.SetDirty(clip);
                // 重新保存
                AssetDatabase.SaveAssets();
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError(string.Format("CompressAnimationClip Failed !!! animationPath : {0} error: {1}", clip.name,
                e));
        }
    }


    public static void CompressAnim_1(List<AnimationClip> clips)
    {
        foreach(var clip in clips)
        {
            //CompressAnim_sub(clip);

            Debug.LogFormat("1111: MemorySize:{0}",  GetMemorySize(clip));
            FixFloatAtClip(clip, true);
            Debug.LogFormat("2222: MemorySize:{0}",  GetMemorySize(clip));
        }
    }

    private static long GetFileSize(string animclipPath)
    {
        var fileInfo = new FileInfo(animclipPath);
        return fileInfo.Length;
    }

    private static long GetMemorySize(AnimationClip animClip)
    {
        return Profiler.GetRuntimeMemorySizeLong(animClip);
    }

    public static void CompressAnim_sub(AnimationClip clip)
    {
        // 剔除所有Scale曲线
        // 获取Animation的所有Curve
        var binds = AnimationUtility.GetCurveBindings(clip);
        foreach (var bind in binds)
        {
            // 通常名称都是m_LocalScale.(x/y/z),如果是就置空
            if (bind.propertyName.Contains("Scale"))
            {
                AnimationUtility.SetEditorCurve(clip, bind, null);
            }
        }

        // 优化精度曲线
        // 保留两位小数，看需求定义
        var floatFormat = "f2";
        foreach (var bind in binds)
        {
            var curve = AnimationUtility.GetEditorCurve(clip, bind);
            var keys = curve.keys;
            if (keys == null)
            {
                continue;
            }

            for (int index = 0; index < keys.Length; index++)
            {
                var keyframe = keys[index];
                keyframe.value = float.Parse(keyframe.value.ToString(floatFormat));
                keyframe.inTangent = float.Parse(keyframe.inTangent.ToString(floatFormat));
                keyframe.outTangent = float.Parse(keyframe.outTangent.ToString(floatFormat));

                keys[index] = keyframe;
            }
            // struct 需要重新指定
            curve.keys = keys;
            // 重新指定
            AnimationUtility.SetEditorCurve(clip, bind, curve);
        }

        // 优化小变化曲线
        foreach (var bind in binds)
        {
            var curve = AnimationUtility.GetEditorCurve(clip, bind);
            var keys = curve.keys;
            if (keys == null)
            {
                continue;
            }

            // 移除常量曲线中的冗余帧
            //int beginIdx = -1;
            // 要移除的帧
            List<int> removeIdxs = new List<int>();
            for (int index = 0; index < keys.Length; index++)
            {
                var keyframe = keys[index];
                // 是否是异常量关键帧或者无限接近0
                if ((float.IsInfinity(keyframe.inTangent) && float.IsInfinity(keyframe.outTangent))
                    || (Mathf.Abs(keyframe.inTangent) <= float.Epsilon && Mathf.Abs(keyframe.outTangent) <= float.Epsilon))
                {
                    removeIdxs.Add(index);
                }
            }
            // 移除
            for (int r = removeIdxs.Count - 1; r >= 0; --r)
            {
                curve.RemoveKey(removeIdxs[r]);
            }
            // 如果curve的关键帧已经没有了，直接移除空的curve
            if (curve.length == 0)
            {
                AnimationUtility.SetEditorCurve(clip, bind, null);
            }
            else
            {
                // 重新指定
                AnimationUtility.SetEditorCurve(clip, bind, curve);
            }
        }
       
        EditorUtility.SetDirty(clip);
        // 重新保存
        AssetDatabase.SaveAssets();
    }


    /// <summary>
    /// 修改动画精度
    /// </summary>
    /// <param name="animationClipList">动画列表路径</param>
    public static void CompressAnim_2(List<string> list_anims)
    {

      

        int num = 2;
        if (list_anims.Count > 0)
        {
            for (int i = 0; i < list_anims.Count; i++)
            {
                string path = list_anims[i];

                EditorUtility.DisplayProgressBar("CompressAnim", path + " Compressing...", ((float)i / list_anims.Count));//展示或更新一个进度条
                string[] strs = File.ReadAllLines(path);//先把原始内容全部获取按行存在字段中
                if (strs == null)
                {
                    continue;
                }
                File.WriteAllText(path, "");//覆盖path下的文件置为空文件
                //File.Delete(path);
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);//把path下的空文件获取为文件流形式，以便对它进行操作
                StreamWriter sw = new StreamWriter(fs);//像是装饰模式，把文件流放入可写对象中，对该对象进行操作
                sw.Flush();//清除文件流写入器的缓存内容
                sw.BaseStream.Seek(0, SeekOrigin.Begin);//把文件流定位到开头

                for (int j = 0; j < strs.Length; j++)//对原始内容进行操作，一行一行的检索
                {

                    if (strs[j].Contains("time"))
                    {
                        string[] txts = strs[j].Split(':');
                        if (txts != null)
                        {
                            if (txts[1].Contains(".") && (txts[1].Length - txts[1].IndexOf('.') - 1) >= num)
                            {
                                txts[1] = float.Parse(txts[1]).ToString("f" + num);
                                if (float.Parse(txts[1]) == 0)
                                {
                                    txts[1] = "0";
                                }
                            }
                            strs[j] = txts[0] + ": " + txts[1];
                        }
                    }//这里没有写入
                    if (strs[j].Contains("value") || strs[j].Contains("inSlope") || strs[j].Contains("outSlope") || strs[j].Contains("inWeight") || strs[j].Contains("outWeight"))
                    {
                        strs[j].Trim();//删除前后的空白字符

                        int frontindex = strs[j].IndexOf('{');
                        int behindindex = strs[j].IndexOf('}');

                        string beginstr = null;
                        string str = null;
                        if (frontindex < 0 || behindindex < 0)
                        {
                            string[] txts = strs[j].Split(':');
                            if (txts != null)
                            {
                                if (txts[1].Contains(".") && (txts[1].Length - txts[1].IndexOf('.') - 1) >= num)
                                {
                                    txts[1] = float.Parse(txts[1]).ToString("f" + num);
                                    if (float.Parse(txts[1]) == 0)
                                    {
                                        txts[1] = "0";
                                    }

                                }
                                strs[j] = txts[0] + ": " + txts[1];
                                sw.WriteLine(strs[j]);
                                continue;
                            }

                        }
                        else
                        {
                            beginstr = strs[j].Substring(0, frontindex);
                            str = strs[j].Substring(frontindex + 1, behindindex - frontindex - 1);
                        }

                        if (str != null)
                        {
                            string[] txts = str.Split(',');
                            if (txts != null)
                            {
                                string tt_new = null;
                                for (int k = 0; k < txts.Length; k++)
                                {
                                    string[] newstr = txts[k].Split(':');
                                    if (newstr[1].Contains(".") && (newstr[1].Length - newstr[1].IndexOf('.') - 1) >= num)
                                    {
                                        newstr[1] = float.Parse(newstr[1]).ToString("f" + num);
                                        if (float.Parse(newstr[1]) == 0)
                                        {
                                            newstr[1] = "0";
                                        }
                                    }
                                    tt_new += newstr[0] + ": " + newstr[1] + (k == txts.Length - 1 ? "" : ",");

                                }
                                strs[j] = beginstr + "{" + tt_new + "}";
                            }

                        }
                    }
                    sw.WriteLine(strs[j]);
                }
                Debug.Log("修改动画精度:" + path);
                sw.Flush();//清除缓存
                sw.Close();//关闭文件流写入器
            }
            EditorUtility.ClearProgressBar();//都执行完了关闭进度条
            Resources.UnloadUnusedAssets();//卸载未使用的资源
            AssetDatabase.SaveAssets();//将所有未保存的资源写入磁盘
            list_anims.Clear();//清除文件路径
            GC.Collect();//GC回收
        }
    }

}