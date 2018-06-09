using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeadPicker : MonoBehaviour
{
    public GameObject mainHead;
    public GameObject head1, head2, head3;
    private bool clicked1, clicked2, clicked3;
    private GameObject currHead;
    private GameObject newHead;
    private Color32 defaultColor = new Color32(255, 255, 255, 255);
    private Quaternion coneRot = Quaternion.Euler(90f, 0f, 0f);

    void Awake()
    {
        this.head1.GetComponent<Renderer>().sharedMaterial.color = this.defaultColor;
        this.currHead = Instantiate(this.head1, this.mainHead.transform.position, Quaternion.identity, this.mainHead.transform);
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
            Destroy(this.currHead);
            this.newHead = Instantiate(this.head1, this.mainHead.transform.position, Quaternion.identity, this.mainHead.transform);
            this.currHead = newHead;
        }
        if (this.clicked2 == true)
        {
            Destroy(this.currHead);
            this.newHead = Instantiate(this.head2, this.mainHead.transform.position, Quaternion.identity, this.mainHead.transform);
            this.currHead = newHead;
        }
        if (this.clicked3 == true)
        {
            Destroy(this.currHead);
            this.newHead = Instantiate(this.head3, this.mainHead.transform.position, this.coneRot, this.mainHead.transform);
            this.currHead = newHead;
        }
    }
}
