using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMover : MonoBehaviour
{

    public float tiempoComienzo;
    public float speed;
    public float rotationSpeed;
    public float limitY;

    

    private void Update()
    {
        if (Time.time >= this.tiempoComienzo)
        {
            if (this.transform.position.y <= this.limitY)
            {
                this.transform.Translate(Vector3.up * this.speed * Time.deltaTime);
            }

            
            if (this.transform.position.y <= -this.limitY)
            {

                this.transform.Translate(Vector3.down * this.speed * Time.deltaTime);
            }
        }

    }
}
