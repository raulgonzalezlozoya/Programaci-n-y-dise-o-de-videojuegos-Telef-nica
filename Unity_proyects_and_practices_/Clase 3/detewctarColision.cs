using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detewctarColision : MonoBehaviour {
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "greenSphere")
        {
            Debug.Log("Me ha tocado una esfera " + collision.transform.name);
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
