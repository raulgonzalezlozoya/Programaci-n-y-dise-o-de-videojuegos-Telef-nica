using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparo : MonoBehaviour {
    public GameObject bala;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("disparo");
            GameObject miBala;
            miBala=GameObject.Instantiate(bala);
            miBala.transform.position = this.transform.position;
            Rigidbody miRigidbody = miBala.GetComponent<Rigidbody>();
            miRigidbody.velocity=this.transform.up * 50f;
            Destroy(miBala, 4.0f);

        }
	}
}
