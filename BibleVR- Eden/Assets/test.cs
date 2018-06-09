using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    bool isWise;

    void Awake()
    {
        this.isWise = false;
    }

    public void identityCheck()
    {
        this.isWise = true;
        tester();
        this.isWise = false;
    }
    
    void tester()
    {
        if(this.isWise == true)
        {
            Debug.Log("Have you ever heard the tragedy of Darth Plageus the Wise?");
        }
    }
}
