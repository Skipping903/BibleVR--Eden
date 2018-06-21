using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//this script only needs to be on while in a place characters should be able to change their class.
public class GhostSwap : MonoBehaviour
{
    //switches from current character to desired character on contact of characters

    public Transform mainCamera;

    public string standingOne = "";

    public bool allowedToCollide = true;

    void Awake()
    {
        this.mainCamera = GameObject.Find("Main Camera").transform;
    }

    private void Start()
    {
        this.mainCamera.parent = this.transform;
    }

    private void Update()
    {
        if (this.transform.childCount > 0)
        {
            if (this.transform.GetChild(0).name == "Main Camera")
            {
                this.mainCamera.position = this.transform.position;
                this.mainCamera.rotation = this.transform.rotation;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Plane" && this.allowedToCollide && other.gameObject.name != "New Character" &&
            other.gameObject.name != "TriggerEnable")// not required if plane or terrain does not have a collider enabled. had some issues with it activating trigger events.
        {
            this.allowedToCollide = false;
            //GameObject.Find("WakeUp").GetComponent<Awaken>().allowedToFill = true;
            this.mainCamera.rotation = other.gameObject.transform.rotation; //if error, this might be it
            this.mainCamera.position = other.gameObject.transform.position;
            this.mainCamera.parent = other.gameObject.transform;        

            this.standingOne = other.gameObject.name;
            //turns trigger for new character off and movement for old character off
            other.GetComponent<Collider>().isTrigger = false;
            other.gameObject.GetComponent<SwapClass>().allowedToCollide = true;
            this.GetComponent<AWSDMove>().enabled = false;

            //turns movement on for new character and trigger for old character off
            other.GetComponent<AWSDMove>().enabled = true;
            this.GetComponent<Collider>().isTrigger = true;

            Destroy(this.gameObject, 0f);
        }
    }
}

