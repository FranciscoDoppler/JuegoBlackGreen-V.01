using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestruirPlayer : MonoBehaviour
{
    public int hit = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemigos")
        {
            hit++;
            Debug.Log("Numero de hits recibidos: " + hit.ToString());         
            Checkeo();

        }

    }
    private void Checkeo()
    {
        if (hit == 3)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);

        }

    }
}
