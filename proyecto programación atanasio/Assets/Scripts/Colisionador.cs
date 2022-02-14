using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Colisionador : MonoBehaviour
{
    //declaramos el objeto que queremos utilizar
    public GameObject target;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //cuando el circulo colisiones al jugador aparecerá una imagen
        if(collision.CompareTag ("Asteroid"))
        {
            target.SetActive(true);
        }
    }

}
