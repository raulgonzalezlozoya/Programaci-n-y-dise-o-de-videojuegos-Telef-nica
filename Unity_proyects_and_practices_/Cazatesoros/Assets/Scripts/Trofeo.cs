using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trofeo : MonoBehaviour {

    public int fila = 0;
    public int columna = 2;

	void Awake ()
    {
        do
        {
            fila = Random.Range(0, 5);
            columna = Random.Range(0, 5);
        } while (fila == 0 && columna == 2);
        
        transform.position = new Vector3(-4f + columna * 2f, -4f + fila * 2f, -1f);
	}
}
