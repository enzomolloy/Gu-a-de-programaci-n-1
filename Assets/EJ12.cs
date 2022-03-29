//12. En un casino de juegos se desea mostrar los mensajes respectivos por el puntaje obtenido en el lanzamiento 
//de tres dados de un cliente, de acuerdo a los siguientes  resultados: 
//Si los tres dados son seis, mostrar el mensaje “Excelente” 
//Si dos dados son seis, mostrar el mensaje “Muy bien”  
//Si un dado es seis, mostrar el mensaje “Regular”  
//Si ningún dado se obtiene seis, mostrar el mensaje “Insuficiente” 


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EJ12 : MonoBehaviour
{
    public int dado1, dado2, dado3;

    int cantseis = 0;

    void Start()
    {
        if (dado1 == 6)
        {
            cantseis++;
        }
        if (dado2 == 6)
        {
            cantseis++;
        }
        if (dado3 == 6)
        {
            cantseis++;
        }

        switch (cantseis)

        {
            case 3:
                Debug.Log("Excelente");
                break;
        
        
            case 2:
                Debug.Log("Muy Bien");
            break;
        
        
            case 1:
                Debug.Log("Regular");
            break;

            default:
                Debug.Log("Insuficiente");
                break;


        }
    }

    
    void Update()
    {
        
    }
}
