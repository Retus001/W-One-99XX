using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicaFondo_Camara : MonoBehaviour {
	AudioSource AS;
	AudioClip S1;

	// Use this for initialization
	void Start () {
		AS.GetComponent<AudioSource> ();
		S1.Equals ("SFX/the offpring - all i want");
		AS.PlayOneShot(S1);
	}
}
