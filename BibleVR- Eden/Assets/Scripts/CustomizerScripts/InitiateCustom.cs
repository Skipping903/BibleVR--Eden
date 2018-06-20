using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiateCustom : MonoBehaviour
{
    private GameObject playerHands;
    public GameObject CustomizerUI, creatorBody, mainBody;
    public bool isEnabled;

    void Awake ()
    {
        this.playerHands = GameObject.FindGameObjectWithTag("Player");
        this.GetComponent<CameraRotate>();
    }

    void Start()
    {
        this.CustomizerUI.SetActive(false);
        this.creatorBody.SetActive(false);
        this.mainBody.SetActive(true);
        this.isEnabled = false;
    }

    void OnTriggerEnter(Collider currCollision)
    {
        if (currCollision.gameObject.tag == "Player")
        {
            currCollision.GetComponent<Collider>().isTrigger = true;
            this.CustomizerUI.SetActive(true);
            this.creatorBody.SetActive(true);
            this.mainBody.SetActive(false);
            this.isEnabled = true;
        }
    }
}//class
