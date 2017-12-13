using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp_Jugador : MonoBehaviour {
	private MartCarMovement MCM;
	private int PUG = 0;
	private int PUS = 0;
	private int PUST = 0;
	private int PUO = 0;
	private int PUUB = 0;
	private int PUB = 0;
	private int PUI = 0;
	private int PUVB = 0;
	private int PUF = 0;
	private int PUM = 0;

	// Use this for initialization
	void Start () {
		MCM.GetComponent<MartCarMovement> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (PUG >= 1) {
			if(gameObject.CompareTag("P1")) {
				if (Input.GetKey (KeyCode.W)) {

				}
			}
			if(gameObject.CompareTag("P2")) {
				if (Input.GetKey (KeyCode.Keypad8)) {

				}
			}
		}
		if (PUS >= 1) {
			if(gameObject.CompareTag("P1")) {
				if (Input.GetKey (KeyCode.W)) {
					PUS -= 1;
					MCM.MaxSpeed += 5;
				}
			}
			if(gameObject.CompareTag("P2")) {
				if (Input.GetKey (KeyCode.Keypad8)) {
					PUS -= 1;
					MCM.MaxSpeed += 5;
				}
			}
		}
	}

	void OnTriggerEnter(Collider _col)
	{
		///PU_G = Power Up Glue (Pegamento)
		if (_col.gameObject.CompareTag ("PU_G")) {
			PUG += 1;
		}
		///PU_S = Power Up Speed (Aumento de velocidad)
		if (_col.gameObject.CompareTag ("PU_S")) {
			PUS += 1;
		}
		///PU_ST = Power Up Stun
		if (_col.gameObject.CompareTag ("PU_ST")) {
			PUST += 1;
		}
		///PU_O = Power Up Obstaculos (Lanza pendejadas para que los otros caigan)
		if (_col.gameObject.CompareTag ("PU_O")) {
			PUO += 1;
		}
		///PU_UB = Power Up Ultra Boost (Super aumento de velocidad (tipo cohete de mario))
		if (_col.gameObject.CompareTag ("PU_UB")) {
			PUUB += 1;
		}
		///PU_B = Power Up Bloqueo de volante (Impide al jugar girar a los lados hasta que presione repetidamente una tecla)
		if (_col.gameObject.CompareTag ("PU_B")) {
			PUB += 1;
		}
		///PU_I = Power Up Invertir Controles
		if (_col.gameObject.CompareTag ("PU_I")) {
			PUI += 1;
		}
		///PU_VB = Vista Borrosa
		if (_col.gameObject.CompareTag ("PU_VB")) {
			PUVB += 1;
		}
		///PU_F = Power Up Freeze (Stun a todos los jugadores menos al principal durante unos segundos)
		if (_col.gameObject.CompareTag ("PU_F")) {
			PUF += 1;
		}
		///PU_M = Power Up Magnet (Al activarlo, atrae a un jugador a tu posicion)
		if (_col.gameObject.CompareTag ("PU_M")) {
			PUM += 1;
		}
	}
}
