using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartCarMovement : MonoBehaviour {

	Rigidbody rigi;
	public float Pawah;
	//TurbinaR
	float RT_Force = 0;
	public KeyCode RT_Forward;   	//Tecla configurable para avanzar
	public KeyCode RT_Backguard;	//y para retroceder (la turbina)
	//TurbinaL
	float LT_Force = 0;
	public KeyCode LT_Forward;
	public KeyCode LT_Backguard;

	// Use this for initialization
	void Start () {
		rigi = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (RT_Forward)) {
			RT_Force = 1;
		} else if (Input.GetKeyDown (RT_Backguard)) {
			RT_Force = -1;
		} else {
			RT_Force = 0;
		}
		if (Input.GetKeyDown (LT_Forward)) {
			LT_Force = 1;
		} else if (Input.GetKeyDown (LT_Backguard)) {
			LT_Force = -1;
		} else {
			LT_Force = 0;
		}

		rigi.velocity = Vector3.forward * (LT_Force + RT_Force) * Pawah;

	}
}
