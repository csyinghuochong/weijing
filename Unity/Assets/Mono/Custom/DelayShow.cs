using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayShow : MonoBehaviour
{

    public GameObject ShowObj;
    public float showTime;
    private float time;
    private bool ifShow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ifShow == false)
        {
            time += Time.deltaTime;
            if (time >= showTime)
            {
                ShowObj.SetActive(true);
                ifShow = true;
            }
        }
    }
}
