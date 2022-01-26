using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class victima : MonoBehaviour {


    public GameObject box;
    public Transform enemigo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag=="bala")
        {
            transform.localScale = transform.localScale * 1.1f;
            if (this.gameObject.tag=="enemy")
               
            {
                Instantiate(this.box, this.enemigo.position, this.enemigo.rotation);
                Destroy(this.gameObject);
                

            }
           
        }
       
    }


}
