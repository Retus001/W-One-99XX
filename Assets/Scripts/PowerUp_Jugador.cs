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

	void OnTriggerEnter(Collider _col)
	{
		///PU_G = Power Up Glue (Pegamento)
		if (_col.gameObject.CompareTag ("PU_G")) {

		}
		///PU_S = Power Up Speed (Aumento de velocidad)
		if (_col.gameObject.CompareTag ("PU_S")) {
			
		}
		///PU_ST = Power Up Stun
		if (_col.gameObject.CompareTag ("PU_ST")) {

		}
		///PU_O = Power Up Obstaculos (Lanza pendejadas para que los otros caigan)
		if (_col.gameObject.CompareTag ("PU_O")) {

		}
		///PU_UB = Power Up Ultra Boost (Super aumento de velocidad (tipo cohete de mario))
		if (_col.gameObject.CompareTag ("PU_UB")) {

		}
		///PU_B = Power Up Bloqueo de volante (Impide al jugar girar a los lados hasta que presione repetidamente una tecla)
		if (_col.gameObject.CompareTag ("PU_B")) {

		}
		///PU_I = Power Up Invertir Controles
		if (_col.gameObject.CompareTag ("PU_I")) {

		}
		///PU_VB = Vista Borrosa
		if (_col.gameObject.CompareTag ("PU_VB")) {

		}
		///PU_F = Power Up Freeze (Stun a todos los jugadores menos al principal durante unos segundos)
		if (_col.gameObject.CompareTag ("PU_F")) {

		}
		///PU_M = Power Up Magnet (Al activarlo, atrae a un jugador a tu posicion)
		if (_col.gameObject.CompareTag ("PU_M")) {

		}
	}
}
