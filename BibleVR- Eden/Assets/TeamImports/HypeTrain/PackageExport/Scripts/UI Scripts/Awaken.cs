using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Awaken : MonoBehaviour  //FIX, make ghost character on start and have a ghost character allow for creation of new characters on contact
    //new characters should be asked name, class, and customizations(should customizations happen here initially or over at the hut?)
{
    // makes the character "wakeUp"
    public bool allowedToFill;
    public bool allowedToClose;
    public float filled = 1f;
    public float unfilled = 0f;
    public float timeToChange = 5f; //change this val to affect speed of animation
    public Color lerpedColor;
    public GameObject currAngel;

    void Awake()
    {
        this.lerpedColor = this.GetComponent<Image>().color;
        //Debug.Log("a is.." + this.GetComponent<Image>().color.a);
        this.allowedToFill = false;
        this.allowedToClose = false;
    }

    void Update ()
    {
        //this.currAngel = GameObject.Find("Main Camera").GetComponent<CameraFollow>().currAngel;

        if (allowedToFill &&
            GameObject.Find("UI Controller").GetComponent<UIButtonFunctions>().pauseCounter > 0) //on collision
        {
            this.allowedToFill = false;
            StartCoroutine(WakeUp(this.unfilled, this.filled));//ctrl z away
            
            //turn off movement script for new angel
            this.currAngel.GetComponent<AWSDMove>().enabled = false;//should this be done here?

            //ienumerate wait here for transition
            StartCoroutine(FadeDelay(2));
        }

        if(this.allowedToClose)     //make happen on button click if new character // make happen after seconds for existing character
        {
            this.allowedToClose = false;
            StartCoroutine(WakeUp(this.filled, this.unfilled));
            //if(GameObject.Find("UI Controller").GetComponent<UIButtonFunctions>().pauseCounter > 0)

            this.currAngel.GetComponent<AWSDMove>().enabled = true;     //took out of if
        }
    }

    IEnumerator WakeUp(float start, float end)
    {
        //changes "WakeUp" panel from black.a = 1 to black.a = 0
        for (float t = 0.0f; t < 1.0; t += Time.deltaTime / this.timeToChange)
        {
            this.lerpedColor = new Color(0, 0, 0, Mathf.Lerp(start, end, t));
            //Debug.Log(lerpedColor);
            this.GetComponent<Image>().color = this.lerpedColor;
            yield return null;
        }
    }

    IEnumerator FadeDelay(float t)
    {
        yield return new WaitForSeconds(t);
        this.allowedToClose = true;
    }
}
