using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverR : MonoBehaviour {

	public float speed=3.0F;
	public float rotationSpeed=100.0F;
    public int fuerza = 210;
    public Transform myTransform;
	//public Transform myBola;

	// Use this for initialization
	void Start () {
		myTransform = transform;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
            gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, fuerza, 0));
        }
	}

	void FixedUpdate(){
		float Horizontal;
		float Vertical;
        if (Timer.Activar == false && Timer.Enemigo == false){
            if (SystemInfo.deviceType == DeviceType.Desktop)
            {
                Horizontal = Input.GetAxis("Horizontal");
                Vertical = Input.GetAxis("Vertical");
            }
            else
            {
                Horizontal = Input.acceleration.x;
                Vertical = Input.acceleration.y;
            }
            myTransform.position += myTransform.forward * speed * Time.deltaTime * Vertical;
            //myBola.Rotate(rotationSpeed * Vertical * Time.deltaTime, 0, 0);
            myTransform.eulerAngles += new Vector3(0, rotationSpeed * Time.deltaTime * Horizontal, 0);
        }
	}

    public void saltar()
    {
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, fuerza, 0));
    }
}
