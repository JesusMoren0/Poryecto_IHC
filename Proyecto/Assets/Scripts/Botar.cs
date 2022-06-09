using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botar : MonoBehaviour
{
    protected bool isInsideZone;

    public GameObject dialog;

    void Start()
    {
        if(dialog != null)
        {
            dialog.SetActive(false);
        }
        
    }

    void Update() 
    {
        if(isInsideZone && Input.GetKeyDown(KeyCode.E))
        {
            Interactive();
        }    
    }
   void OnTriggerEnter(Collider otherCollider)
   {
       if(!otherCollider.CompareTag("Player")) return;
       Debug.Log("Collison" + otherCollider.name);
       isInsideZone = true;
       if(dialog != null) dialog.SetActive(true);
   }

   void OnTriggerExit(Collider other)
   {
        if(!other.CompareTag("Player")) return;
        Debug.Log("Collision Exit" + other.name);
        isInsideZone = false;
        if(dialog != null) dialog.SetActive(false);
   }

   protected virtual void Interactive()
   {
       Debug.Log("Doing something");
   }
}
