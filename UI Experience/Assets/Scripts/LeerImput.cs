using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeerImput : MonoBehaviour
{
    public TMPro.TMP_InputField inputFiel;

    public void GetData()
    {
        string cadena = "";
        cadena = inputFiel.text;
        Debug.Log(cadena);

        PlayerPrefs.SetString("Nombre", cadena);

        Debug.Log("El nombre del player es: " + PlayerPrefs.GetString("Nombre"));
    }


}
