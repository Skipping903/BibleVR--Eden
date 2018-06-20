using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadPicker : MonoBehaviour
{
    public GameObject mainHead, mainHead2;
    public GameObject head1, head2, head3;
    private bool clicked1, clicked2, clicked3;
    private GameObject newHead1, newHead2, currHead1, currHead2;
    private Color32 defaultColor = new Color32(255, 255, 255, 255);
    private Quaternion coneRot = Quaternion.Euler(90f, 0f, -37.467f);
    private Quaternion charConeRot = Quaternion.Euler(90f, 0f, 0f);

    void Awake()
    {
        this.head1.GetComponent<Renderer>().sharedMaterial.color = this.defaultColor;
        this.currHead1 = Instantiate(this.head1, this.mainHead.transform.position, this.mainHead.transform.rotation, this.mainHead.transform);
        this.clicked1 = false;
        this.clicked2 = false;
        this.clicked3 = false;
    }

    public void identity1()
    {
        this.clicked1 = true;
        SwapHead();
        this.clicked1 = false;
    }

    public void identity2()
    {
        this.clicked2 = true;
        SwapHead();
        this.clicked2 = false;
    }

    public void identity3()
    {
        this.clicked3 = true;
        SwapHead();
        this.clicked3 = false;
    }

    void SwapHead()
    {
        if (this.clicked1 == true)
        {
            Destroy(this.currHead1);
            this.newHead1 = Instantiate(this.head1, this.mainHead.transform.position, this.mainHead.transform.rotation, this.mainHead.transform);
            this.currHead1 = this.newHead1;
            Destroy(this.currHead2);
            this.newHead2 = Instantiate(this.head1, this.mainHead2.transform.position, this.mainHead2.transform.rotation, this.mainHead2.transform);
            this.currHead2 = this.newHead2;
        }

        if (this.clicked2 == true)
        {
            Destroy(this.currHead1);
            this.newHead1 = Instantiate(this.head2, this.mainHead.transform.position, this.mainHead.transform.rotation, this.mainHead.transform);
            this.currHead1 = this.newHead1;
            Destroy(this.currHead2);
            this.newHead2 = Instantiate(this.head2, this.mainHead2.transform.position, this.mainHead2.transform.rotation, this.mainHead2.transform);
            this.currHead2 = this.newHead2;
        }

        if (this.clicked3 == true)
        {
            Destroy(this.currHead1);
            this.newHead1 = Instantiate(this.head3, this.mainHead.transform.position, this.coneRot, this.mainHead.transform);
            this.currHead1 = this.newHead1;
            Destroy(this.currHead2);
            this.newHead2 = Instantiate(this.head3, this.mainHead2.transform.position, this.charConeRot, this.mainHead2.transform);
            this.currHead2 = this.newHead2;
        }
    }
}
