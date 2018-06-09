using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour
{
    private bool clicked1, clicked2, clicked3, clicked4, clicked5;
    public GameObject head1, head2, head3;
    private Renderer headColor1, headColor2, headColor3;
    private Color32[] numColors;

    void Awake()
    {
        this.headColor1 = head1.GetComponent<Renderer>();
        this.headColor2 = head2.GetComponent<Renderer>();
        this.headColor3 = head3.GetComponent<Renderer>();
        this.numColors = new Color32[5];
        this.numColors[0] = new Color32(0, 255, 100, 255);
        this.numColors[1] = new Color32(211, 0, 255, 255);
        this.numColors[2] = new Color32(0, 255, 226, 255);
        this.numColors[3] = new Color32(255, 167, 0, 255);
        this.numColors[4] = new Color32(255, 0, 0, 255);
    }

    public void colorIdentity1()
    {
        this.clicked1 = true;
        SwapColor();
        this.clicked1 = false;
    }

    public void colorIdentity2()
    {
        this.clicked2 = true;
        SwapColor();
        this.clicked2 = false;
    }

    public void colorIdentity3()
    {
        this.clicked3 = true;
        SwapColor();
        this.clicked3 = false;
    }

    public void colorIdentity4()
    {
        this.clicked4 = true;
        SwapColor();
        this.clicked4 = false;
    }

    public void colorIdentity5()
    {
        this.clicked5 = true;
        SwapColor();
        this.clicked5 = false;
    }

    void SwapColor()
    {
        if (this.clicked1 == true)
        {
            this.head1.GetComponent<Renderer>().sharedMaterial.color = this.numColors[0];
            this.head2.GetComponent<Renderer>().sharedMaterial.color = this.numColors[0];
            this.head3.GetComponent<Renderer>().sharedMaterial.color = this.numColors[0];
        }
        if (this.clicked2 == true)
        {
            this.head1.GetComponent<Renderer>().sharedMaterial.color = this.numColors[1];
            this.head2.GetComponent<Renderer>().sharedMaterial.color = this.numColors[1];
            this.head3.GetComponent<Renderer>().sharedMaterial.color = this.numColors[1];
        }
        if (this.clicked3 == true)
        {
            this.head1.GetComponent<Renderer>().sharedMaterial.color = this.numColors[2];
            this.head2.GetComponent<Renderer>().sharedMaterial.color = this.numColors[2];
            this.head3.GetComponent<Renderer>().sharedMaterial.color = this.numColors[2];
        }
        if (this.clicked4 == true)
        {
            this.head1.GetComponent<Renderer>().sharedMaterial.color = this.numColors[3];
            this.head2.GetComponent<Renderer>().sharedMaterial.color = this.numColors[3];
            this.head3.GetComponent<Renderer>().sharedMaterial.color = this.numColors[3];
        }
        if (this.clicked5 == true)
        {
            this.head1.GetComponent<Renderer>().sharedMaterial.color = this.numColors[4];
            this.head2.GetComponent<Renderer>().sharedMaterial.color = this.numColors[4];
            this.head3.GetComponent<Renderer>().sharedMaterial.color = this.numColors[4];
        }
    }
}
