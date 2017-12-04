using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartCarMovement : MonoBehaviour {

	Rigidbody rigi;
	public float Pawah;
	public float MaxSpeed;
	public float RotationSpeed;
	public float RotationBreaks;
	public float Frenos;
	//TurbinaR
	float RT_Force = 0; // Right Translation Force
	float RR_Force = 0; //Right Rotation Force
	public KeyCode RT_Forward;   	//Tecla configurable para avanzar
	public KeyCode RT_Backguard;	//y para retroceder (la turbina)
	//TurbinaL
	float LT_Force = 0; //Left Translation Force
	float LR_Force = 0; //Left Rotation Force
	public KeyCode LT_Forward;
	public KeyCode LT_Backguard;
	public Vector3 test;

	// Use this for initialization
	void Start () {
		rigi = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (RT_Forward)) {
			RT_Force = 1;

		} else if (Input.GetKey (RT_Backguard)) {
			RT_Force = -1;
		} else {
			RT_Force = 0;
		}
		if (Input.GetKey (LT_Forward)) {
			LT_Force = 1;
		} else if (Input.GetKey (LT_Backguard)) {
			LT_Force = -1;
		} else {
			LT_Force = 0;
		}
			
		if (rigi.velocity.magnitude < MaxSpeed) {
			rigi.velocity += gameObject.transform.forward * (LT_Force + RT_Force) * Pawah;
		}
		//gameObject.transform.Rotate (Vector3.up * (LT_Force + RT_Force) * RotationSpeed);
		rigi.angularVelocity += gameObject.transform.up * (-LT_Force + RT_Force) * RotationSpeed;

		//Friccion del aire ...?
		rigi.velocity -= Frenos*rigi.velocity;
		if (rigi.velocity.magnitude < 0)
			rigi.velocity = Vector3.zero;

		test = rigi.angularVelocity;
		rigi.angularVelocity -= RotationBreaks*rigi.angularVelocity;
		if (rigi.angularVelocity.magnitude <= 0) {
			rigi.angularVelocity = Vector3.zero;
		}


	}
}
