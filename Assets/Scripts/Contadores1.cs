using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Contadores1 : MonoBehaviour {

	//[HideInInspector]
	public int checkpoint;
	//[HideInInspector]
	public int rounds;

	// Use this for initialization
	void Start () {
		checkpoint = 1;
		rounds = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (rounds == 3)
			SceneManager.LoadScene ("Win1");
	}
}
