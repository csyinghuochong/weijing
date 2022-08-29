using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectTest : MonoBehaviour {
	public ParticleSystem kHealEffect;
	// Use this for initialization
	void Start () {
		kHealEffect.Stop ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Effect()
	{
		kHealEffect.Play ();
	}
}
