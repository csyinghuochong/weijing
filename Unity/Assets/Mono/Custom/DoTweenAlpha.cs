using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DoTweenAlpha : MonoBehaviour
{
    public float alphaTime = 1.5f;
    public float passTime = 0f;
    public bool scaleMode ;

    void LateUpdate()
    {
        if (this.passTime >= this.alphaTime)
        {
            this.scaleMode = false;
            this.gameObject.GetComponent<Image>().CrossFadeAlpha(0f, this.alphaTime, true);
        }
        if (this.passTime <= 0)
        {
            this.scaleMode = true;
            this.gameObject.GetComponent<Image>().CrossFadeAlpha(1f, this.alphaTime, true);
        }
        if (this.scaleMode)
        {
            this.passTime += Time.deltaTime;
        }
        else
        {
            this.passTime -= Time.deltaTime;
        }
    }
}