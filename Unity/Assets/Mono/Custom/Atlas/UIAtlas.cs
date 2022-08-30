using System.Collections;
using System.Collections.Generic;
using KO;
using UnityEngine;


[System.Serializable]
public class SpritePair
{
    public string name;
    public Sprite sp;
}

public class UIAtlas : MonoBehaviour
{
    /// <summary>
    /// sprite列表
    /// </summary>
    public List<SpritePair> sp_list;
    public Texture tex;
    public Material alphaMat;

    public Material gragAlphaMat
    {
        get
        {
            /*if (AtlasUtils.UseAlphaSplit && _gragAlphaMat == null)
            {
                _gragAlphaMat = new Material(AtlasUtils.MAT_SPRITE_GRAY);
                _gragAlphaMat.SetupAlphaSplitKeyword();
            }*/
            return _gragAlphaMat;
        }
    }

    private Material _gragAlphaMat;

    public Material GrayAlphaMat
    {
        get
        {
            /*if (AtlasUtils.UseAlphaSplit)
            {
                if (mGrayAlphaMat == null)
                {
                    mGrayAlphaMat = new Material(alphaMat);
                    mGrayAlphaMat.SetupAlphaSplitKeyword();
                }
            }*/
            return mGrayAlphaMat;
        }
    }

    private Material mGrayAlphaMat;

    public Sprite GetSpriteByName(string name)
    {
        Sprite sp = null;

        int len = sp_list.Count;
        for (int i = 0; i < len; i++)
        {
            SpritePair pair = sp_list[i];
            if (pair.name == name)
            {
                sp = pair.sp;
                break;
            }
        }

        return sp;
    }
}