using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {

	void Start ()
    {

        // para este ejercicio, escribir el código aquí
        // Se pueden usar las funciones:
        //      Avanzar()
        //      GirarDerecha()
        //      GirarIzquierda()
        // Y las comprobaciones siguientes:
        //      TrofeoConseguido
        //      BordeDelante
        //      VisitadaDelante

        //ejemplo
        /*Avanzar();
        GirarIzquierda();
        for(int i=0;i<4;i++)
        {
            Avanzar();
        }
        */
       
        while ( !TrofeoConseguido )
        {
           
                while (BordeDelante || VisitadaDelante) 
            {


                GirarIzquierda();

            }
            Avanzar();

        }

        
	}







    // no cambiar nada a partir de aquí
    private Trofeo trofeo;
    private LineRenderer lineRenderer;
    private int fila = 0;
    private int columna = 2;
    private enum Direcciones { norte,sur,este,oeste };
    private Direcciones direccion = Direcciones.este;
    private int pasos = 0;
    private bool TrofeoConseguido = false;
    private bool[,] huellas = new bool[5,5];

    private bool BordeDelante
    {
        get
        {
            if(direccion==Direcciones.norte && fila==4)
            {
                return true;
            }
            if(direccion==Direcciones.sur && fila==0)
            {
                return true;
            }
            if(direccion==Direcciones.este && columna==4)
            {
                return true;
            }
            if(direccion==Direcciones.oeste && columna==0)
            {
                return true;
            }
            return false;
        }
    }
    private bool VisitadaDelante
    {
        get
        {
            if (direccion == Direcciones.norte && fila < 4 && fila>=0)
            {
                return huellas[fila + 1, columna];
            }
            if (direccion == Direcciones.sur && fila <= 4 && fila > 0)
            {
                return huellas[fila - 1, columna];
            }
            if (direccion == Direcciones.este && columna<4 && columna>=0)
            {
                return huellas[fila, columna + 1];
            }
            if (direccion == Direcciones.oeste && columna <= 4 && columna > 0)
            {
                return huellas[fila, columna - 1];
            }
            return false;
        }
    }


    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        trofeo = FindObjectOfType<Trofeo>();
        huellas[fila, columna] = true;
    }

    private void Avanzar()
    {
        if(direccion==Direcciones.norte)
        {
            fila++;
        }
        else if(direccion==Direcciones.sur)
        {
            fila--;
        }
        else if(direccion==Direcciones.este)
        {
            columna++;
        }
        else if(direccion==Direcciones.oeste)
        {
            columna--;
        }
        if(fila>=0 && fila<=4 && columna>=0 && columna<=4)
        {
            huellas[fila, columna] = true;
        }
        lineRenderer.positionCount++;
        pasos++;
        Vector3 nuevaPosicion = new Vector3(-4f + columna * 2f, -4f + fila * 2f, -0.5f);
        lineRenderer.SetPosition(pasos, nuevaPosicion);
        transform.position = nuevaPosicion;
        if(fila==trofeo.fila && columna==trofeo.columna)
        {
            TrofeoConseguido = true;
        }
    }
    void GirarDerecha()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z - 90f);
        if (direccion == Direcciones.norte)
        {
            direccion = Direcciones.este;
        }
        else if (direccion == Direcciones.sur)
        {
            direccion = Direcciones.oeste;
        }
        else if (direccion == Direcciones.este)
        {
            direccion = Direcciones.sur;
        }
        else if (direccion == Direcciones.oeste)
        {
            direccion = Direcciones.norte;
        }
    }
    void GirarIzquierda()
    {
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z + 90f);
        if (direccion == Direcciones.norte)
        {
            direccion = Direcciones.oeste;
        }
        else if (direccion == Direcciones.sur)
        {
            direccion = Direcciones.este;
        }
        else if (direccion == Direcciones.este)
        {
            direccion = Direcciones.norte;
        }
        else if (direccion == Direcciones.oeste)
        {
            direccion = Direcciones.sur;
        }
    }
}
