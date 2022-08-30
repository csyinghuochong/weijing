using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoTweenScale : MonoBehaviour
{
    public float scaleSize = 1.5f;
    public float scaleTime = 1f;
    public float passTime;
    public bool scaleMode;

    void LateUpdate()
    {
        if (this.passTime >= this.scaleTime)
        {
            this.scaleMode = false;
        }

        if (this.passTime <= 0)
        {
            this.scaleMode = true;
        }
        if (this.scaleMode)
        {
            this.passTime += Time.deltaTime;
        }
        else
        {
            this.passTime -= Time.deltaTime;
        }
        
        this.transform.localScale = Vector3.one + Vector3.one * (this.passTime / this.scaleTime) *( this.scaleSize - 1);
    }
}