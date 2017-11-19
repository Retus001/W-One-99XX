using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap_P1 : MonoBehaviour {

	GameObject P1;
	GameObject P2;

	// Use this for initialization
	void Start () {
		P1 = GameObject.FindGameObjectWithTag ("P1");
		P2 = GameObject.FindGameObjectWithTag ("P2");
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.CompareTag ("MM1"))
			transform.position = P1.transform.position + new Vector3(0.0f, 50.0f, 0.0f);
		if (gameObject.CompareTag ("MM2"))
			transform.position = P2.transform.position + new Vector3(0.0f, 50.0f, 0.0f);
	}
}
