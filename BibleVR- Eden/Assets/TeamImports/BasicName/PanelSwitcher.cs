using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject settingsScreen;

    // Use this for initialization
    void Start()
    {
        this.startScreen = GameObject.Find("Start Screen");
        this.settingsScreen = GameObject.Find("Settings Screen");
    }

    public void PanelsSwitcher()
    {
        this.startScreen.SetActive(true);
        this.settingsScreen.SetActive(false);
    }
}
