using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelChanger : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject loginScreen;
    public GameObject settingsScreen;

	// Use this for initialization
	void Awake ()
    {
        this.startScreen = GameObject.FindGameObjectWithTag("Start Screen");
        this.loginScreen = GameObject.FindGameObjectWithTag("Login Screen");
        this.settingsScreen = GameObject.FindGameObjectWithTag("Settings Screen");
	}

    public void StartAndLoginSwitch()
    {
        this.startScreen.SetActive(false);
    }

    public void StartAndSettingsSwitch()
    {
        this.startScreen.SetActive(false);
        this.loginScreen.SetActive(false);
    }
    public void SettingsToStartSwitch()
    {
        this.settingsScreen.SetActive(false);
        this.loginScreen.SetActive(true);
        this.startScreen.SetActive(true);
    }
}
