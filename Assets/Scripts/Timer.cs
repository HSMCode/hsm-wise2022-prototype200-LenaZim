using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float currentTime = 0f;
    public float startingTime = 60f;

    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime;
    }
   
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = ("TIME: ") + currentTime.ToString ("0");

        if(currentTime <= 0) 
        {
            currentTime = 0;
        }
    }

}