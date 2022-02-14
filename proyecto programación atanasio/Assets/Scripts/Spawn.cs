using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //invocación al objeto que queremos hacer aparecer
    public GameObject asteroid;

    // Update is called once per frame
    void Update()
    {
        //Los circulos saldrán si el número aleatorio entre 0 y 100 sale menor que 3
        if (Random.Range(0, 100) < 3)
        {
            //Creamos una invocación al objeto de la lista de objetos creados mediante el Pool
            GameObject a = Pool.singleton.Get("Asteroid");
            //Si el objeto que he recibido no está vacío(osea que se puede usar)
            if (a != null)
            {
                //Le pasamos una posición a ese circulo concreto
                a.transform.position = this.transform.position + new Vector3(Random.Range(-10, 10), 0, 0);
                //Y activamos el circulo
                a.SetActive(true);
            }
        }

    }
}
