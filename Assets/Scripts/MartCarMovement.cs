using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MartCarMovement : MonoBehaviour {

	Rigidbody rigi;
	[Tooltip("Es la fuerza con la que acelera")]
	public float Pawah;
	[Tooltip("Es la velocidad maxima a la que llega")]
	public float MaxSpeed;
	[Tooltip("Es la fuerza con la que rota")]
	public float RotationPawah;
	[Tooltip("Es la rapidez maxima con la que rota")]
	public float RotationMaxSpeed;
	[Range(0.0f, 1.0f)]
	[Tooltip("Es la rapidez con la que deja de rotar")]
	public float RotationBreaks;
	[Range(0.0f, 1.0f)]
	[Tooltip("Es la fuerza con la que se frena al no acelerar")]
	public float Frenos;
	[Tooltip("Que tan rapido llega a el maximo de estar dando vuelta")]
	public float turnSensibility;
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
		RT_Forward = KeyCode.E;
		LT_Forward = KeyCode.Q;
		RT_Backguard = KeyCode.D;
		LT_Backguard = KeyCode.A;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (RT_Forward) && RT_Force < 1) {
			RT_Force += turnSensibility*Time.deltaTime;

		} else if (Input.GetKey (RT_Backguard)) {
			RT_Force -= turnSensibility * Time.deltaTime;
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
		if (rigi.angularVelocity.magnitude < RotationMaxSpeed) {
			rigi.angularVelocity += gameObject.transform.up * (-LT_Force + RT_Force) * RotationPawah;
		}

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