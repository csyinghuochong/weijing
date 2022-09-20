using UnityEngine;
using System.Collections;

public class MonsterActRange : MonoBehaviour {

    public float RangeSize;
    public GameObject Obj_LightEffect_1;

    //private float timeSum;

	// Use this for initialization
	void Start () {
        //Obj_LightEffect_1.GetComponent<Projector>().fieldOfView = RangeSize;
        Obj_LightEffect_1.GetComponent<Projector>().orthographicSize = RangeSize * 1.2f;

    }
	
	// Update is called once per frame
	void Update () {
        /*
        timeSum = timeSum + Time.deltaTime;
        //超过10秒直接注销
        if (timeSum >= 10) {
            Destroy(this.gameObject);
        }
        */
	}
}
