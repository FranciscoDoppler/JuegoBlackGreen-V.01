using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Guardar : MonoBehaviour
{
    public Toggle toggle;

    public void LeeTog()
    {
        if (toggle.isOn)
        {
            Debug.Log("Usara escena de dia");
        }
        else
        {
            Debug.Log("Usara escena de noche");
        }
            
    }
}
