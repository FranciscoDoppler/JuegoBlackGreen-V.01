using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carga : MonoBehaviour
{
    private GameObject Nombre;
    private GameObject Puntaje;

    private void Start()
    {
        Nombre = GameObject.FindGameObjectWithTag("Nombre");
        Nombre.GetComponent<TMPro.TMP_Text>().text = PlayerPrefs.GetString("Nombre");

        //Puntaje = GameObject.FindGameObjectWithTag("Puntaje");
        //Puntaje.GetComponent<TMPro.TMP_Text>().text = PlayerPrefs.GetString("Puntaje");
    }
}
