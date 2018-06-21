using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    private float turnSpeed = 250f, horizontal;

    void Update()
    {
        MoveCamera();
    }

    void MoveCamera()
    {
        if (GameObject.Find("Crystal").GetComponent<InitiateCustom>().isEnabled)
        {
            this.horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed;
            this.transform.Rotate(0f, this.horizontal, 0f);
        }
    }



}//class
