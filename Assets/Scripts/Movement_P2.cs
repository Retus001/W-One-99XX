﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement_P2 : MonoBehaviour {

	Rigidbody rig;
	public Camera cam;
	public GameObject piv_;
	public float velocity;
	public float speed;
	public float turnspeed;
	public float acceleration;
	public float tiltspd;
	public ParticleSystem T01;
	public ParticleSystem T02;
	bool T_Active;
	bool setT = false;
	float holdtime;
	//[HideInInspector]
	public int checkpoint;
	//[HideInInspector]
	public int rounds;
	
	// Use this for initialization
	void Start () {
		rig = GetComponent <Rigidbody>();
		checkpoint = 1;
		rounds = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (rounds == 3)
			SceneManager.LoadScene ("Win");

		Vector3 rigVel = rig.velocity;
		Quaternion pivrot = piv_.transform.localRotation;
		velocity = rig.velocity.x;

		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			holdtime += acceleration;
			T_Active = true;
			if (pivrot.x < 0.5f)
				pivrot.x += 0.5f * Time.deltaTime / tiltspd;
			if (cam.fieldOfView <= 80)
				cam.fieldOfView += 10 * Time.deltaTime;
		}
		else if (holdtime > 0)
		{
			holdtime -= acceleration;
			T_Active = false;
		}

		if (Input.GetKeyDown (KeyCode.UpArrow) || Input.GetKeyUp (KeyCode.UpArrow))
			setT = false;	

		if (Input.GetKey (KeyCode.DownArrow)) 
			holdtime -= acceleration;
		else if (holdtime < 0)
			holdtime += acceleration;

		if (Input.GetKey (KeyCode.LeftArrow)) 
			transform.Rotate (Vector3.down * turnspeed * Time.deltaTime);
		else if (Input.GetKey (KeyCode.RightArrow)) 
			transform.Rotate (Vector3.up * turnspeed * Time.deltaTime);
		else
			GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;

		if (T_Active)
		{
			if (!setT)
			{
				T01.Play ();
				T02.Play ();
				setT = true;
			}
		}
		else
		{
			if (!setT)
			{
				T01.Stop ();
				T02.Stop ();
				setT = true;
			}
			if (pivrot.x > 0)
				pivrot.x -= 0.5f * Time.deltaTime / tiltspd;
			if (cam.fieldOfView >= 60)
				cam.fieldOfView -= 10 * Time.deltaTime;
		}

		if(holdtime <= -2)
			holdtime = -2.0f;

		if (holdtime >= -0.1f && holdtime <= 0.1f && !Input.GetKey (KeyCode.UpArrow) && !Input.GetKey (KeyCode.DownArrow))
			holdtime = 0.0f;

		if (holdtime >= 2)
			holdtime = 2.0f; 

		rigVel = holdtime * speed * gameObject.transform.forward;
		piv_.transform.localRotation = pivrot;
		rig.velocity = rigVel;
	}
}
