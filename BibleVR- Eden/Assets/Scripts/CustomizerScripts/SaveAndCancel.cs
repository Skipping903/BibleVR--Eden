using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveAndCancel : InitiateCustom
{
    private Vector3 charSpawnpoint = new Vector3(528.99f, 519.17f, 520.09f);
    private Quaternion charSpawnRotation = Quaternion.Euler(0f, 37f, 0f);
    private Quaternion tempRotation = Quaternion.Euler(0f, 37.726f, 0f);
    private GameObject currChar;
    public GameObject changedChar, charPosition;

    void Awake()
    {
        this.currChar = GameObject.FindGameObjectWithTag("Player");
    }

    public void SaveChanges()
    {
        this.currChar = changedChar;
        this.charPosition.transform.position = this.charSpawnpoint;
        this.charPosition.transform.rotation = this.charSpawnRotation;
        CustomizerUI.SetActive(false);
        creatorBody.transform.rotation = this.tempRotation;
        creatorBody.SetActive(false);
        isEnabled = false;
        mainBody.SetActive(true);
    }

    void CancelChanges()
    {

    }
}//Class
