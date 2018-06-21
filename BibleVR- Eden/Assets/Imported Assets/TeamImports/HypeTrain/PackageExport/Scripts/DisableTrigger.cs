using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableTrigger : MonoBehaviour         //find a way to make the plane not activate the triggers
{	
    void OnTriggerEnter(Collider other)
    {
        if (other.name != "Plane" && other.name != "New Character")
        {
            other.gameObject.GetComponent<Collider>().isTrigger = true;
            Debug.Log(other.name + "entered");
        }
    }

    void OnTriggerExit (Collider other)
    {
        if(other.name != "Plane" && other.name != "New Character")
        {
            other.gameObject.GetComponent<Collider>().isTrigger = false;
            Debug.Log(other.name + "exited");

        }
    }
}
