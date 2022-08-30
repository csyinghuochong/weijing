using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMailHint : MonoBehaviour
{
    private float timeValue;
    private bool gaibianStatus;
    private float nowSizePro;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!gaibianStatus)
        {
            timeValue = timeValue + Time.deltaTime;
            nowSizePro = 1 + timeValue / 3;
            this.gameObject.transform.localScale = new Vector3(nowSizePro, nowSizePro, nowSizePro);
            if (timeValue >= 0.5f)
            {
                gaibianStatus = true;
                timeValue = 0;
            }
        }
        else
        {
            timeValue = timeValue + Time.deltaTime;
            nowSizePro = nowSizePro - (nowSizePro - 1) * (timeValue / 0.5f);
            if (nowSizePro <= 1)
            {
                nowSizePro = 1;
            }
            this.gameObject.transform.localScale = new Vector3(nowSizePro, nowSizePro, nowSizePro);
            if (timeValue >= 0.5f)
            {
                gaibianStatus = false;
                timeValue = 0;
            }
        }
    }

}
