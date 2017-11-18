using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_P2 : MonoBehaviour {

	Rigidbody rig;
	Quaternion rot_;
	public float velocity;
	public float speed;
	public float turnspeed;
	public float acceleration;
	public ParticleSystem T01;
	public ParticleSystem T02;
	bool T_Active;
	bool setT = false;
	float holdtime;
	
	// Use this for initialization
	void Start () {
		rig = GetComponent <Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 rigVel = rig.velocity;
		velocity = rig.velocity.x;

		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			holdtime += acceleration;
			T_Active = true;
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
		}

		if(holdtime <= -2)
			holdtime = -2.0f;

		if (holdtime >= -0.1f && holdtime <= 0.1f && !Input.GetKey (KeyCode.UpArrow) && !Input.GetKey (KeyCode.DownArrow))
			holdtime = 0.0f;

		if (holdtime >= 2)
			holdtime = 2.0f; 

		rigVel = holdtime * speed * gameObject.transform.forward;
		rig.velocity = rigVel;
	}
}
