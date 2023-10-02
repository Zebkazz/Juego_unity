using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CodBotones : MonoBehaviour {

	public void Jugar(){
		Timer.Activar = false;
		Timer.Enemigo = false;
		SceneManager.LoadScene("nivel");
	}

	public void Credito(){
		SceneManager.LoadScene("credito");
	}
	public void Control(){
		SceneManager.LoadScene("control");
	}

	public void Cerrar(){
		SceneManager.LoadScene("mains");
	}
	public void Salir(){
		Application.Quit();
	}
}
