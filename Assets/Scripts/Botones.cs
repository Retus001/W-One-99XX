using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Botones : MonoBehaviour {

	public int clilcs;
	public AudioSource mixer;
	public AudioClip villancicos;

	public void Salir()
	{
		Application.Quit();
	}

	public void Info()
	{
		mixer.PlayOneShot (villancicos);
		clilcs++;
		if(clilcs >= 100)
		{
			mixer.PlayOneShot (villancicos);
			clilcs = 0;
		}
	}

	public void Comezar()
	{
		EditorSceneManager.LoadScene ("Seleccion_personaje");
	}

	public void Regresar()
	{
		EditorSceneManager.LoadScene ("Inicio");
	}
}
