using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Este script configura de manera aleatoria el Hover

public class HoverRandomSetup : MonoBehaviour
{

	// Use this for initialization
	void Awake ()
	{
		Hover control = GetComponent<Hover> ();
		control.Acceleracion = Random.Range (15, 50);
		control.VelocidadMaxima = Random.Range (8, 30);
		control.VelocidadRotacion = Random.Range (90, 300);
	}
	

}
