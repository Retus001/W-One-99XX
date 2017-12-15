using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class Movimiento_Fondo : MonoBehaviour {

	void Start()
	{
		Invoke ("CargarOtraScena", 5f);
	}

	void CargarOtraScena()
	{
		EditorSceneManager.LoadScene ("Inicio");
	}
}