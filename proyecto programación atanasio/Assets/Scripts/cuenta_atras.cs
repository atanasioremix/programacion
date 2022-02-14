using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cuenta_atras : MonoBehaviour
{
    //declaramos los objetos que vamos a usar
    public GameObject target;
    public GameObject danger;
    //declaramos las variable a usar
    float currentTime = 0f;
    float startingTime = 10f;
    [SerializeField] Text countdownText;

    void Start()
    {
        //le decimos que currentTime es igual a startingtime
        currentTime = startingTime;
    }

    
    void Update()
    {
        //currentTine restara a startingtime
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        //Si llega a 0 se activara target y se desactivara danger
        if (currentTime <= 0)
        {
            target.SetActive(true);
            danger.SetActive(false);
        }
    }
    
}
