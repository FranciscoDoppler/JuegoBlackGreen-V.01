using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuardarNombre : MonoBehaviour
{
    public TMPro.TMP_InputField inputName;
    public TMPro.TMP_Text textoName;

    public void GuardarN() 
    {
        PlayerPrefs.SetString("Nombre", inputName.text);
        Debug.Log("Nombre Guardado");
    }
    

}
