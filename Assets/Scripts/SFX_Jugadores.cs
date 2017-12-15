using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SFX_Jugadores : MonoBehaviour {
	public AudioSource AS;
	AudioClip push;
	AudioClip poom;

	void Start () {
		AS.GetComponent<AudioSource> ();
		push.Equals(Resources.Load ("SFX/poosh"));
		poom.Equals(Resources.Load("SFX/1 boom"));
	}
	void Update () {
	}

	void OnCollisionEnter(Collision _col)
	{
		if (gameObject.CompareTag ("P1") && _col.gameObject.CompareTag ("P2")) {
			AS.PlayOneShot (push);
		}
		if (gameObject.CompareTag ("P2") && _col.gameObject.CompareTag ("P1")) {
			AS.PlayOneShot (push);
		}
		if (_col.gameObject) {
			AS.PlayOneShot (poom);
		}
	}
}
