using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tocar : MonoBehaviour {

	void Start () {
		
	}

	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		Destroy(this.gameObject);
		Debug.Log("Toco el objeto finaliza el juego", gameObject);
        Timer.Activar = true;
	}
}
