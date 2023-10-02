using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalJuego1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.name == "Player"){
			Timer.Enemigo = true;
			if(Input.GetKeyDown("c")){
            Timer.Activar = false;
		    Timer.Enemigo = false;
            SceneManager.LoadScene("credito");
            }
		}
		//Debug.Log("Me toco y perdi");
	}
}
