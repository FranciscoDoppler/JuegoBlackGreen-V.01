using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    int Contador = 30;
    public Text timerUI;

    void Start()
    {
        terminarContador();
    }
    void terminarContador()
    {

        if (Contador > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(Contador);
            timerUI.text = "Timer: " + spanTime.Seconds;
            Contador--;
            Invoke("terminarContador", 1.0f);

        }
        else
        {
            timerUI.text = "GameOver!";
            SceneManager.LoadScene(2);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
