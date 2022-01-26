using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour {

    public float speedX;
    public float speedY;
    public float limitX;
    public float limitY;
    public float rotationSpeed;
    
    public float maxSize;
    private bool juegoEmpezado = false;
    private bool subiendo = true;


    void Update () {

        if (Input.GetButtonDown("Fire1")) {
            this.juegoEmpezado = true;
        }

        if (this.juegoEmpezado == true)
        {
            if (this.transform.localScale.x <=this.maxSize)
            {


            }
            if (this.transform.position.x < this.limitX)
            {
                this.transform.Translate(Vector3.right * this.speedX * Time.deltaTime, Space.World);
                this.transform.Rotate(Vector3.forward * this.rotationSpeed * Time.deltaTime);
            }
            else
            {
                this.speedY = 0.0f;
            }

            if (this.subiendo)
            {
                if (this.transform.position.y <= this.limitY)
                {
                    this.transform.Translate(Vector3.up * this.speedY * Time.deltaTime, Space.World);
                    this.transform.Rotate(Vector3.forward * this.rotationSpeed * Time.deltaTime);
                }
                else
                {
                    this.subiendo = false;
                }
            }
            else
            {
                if (this.transform.position.y >= -this.limitY)
                {
                    this.transform.Translate(-Vector3.up * this.speedY * Time.deltaTime, Space.World);
                    this.transform.Rotate(Vector3.forward * this.rotationSpeed * Time.deltaTime);
                }
                else
                {
                    this.subiendo = true;
                }
            }
        }
    }
}
