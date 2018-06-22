using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    private AudioClip splashMusic;
    private bool hasStarted;
    public GameObject splashScreen;

    void Awake()
    {
        this.hasStarted = false;
    }

    IEnumerator Start()
    {
        if (hasStarted == false)
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            yield return new WaitForSeconds(audio.clip.length);
            audio.clip = splashMusic;
            audio.Play();
        }
    }

    public void ClickedStart()
    {
        this.hasStarted = true;
        this.splashScreen.SetActive(false);
    }
}//class
