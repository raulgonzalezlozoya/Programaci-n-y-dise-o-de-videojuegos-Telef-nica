using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo : MonoBehaviour {
    public float speedForward;
    public float speedRight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Debug.Log("Eje vertical" + Input.GetAxis("Vertical"));

        if (Input.GetAxis("Vertical") != 0.0f)
            this.transform.Translate(Vector3.forward * this.speedForward * Input.GetAxis("Vertical") * Time.deltaTime);



        //if (Input.GetAxis("Horizontal") != 0.0f)
            //this.transform.Translate(Vector3.right * this.speedForward * Input.GetAxis("Horizontal") * Time.deltaTime);
       
        
        
        
        
        
        
        
        /*
        if (Input.GetKey(KeyCode.W))
        this.transform.Translate(Vector3.forward * this.speedForward * Time.deltaTime);


        if (Input.GetKey(KeyCode.S))
            this.transform.Translate(-Vector3.forward * this.speedForward * Time.deltaTime);



        if (Input.GetKey(KeyCode.D))
            this.transform.Translate(Vector3.right * this.speedRight * Time.deltaTime);



        if (Input.GetKey(KeyCode.A))
            this.transform.Translate(-Vector3.right * this.speedRight * Time.deltaTime);
            */
    }
}
