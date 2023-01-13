using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameStartImg : MonoBehaviour
{

    public GameObject[] Obj_StartImg;
    public int nowShowImgNum;

    private float startShowEnterSum;     //进入时间
    private bool startShowEnterStatus = false;   //进入状态

    private float startShowSum;              //停留时间
    private bool startShowStatus;            //停留状态
    private float startShowTimeSum;          //消失时间
    private bool startShowStopStatus;        //下一次输出现状态
    private float startShowStopTimeSum;      //下一次启动图出现时间

    //public GameObject Obj_BackMusic;

    // Use this for initialization
    private float PassTime;


	void Start () {
        nowShowImgNum = 0;
        PassTime = 0f;
        Obj_StartImg[nowShowImgNum].SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
        PassTime += Time.deltaTime; 
        if (PassTime >= 5f)
        { 
            gameObject.SetActive(false);    
        }
        //Debug.Log("Time.deltaTime = " + Time.deltaTime + "总时间:" + Time.time);
        //渐变进入
        if (!startShowEnterStatus)
        {
            startShowEnterSum = startShowEnterSum + Time.deltaTime;
            float touMingImgValue = startShowEnterSum / 1f;
            if (touMingImgValue > 1)
            {
                touMingImgValue = 1;
            }

            //第一个图不进入渐变
            if (nowShowImgNum == 0)
            {
                touMingImgValue = 1;
                startShowEnterSum = 1;
                startShowEnterStatus = true;
            }

            //touMingImgValue = 1;

            Obj_StartImg[nowShowImgNum].GetComponent<Image>().color = new Color(1, 1, 1, touMingImgValue);

            if (startShowEnterSum > 1)
            {
                startShowEnterStatus = true;
            }

            //Debug.Log("透明显示:" + touMingImgValue);

        }

        //停留时间
        if (startShowEnterStatus)
        {
            startShowSum = startShowSum + Time.deltaTime;
            if (startShowSum > 1)
            {
                startShowStatus = true;
            }

            //Debug.Log("停留时间:" + startShowSum);
        }

        //渐变消失
        if (startShowStatus) {

            startShowTimeSum = startShowTimeSum + Time.deltaTime;
            float touMingImgValue = startShowTimeSum / 1;
            if (touMingImgValue > 1)
            {
                touMingImgValue = 1;
            }

            Obj_StartImg[nowShowImgNum].GetComponent<Image>().color = new Color(1, 1, 1, 1 - touMingImgValue);
            //Obj_StartImg[nowShowImgNum].SetActive(false);

            if (touMingImgValue >= 1)
            {
                startShowStopStatus = true;
            }

            //Debug.Log("透明消失:" + touMingImgValue);
        }

        if (startShowStopStatus) {
            startShowStopTimeSum = startShowStopTimeSum + Time.deltaTime;
        }

        //下次出现间隔
        if (startShowStopTimeSum>=1.0f)
        {
            if (nowShowImgNum >= Obj_StartImg.Length - 1)
            {
                Destroy(this.gameObject);
            }
            else {

                Obj_StartImg[nowShowImgNum].SetActive(false);
                nowShowImgNum = nowShowImgNum + 1;
                Obj_StartImg[nowShowImgNum].GetComponent<Image>().color = new Color(1, 1, 1, 0);
                Obj_StartImg[nowShowImgNum].SetActive(true);

                startShowEnterStatus = false;
                startShowEnterSum = 0;
                startShowSum = 0;
                startShowStatus = false;
                startShowTimeSum = 0;
                startShowStopStatus = false;
                startShowStopTimeSum = 0;
                //Debug.Log("透明显示取消...");
            }
        }
	}

    public void click() {
        Debug.Log("点击取消!" + Time.time);
        if (Time.time >= 5f)
        {
            Destroy(this.gameObject);
        }
    }

}
