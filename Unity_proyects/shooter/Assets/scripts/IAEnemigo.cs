using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAEnemigo : MonoBehaviour
{

    public Transform target;//set target from inspector instead of looking in Update
    public float speed = 3f;


    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {

        //rotacion
        transform.LookAt(target.position);
        transform.Rotate(new Vector3(0, -90, 0), Space.Self);

        //movimiento
        if (Vector3.Distance(transform.position, target.position) > 1f)
        {//move if distance from target is greater than 1
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }

    }

}
