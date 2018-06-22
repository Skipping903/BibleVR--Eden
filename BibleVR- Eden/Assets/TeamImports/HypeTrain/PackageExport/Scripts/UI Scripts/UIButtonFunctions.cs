using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonFunctions : MonoBehaviour
{
    public GameObject selectClass, namePrompt, currAngel;

    public string chosen;

    public bool gate, pauseGame = false;

    public int pauseCounter = 0, saveCounter = 1;

    public string myName, standingOne;

	void Awake ()
    {
        this.selectClass = GameObject.Find("ClassSelectPanel");
        this.namePrompt = GameObject.Find("NameCharacterPrompt");
        //this.currAngel = GameObject.Find("Main Camera").GetComponent<CameraFollow>().currAngel;
        this.gate = GameObject.Find("New Character").GetComponent<NewCharacter>().gate;
	}
	
    public void SelectClass()
    {
        Debug.Log("SelectClass");
        //returns the string of the button clicked
        this.chosen = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        
        //turns off UI panel
        this.selectClass.SetActive(false);

                //allows NewCharacter to finish by setting new currAngel and destroying Ghost
        this.gate = true;

        //GameObject.Find("WakeUp").GetComponent<Awaken>().allowedToClose = true;
    }

    public void InitializeAngel()
    {
        //GameObject.Find("Main Camera").GetComponent<CameraFollow>().currAngel = GameObject.Find(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
    }

    public void InitialWakeUp()
    {
        GameObject.Find("WakeUp").GetComponent<Awaken>().enabled = true;
    }

    public void SaveButton()
    {
        //save name to this.class of player data

        
        //grabs the name string from text box
        this.myName = GameObject.Find("NameText").GetComponent<Text>().text;

        if (this.pauseCounter >= 1) //for additonal characters
        {
            //this.standingOne = GameObject.Find("Main Camera").GetComponent<CameraFollow>().currAngel.name;
            GameObject.Find(this.standingOne + "Name").GetComponent<Text>().text = this.myName; 
        }
        this.pauseGame = false;
        //turns off prompt
        this.namePrompt.SetActive(false);
    }

    public void AssignName()//asigns a name on click of the character select prompt
    {
        //if name of button is the same as class
        //GameObject.Find((UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name) + "Name").GetComponent<Text>().text = this.myName;//works with class selection prompt
    }

    public void PauseGame()
    {
        if (this.pauseGame)
        {
            //Debug.Log("Game is Paused");
            this.pauseCounter++;
            Time.timeScale = 0;
        }

        if (!this.pauseGame)
        {
            Time.timeScale = 1;
        }
    }

    void Update()
    {
        PauseGame();
    }
}
