using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiator : MonoBehaviour {

    public GameObject Sphere;







	// Use this for initialization
	void Start () {
        Instantiate(this.Sphere, this.transform.position, this.transform.rotation
           );
	}
	
	// Update is called once per frame
	void Update () {


		
	}
}
