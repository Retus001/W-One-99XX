using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColorRandom : MonoBehaviour
{

	void Start ()
	{
		GetComponent<MeshRenderer> ().material.color = Random.ColorHSV ();
		
	}
}
