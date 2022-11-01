using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destruir : MonoBehaviour
{
    public int puntaje = 0;
    public TMPro.TMP_Text Puntajen;

    void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Enemigos")
        {
            Destroy(gameObject);

            //puntaje++;

            //Puntajen.text = puntaje.ToString();

        }

    }

    //private void OnTriggerEnter(Collider other)
    //{

    //    if (other.gameObject.tag == "Balas")
    //    {
    //        Destroy(GameObject.FindGameObjectWithTag("Enemigos"));
    //        puntaje++;
    //        Puntajen.text = puntaje.ToString();

    //    }
    //}
}
