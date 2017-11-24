using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSystem : MonoBehaviour {

	public int CheckPoint;
	GameObject[] Checks;

	void OnTriggerEnter(Collider _col)
	{
		if (_col.gameObject.CompareTag("P1"))
		{
			if (_col.GetComponent<Movement_P1>().checkpoint == CheckPoint)
			{
				if (CheckPoint == 0)
				{
					_col.GetComponent<Movement_P1> ().rounds++;
				}
				if (CheckPoint == Checks.Length-3)
				{
					_col.GetComponent<Movement_P1> ().checkpoint = 0;
				}
				else
					_col.GetComponent<Movement_P1> ().checkpoint++;
			}
		}
	}

	// Use this for initialization
	void Start () {
		Checks = GameObject.FindGameObjectsWithTag ("CheckPoint");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
