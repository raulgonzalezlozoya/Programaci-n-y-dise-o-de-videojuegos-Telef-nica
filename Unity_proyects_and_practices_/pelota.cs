using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota : MonoBehaviour {
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            Debug.Log("Tocada pelota " + collision.transform.name);
        }





    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		


	}
}
