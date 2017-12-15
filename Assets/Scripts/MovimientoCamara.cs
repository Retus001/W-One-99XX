using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour {

	[Header("Asignacion de Objetos")]
	public Camera cam;
	[Tooltip("Es el objeto al que esta viendo la camara")]
	public GameObject obj;
	Vector3 Posicion;
	Vector3 Tempos;
	[Space (10f)]
	[Header("Control de la animacion")]
	[Tooltip("Es la distancia que se separa la camara del objeto en esa coordenada")]
	public Vector3 Lejania;
	float t;

	// Use this for initialization
	void Start () 
	{
		if (cam == null)
		{
			///Si la camara no esta asignado, que se auto asigne
			cam = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera> ();
		}
		Posicion.y = 0.9f;
	}
	
	// Update is called once per frame
	void Update () 
	{
		Tempos = obj.transform.position;
		Tempos.y += Lejania.y;
		t += Time.deltaTime;
		if (t >= (2 * Mathf.PI))
			t = 0;
		Posicion.x = Lejania.x * Mathf.Cos (t);
		Posicion.z = Lejania.z * Mathf.Sin (t);

		cam.transform.LookAt (Tempos);

		cam.transform.position = Posicion;
	}
}
