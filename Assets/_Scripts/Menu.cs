using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour
{
    public Canvas insMenu;
    public GameObject startButton;
    public GameObject exitButton;
    public GameObject insButton;
    public GameObject refreshButton;
    public GameObject serverStartButton;
    public GameObject roomButton;

    public GUISkin skin;

    void OnGUI()
    {
       
        GUI.skin = skin;
    }

    // Use this for initialization
    void Start()
    {
        insMenu = insMenu.GetComponent<Canvas>();
        insMenu.enabled = false;
        refreshButton.GetComponent<Text>().enabled = false;
        serverStartButton.GetComponent<Text>().enabled = false;
        roomButton.GetComponent<Text>().enabled = false;
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
        refreshButton.GetComponent<Text>().enabled = false;
        serverStartButton.GetComponent<Text>().enabled = false;
        roomButton.GetComponent<Text>().enabled = false;
    }
    public void ContinuePress()
    {
        insMenu.enabled = false;
        startButton.GetComponent<Text>().enabled = true;
        exitButton.GetComponent<Text>().enabled = true;
        insButton.GetComponent<Text>().enabled = true;
        refreshButton.GetComponent<Text>().enabled = false;
        serverStartButton.GetComponent<Text>().enabled = false;
        roomButton.GetComponent<Text>().enabled = false;
    }

    public void ExitPress()
    {
        Application.Quit();
    }

    public void PlayPress()
    {
        insMenu.enabled = false;
        startButton.GetComponent<Text>().enabled = false;
        exitButton.GetComponent<Text>().enabled = false;
        insButton.GetComponent<Text>().enabled = false;
        refreshButton.GetComponent<Text>().enabled = true;
        serverStartButton.GetComponent<Text>().enabled = true;
        roomButton.GetComponent<Text>().enabled = false;
    }

    public void RefreshPress()
    {
        insMenu.enabled = false;
        startButton.GetComponent<Text>().enabled = false;
        exitButton.GetComponent<Text>().enabled = false;
        insButton.GetComponent<Text>().enabled = false;
        refreshButton.GetComponent<Text>().enabled = true;

    }

    public void StartServerPress()
    {
    }

    public void RoomPress()
    {
    }
}
