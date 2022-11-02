using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{

    public GameObject BalaInicio;
   
    public GameObject BalaPrefab;  
    public float BalaVelocidad;
    private float TimeBala = 0;
    public float showRate = 0.5f;
    
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (Time.time > TimeBala)
            {
               
                GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position, BalaInicio.transform.rotation) as GameObject;               
                Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();               
                rb.AddForce(transform.forward * BalaVelocidad);
                TimeBala = Time.time + showRate;
                Destroy(BalaTemporal, 5.0f);
                TimeBala += Time.deltaTime;
            }
        }
    }
}
