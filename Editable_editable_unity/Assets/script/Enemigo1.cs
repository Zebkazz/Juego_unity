using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {

	public GameObject objene;
	public float speed = 5.0F;
	public bool mvade;
	public float psoxini = 0.0F;
	// Use this for initialization
	void Start () {
		mvade = true;
		//Debug.Log (objene.transform.position.z.ToString());
		psoxini = objene.transform.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		moverlado();
	}

	void OnTriggerEnter(Collider other) {
		Timer.Enemigo = true;
        objene.transform.position = new Vector3(50, 50, 50);
    }

	void moverlado(){
		float translation;
		if (mvade == true){
			translation = 1 * speed;
		}else{
			translation = -1 * speed;
		}

		translation *= Time.deltaTime;
		objene.transform.Translate(0, 0, translation);
		if(objene.transform.position.z < (psoxini - 8)){
			mvade = true;
		}else if(objene.transform.position.z > psoxini){
			mvade = false;
		}
	}
}
