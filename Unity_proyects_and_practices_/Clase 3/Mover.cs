using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public float tiempoComienzo;
    public float speed;
    public float rotationSpeed;

	void Start () {
        this.transform.position = new Vector3(5, 5, 5);
        this.transform.eulerAngles = new Vector3(90, 90, 90);

        /*
        new Vector3(0, 0, 0);   // Vector3.zero
        new Vector3(1, 1, 1);   // Vector3.one
        new Vector3(1, 0, 0);   // Vector3.right
        new Vector3(0, 1, 0);   // Vector3.up
        new Vector3(0, 0, 1);   // Vector3.forward
        */
    }
	
	void Update () {
        if (Time.time >= this.tiempoComienzo) {
            this.transform.Translate(Vector3.forward * this.speed * Time.deltaTime, Space.World);
            this.transform.Rotate(Vector3.up * this.rotationSpeed * Time.deltaTime);
        }
        
    }
}
