using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicaFondo_Camara : MonoBehaviour {
	public AudioSource AS;
	public AudioClip S1;
	public AudioClip S2;
	public AudioClip S3;

	// Use this for initialization
	void Start () {
		AS.GetComponent<AudioSource> ();
		AS.PlayOneShot(S1);
	}
}
