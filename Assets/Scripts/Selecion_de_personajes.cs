using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class Selecion_de_personajes : MonoBehaviour {

	public Button[] Opciones;

	public int Jugador;

	public void Opcion1()
	{
		Opciones [0].enabled = false;
		if (Jugador >= 2) {
			Invoke ("Cargar", 2f);
		}
		Jugador = 2;
	}

	public void Opcion2()
	{
		Opciones [1].enabled = false;
		if (Jugador >= 2) {
			Invoke ("Cargar", 2f);
		}
		Jugador = 2;
	}

	public void Opcion3()
	{
		Opciones [2].enabled = false;
		if (Jugador >= 2) {
			Invoke ("Cargar", 2f);
		}
		Jugador = 2;
	}

	void Cargar()
	{
		EditorSceneManager.LoadScene ("Load_Screen");
	}
}
