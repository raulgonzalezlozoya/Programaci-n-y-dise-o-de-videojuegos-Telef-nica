using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounds : MonoBehaviour {


    public AudioClip bug;











	// Use this for initialization
	void Start () {

       
        // AudioSource.PlayClipAtPoint(this.bug, this.transform.position);
       // AudioSource.PlayClipAtPoint(this.bug, Camera.main.transform.position);



	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            this.GetComponent<AudioSource>().clip = this.bug;




        }
    }
}
