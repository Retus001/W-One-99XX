using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_Jugador : MonoBehaviour {
	private MartCarMovement MCM;

	// Use this for initialization
	void Start () {
		MCM.GetComponents<MartCarMovement> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider _col)
	{

	}
}
