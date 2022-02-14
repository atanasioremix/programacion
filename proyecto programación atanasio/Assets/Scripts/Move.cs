using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //Para ver la velocidad de la bala
    public Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(velocity);
    }

    //Método para saber cuando las balas colisionan contra cualquier objeto
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Si el objeto contra el que colisionan es el circulo
        if (collision.gameObject.CompareTag("Asteroid"))
        {     
            //Desactivamos el circulo concreto
            collision.gameObject.SetActive(false);
        }
    }
}
