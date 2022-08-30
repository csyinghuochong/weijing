using UnityEngine;
using System.Collections;

public class DestroyForTime : MonoBehaviour {

	public float time;

	void Start () {
		Destroy(this.gameObject,time);
	    //this.transform.rotation = Quaternion.Euler(Vector3.zero);
    }

}
