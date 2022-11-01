using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SeguirObjetivo : MonoBehaviour
{
    public Transform objetivo;
    public UnityEngine.AI.NavMeshAgent agente;
    public ControlENE controller;


    //void Start()
    //{
    //    agente = GetComponent<UnityEngine.AI.NavMeshAgent>();
    //    agente.speed = controller.Dificultad;

    //}

    void FixedUpdate()
    {
        NavMeshAgent agente = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agente.destination = objetivo.position;
    }  
}
