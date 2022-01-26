using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour {

    public float speed;

    // Use this for initialization
    void Start()
    {
        this.transform.Translate(Vector3.forward * this.speed);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * this.speed);
    }
}
