using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour {

	public Camera cam;
	public GameObject obj;
	public Vector3 Posicion, Lejania;
	public float t;

	// Use this for initialization
	void Start () 
	{
		
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		t += Time.deltaTime;
		if (t >= (2 * Mathf.PI))
			t = 0;
		Posicion.x = Lejania.x * Mathf.Cos (t);
		Posicion.z = Lejania.z * Mathf.Sin (t);

		cam.transform.LookAt (obj.transform.position);

		cam.transform.position = Posicion;
	}
}
