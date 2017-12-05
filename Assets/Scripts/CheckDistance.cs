using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckDistance : MonoBehaviour {

	public GameObject piv;
	public GameObject check;
	public float dist;
	public float checkcount;

	// Use this for initialization
	void Start () {
		checkcount = 1;
		check = GameObject.Find (string.Concat("CP",checkcount.ToString()));
	}
	
	// Update is called once per frame
	void Update () {
		dist = Mathf.Sqrt (Mathf.Pow (piv.transform.position.x - check.transform.position.x, 2.0f) + Mathf.Pow (piv.transform.position.y - check.transform.position.y, 2.0f) + Mathf.Pow (piv.transform.position.z - check.transform.position.z, 2.0f));
	}

	public void ChangeCheck()
	{
		checkcount++;
		check = GameObject.Find (string.Concat("CP",checkcount.ToString()));
	}
}
