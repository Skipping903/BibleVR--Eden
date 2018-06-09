using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject creator;

    private Vector3 cameraHeight = new Vector3(0, 3.5f, 0);

    void Update()
    {
        Follow(this.creator);
    }

    void Follow(GameObject angel) //camera is slightly behind character movement because of follow and not moving directly with input
    {
        this.transform.position = angel.transform.position + this.cameraHeight;
        this.transform.rotation = angel.transform.rotation;
    }
}