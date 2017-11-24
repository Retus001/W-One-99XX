using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverIA : MonoBehaviour
{
	Hover control; //Controlar nave
	//Asignar que puede detectar el carro
	public LayerMask raycastMask;

	void Start ()
	{
		//Obtenemos control
		control = GetComponent<Hover> ();
	}
	

	void Update ()
	{
		bool adelante = VerificadorParedFrente (10.0f, transform.forward);
		//Si esta libre, avanzamos a 1.0f, si hay algo, bajamos a 0.3f
		float vertical = (adelante) ? 0f : 1f;

		float horizontal = 0f;
		bool AfrenteDer = VerificadorPared(transform.TransformDirection(new Vector3(0.5f, 0.0f, 0.5f)));
		bool AfrenteIzq = VerificadorPared(transform.TransformDirection(new Vector3(-0.5f, 0.0f, 0.5f)));

		horizontal += (AfrenteDer == false) ? 0f : -1.0f; //debo girar a la izquierda
		horizontal += (AfrenteIzq == false) ? 0f : 1.0f; //debo girar a la derecha

		//Caso que ya muy pegado a algo
		if (adelante && AfrenteDer && AfrenteIzq)
		{
			//Lanzamos laterales
			bool Der = VerificadorPared(transform.TransformDirection(new Vector3(0.5f, 0.0f, 0.0f)));
			bool Izq = VerificadorPared(transform.TransformDirection(new Vector3(-0.5f, 0.0f, 0.0f)));

			horizontal += (Der == false) ? 0f : -1.0f; //debo girar a la izquierda
			horizontal += (Izq == false) ? 0f : 1.0f; //debo girar a la derecha
		}

		//Simulamos teclado
		control.Vertical = vertical;
		control.Horizontal = horizontal;
	}

	const float RayDist = 7.0f;
	bool VerificadorPared(Vector3 _dir)
	{
		Vector3 pos = transform.position;
		//RaycastHit hit;

		bool impacto= Physics.Raycast (pos, _dir, RayDist, raycastMask);
		if (impacto)
		{
			Debug.DrawLine(pos, pos + _dir * RayDist, Color.red);
		}
		else
		{
			Debug.DrawLine(pos, pos + _dir * RayDist, Color.yellow);
		}
		return impacto;
	}
	bool VerificadorParedFrente(float _dis, Vector3 _dir)
	{

		Vector3 pos = transform.position;
		//RaycastHit hit;

		bool impacto= Physics.Raycast (pos, _dir, _dis, raycastMask);
		if (impacto)
		{
			Debug.DrawLine(pos, pos + _dir * _dis, Color.red);
		}
		else
		{
			Debug.DrawLine(pos, pos + _dir * _dis, Color.yellow);
		}
		return impacto;
	}
}
