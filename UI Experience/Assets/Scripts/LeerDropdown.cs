using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeerDropdown : MonoBehaviour
{
    public TMPro.TMP_Dropdown dropdown;

    public void GetDataDD() 
    {
        Debug.Log("Dropdown: " + dropdown.options[dropdown.value].text);
    }
}
