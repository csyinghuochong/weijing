using UnityEngine;

public class RoseSelectTarget : MonoBehaviour {

    public GameObject Obj_SelectEffect;
    public float SelectEffectSize;

	// Use this for initialization
	void Start () 
	{
        //Obj_SelectEffect.GetComponent<ParticleSystem>().startSize = SelectEffectSize*3.0f;
		ParticleSystem ps = GetComponent<ParticleSystem>();
		var main = ps.main;
		main.startSize = new ParticleSystem.MinMaxCurve(1, SelectEffectSize * 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
