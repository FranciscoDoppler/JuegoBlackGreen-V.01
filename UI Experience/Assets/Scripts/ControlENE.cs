using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlENE : MonoBehaviour
{
    public GameObject[] enemigos;
    public Transform[] posiciones;

    [SerializeField]
    [Range(1, 3)]

    public int Dificultad = 1;

    private void Start()
    {
        enemigos[0].transform.position = posiciones[0].position;
        enemigos[1].transform.position = posiciones[1].position;
        enemigos[2].transform.position = posiciones[2].position;
    }


}
