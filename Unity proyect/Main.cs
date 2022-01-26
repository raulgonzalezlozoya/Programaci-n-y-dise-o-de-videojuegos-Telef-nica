using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {




    public GameObject cube;
    public Transform instanciador;
    public float tiempoEntreCubos;


    private float tiempoUltimoCubo = 0.0f;




	// Use this for initialization
	void Start () {
        Instantiate(this.cube, this.instanciador.position, this.instanciador.rotation);
	}
	
	// Update is called once per frame
	void Update () {




        //if (Input.GetButtonDown("Fire1")) 


        if (Time.time - this.tiempoUltimoCubo >= this.tiempoEntreCubos)
        {
            Instantiate(this.cube, this.instanciador.position, this.instanciador.rotation);
            this.tiempoUltimoCubo = Time.time;
        }






    }
}
