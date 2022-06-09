using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Botar
{
     private Rigidbody rb;
     public Vector3 direction;
     public float kickforce = 10f;
    void Start() 
    {
        rb = GetComponent<Rigidbody>();
    }
    protected override void Interactive()
    {
        base.Interactive();
        //Patear la esfera
        rb.AddForce(direction * kickforce);
    }
}
