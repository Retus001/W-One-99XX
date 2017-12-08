using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_Jugador : MonoBehaviour {
	private MartCarMovement MCM;

	// Use this for initialization
	void Start () {
		MCM.GetComponent<MartCarMovement> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider _col)
	{
		if (_col.CompareTag ("PU_G")) {

		}
		if (_col.CompareTag ("PU_S")) {

		}
		if (_col.CompareTag ("PU_G")) {

		}
		if (_col.CompareTag ("PU_G")) {

		}
		if (_col.CompareTag ("PU_G")) {

		}

	}
}
