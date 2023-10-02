using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caja : MonoBehaviour {

	private int con = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		con += 1;
		Debug.Log(con);
    }


}
