using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalJuego : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.name == "Player"){
			Timer.Enemigo = true;
			if(Input.GetKeyDown("i")){
            Timer.Activar = false;
		    Timer.Enemigo = false;
            SceneManager.LoadScene("nivel2");
            }
		}
		//Debug.Log("Me toco y perdi");
	}
}
