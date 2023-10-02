using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2 : MonoBehaviour {

	public GameObject objene;
	public float speed = 8.0F;
	public bool mvade;
	public float psoxini = 0.0F;
	// Use this for initialization
	void Start () {
		mvade = true;
		Debug.Log (objene.transform.position.x.ToString());
		psoxini = objene.transform.position.x;
	}

	// Update is called once per frame
	void Update () {
		moverlado();
	}

	void OnTriggerEnter(Collider other) {
		Timer.Enemigo = true;
    }

	void moverlado(){
		float translation;
		if (mvade == true){
			translation = 1 * speed;
		}else{
			translation = -1 * speed;
		}

		translation *= Time.deltaTime;
		objene.transform.Translate(translation, 0, 0);
		if(objene.transform.position.x > (psoxini + 5)){
			mvade = false;
		}else if(objene.transform.position.x < psoxini){
			mvade = true;
		}
	}
}
