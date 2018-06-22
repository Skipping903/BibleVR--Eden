using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewCharacter : MonoBehaviour
{
    public GameObject[] classPrefabs; //filled with three class prefabs
    public GameObject[] characters = new GameObject[8];
    public GameObject classPanel;
    public GameObject namePanel;
    public GameObject newCharacter;

    public Vector3 nextSpawn;
    public bool gate = false;

    private GameObject newPrefab;
    private int spawnNum = 0;
    private string spawnName = "";

    void Awake()
    {
        this.classPanel = GameObject.Find("ClassSelectPanel");
        this.namePanel = GameObject.Find("NameCharacterPrompt");
    }


    void Start ()
    {
        this.classPanel.SetActive(false);
        this.namePanel.SetActive(false);
    }

    public void CreateThrone()
    {
        FindOpenSpawn();
        this.newPrefab = this.classPrefabs[0];
        //move instantiate to save button click
        
        this.classPanel.SetActive(false);
        this.namePanel.SetActive(true);         
    }

    public void CreateSeraphim()
    {
        FindOpenSpawn();
        this.newPrefab = this.classPrefabs[1];

        this.classPanel.SetActive(false);
        this.namePanel.SetActive(true);
    }

    public void CreateCherubim()
    {
        FindOpenSpawn();
        this.newPrefab = this.classPrefabs[2];

        this.classPanel.SetActive(false);
        this.namePanel.SetActive(true);
    }

    void FindOpenSpawn()
    {
        this.spawnName = this.spawnNum.ToString();
        this.nextSpawn = GameObject.Find("spawn" + this.spawnName).transform.position;
        this.spawnNum++;
        Debug.Log(this.spawnName);
    }

    public void NameCharacter()        //should go before class choosing so name save works ;)
    {
                                       //sets the new prefab nametag to name input
        this.newPrefab.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = GameObject.Find("NameText").GetComponent<Text>().text;

        Instantiate(this.newPrefab, this.nextSpawn, Quaternion.identity);       //is this or the child affecting mainCamera
        this.namePanel.SetActive(false);

        ControlCharacter();
    }

    void ControlCharacter()
    {
        this.characters[this.spawnNum - 1] = this.newPrefab;
        Debug.Log("characters?" + this.characters[this.spawnNum - 1]);
        //GameObject.Find("Main Camera").GetComponent<CameraFollow>().currAngel = this.characters[this.spawnNum - 1];       //camera swap
    }

    public void SetForward(Collider other)
    {
        other.transform.rotation = Quaternion.identity;
        Debug.Log(other.transform.rotation);
    }

    void Update()
    {
        if (this.gate)      //should this be in update with a function inside
        {
            Debug.Log(this.gate);
            //set new currAngel?
            //Destroy ghost
        }
    }

    void OnTriggerEnter(Collider other) //other is current Character
    {
        if (other.name != "Plane" && other.name != "TriggerEnable" && other.name != "mainCamera")
        {
            this.classPanel.SetActive(true);     //choose prefab, set name for prefab, then make correct prefab
            Debug.Log(other.name);
            SetForward(other);              //made today?
        }
    }
}
