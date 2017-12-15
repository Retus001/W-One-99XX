using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinnerboi : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Rotate (Vector3.down * 50 * Time.deltaTime, Space.Self);
	}
}
