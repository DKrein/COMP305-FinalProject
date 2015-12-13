using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour
{
    public Canvas insMenu;
    public GameObject startButton;
    public GameObject exitButton;
    public GameObject insButton;

    public GUISkin skin;

    void OnGUI()
    {
       
        GUI.skin = skin;
    }

    // Use this for initialization
    void Start()
    {
		PlayerPrefs.SetInt("Level",1);
		PlayerPrefs.SetInt("Deaths",0);
        insMenu = insMenu.GetComponent<Canvas>();
        insMenu.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InstructionPress()
    {
        insMenu.enabled = true;
        startButton.GetComponent<Text>().enabled = false;
        exitButton.GetComponent<Text>().enabled = false;
        insButton.GetComponent<Text>().enabled = false;
    }
    public void ContinuePress()
    {
        insMenu.enabled = false;
        startButton.GetComponent<Text>().enabled = true;
        exitButton.GetComponent<Text>().enabled = true;
        insButton.GetComponent<Text>().enabled = true;
    }

    public void ExitPress()
    {
        Application.Quit();
    }

    public void PlayPress()
    {
		Application.LoadLevel (1);
    }

}
