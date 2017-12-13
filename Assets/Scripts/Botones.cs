using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class Botones : MonoBehaviour {

	public void Salir()
	{
		Application.Quit();
	}

	public void Info()
	{
		
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
