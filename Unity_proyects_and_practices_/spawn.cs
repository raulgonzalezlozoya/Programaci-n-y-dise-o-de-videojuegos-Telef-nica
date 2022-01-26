using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{


    public GameObject enemigo;
    public Transform instanciador;
    public float tiempoEntreEnemigo;


    private float tiempoEnemigo = 0.0f;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - this.tiempoEnemigo >= this.tiempoEntreEnemigo)
        {
            Instantiate(this.enemigo, this.instanciador.position, this.instanciador.rotation);
            this.tiempoEnemigo = Time.time;
        }
    }
}
    
