using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyInvis : MonoBehaviour
{
    //Cuando un objeto no se ve
    private void OnBecameInvisible()
    {
        //Desactivar Objeto
        this.gameObject.SetActive(false);
    }
}
