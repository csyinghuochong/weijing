using System.IO;
using UnityEditor;
using UnityEngine;

public class TextureAutoSet : EditorWindow
{

    [MenuItem("Custom/压缩格式ASTC", priority = 0)]
    static void AutoSetASTC()
    {
        string[] guidArray = Selection.assetGUIDs;
        foreach (var item in guidArray)
        {
            string selectFloder = AssetDatabase.GUIDToAssetPath(item);
            DirectoryInfo root = new DirectoryInfo(selectFloder);
            GetFloder(root);
        }
    }

    static void GetFloder(DirectoryInfo root)
    {
        GetFile(root);
        //查找子文件夹
        DirectoryInfo[] array = root.GetDirectories();
        //Debug.Log(root);
        foreach (DirectoryInfo item in array)
        {
            GetFloder(item);
        }
    }

    static void GetFile(DirectoryInfo root)
    {
        //DirectoryInfo root = new DirectoryInfo(path);
        FileInfo[] fileDic = root.GetFiles();
        foreach (var file in fileDic)
        {
            //sDebug.Log(file);
            if (file.FullName.EndsWith(".png") || file.FullName.EndsWith(".jpg") || file.FullName.EndsWith(".tga") ||
                file.FullName.EndsWith(".psd") || file.FullName.EndsWith(".PSD") || file.FullName.EndsWith(".exr") ||
                file.FullName.EndsWith(".tif"))
            {
                //Debug.Log("-------------" + file.FullName);
                //Debug.Log(Application.dataPath);
                SetPicFormat(file.FullName.Replace(Application.dataPath.Replace("Assets", ""), ""));
            }
        }
    }

    static void SetPicFormat(string path)
    {
        Debug.Log(path);
        TextureImporter importer = AssetImporter.GetAtPath(path) as TextureImporter;
        if (importer.mipmapEnabled == true)
        {
            importer.mipmapEnabled = false;
        }

        //判断图片大小
        Texture2D texture = AssetDatabase.LoadAssetAtPath<Texture2D>(path);
        int textureSize = Mathf.Max(texture.height, texture.width);
        //Debug.Log(textureSize);
        int SizeType = FitSize(textureSize);

        //Android   iPhone
        if (importer.DoesSourceTextureHaveAlpha())
        {
            TextureImporterPlatformSettings textureImporterPlatformSettings = new TextureImporterPlatformSettings();
            textureImporterPlatformSettings.format = TextureImporterFormat.ASTC_6x6;

            //ios版本
            //importer.SetPlatformTextureSettings("iPhone", SizeType, TextureImporterFormat.ASTC_RGBA_6x6);
            //安卓版本
            //importer.SetPlatformTextureSettings("Android", SizeType, TextureImporterFormat.ETC2_RGBA8);
            importer.SetPlatformTextureSettings(textureImporterPlatformSettings);
        }
        else
        {
            //ios版本
            //importer.SetPlatformTextureSettings("iPhone", SizeType, TextureImporterFormat.ASTC_RGB_6x6);
            //安卓版本
            //importer.SetPlatformTextureSettings("Android", SizeType, TextureImporterFormat.ETC2_RGB4);
        }
    }

    static int[] formatSize = new int[] { 32, 64, 128, 256, 512, 1024, 2048, 4096 };
    static int FitSize(int picValue)
    {
        foreach (var one in formatSize)
        {
            if (picValue <= one)
            {
                return one;
            }
        }

        return 1024;
    }
}