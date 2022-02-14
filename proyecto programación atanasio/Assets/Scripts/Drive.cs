 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    public float speed = 10.0f;
    //invocación publica a la bala que dispara el cuadrado
    public GameObject bullet;

    void Update()
    {
        //Movimiento del Cuadrado
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        transform.Translate(translation, 0, 0);

        //Al pulsar espacio
        if (Input.GetKeyDown("space"))
        {
            //Creamos una invocación al objeto de la lista de objetos creados mediante el Pool
            GameObject b = Pool.singleton.Get("Bullet");
            //Si el objeto que he recibido no está vacío(vamos que se puede usar)
            if (b != null)
            {
                //Igualamos la posición de esa bala con la del cuadrado
                b.transform.position = this.transform.position;
                //Y activamos la bala
                b.SetActive(true);
            }
        }
    }
}