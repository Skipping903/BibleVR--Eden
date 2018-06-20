using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AWSDMove : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float moveSpeed = 20f;
    private float turnSpeed = 300f;

    void Update()
    {
        Move();
    }

    void Move()
    {
        this.horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * turnSpeed;
        this.vertical = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        this.transform.Rotate(0, this.horizontal, 0);
        this.transform.Translate(0, 0, this.vertical);
    }	
}//class
