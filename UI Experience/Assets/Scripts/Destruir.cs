using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destruir : MonoBehaviour
{


    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Balas")
        {
            Destroy(gameObject);
            Debug.Log("Enemigo destruido +1 punto imaginario");

        }

    }

}
