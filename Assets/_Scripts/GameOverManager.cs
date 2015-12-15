using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour {

	public Text infoFinalText; 

	private float timer;
	private int deathCounter;


	// Use this for initialization
	void Start () {
		deathCounter = PlayerPrefs.GetInt("Deaths");
		timer = PlayerPrefs.GetFloat("Timer");

		int minutes = Mathf.FloorToInt(timer / 60F);
		int seconds = Mathf.FloorToInt(timer - minutes * 60);
		string niceTime = string.Format("{0:00}:{1:00}", minutes, seconds);

		infoFinalText.text = "Escaped in "+niceTime+" and died "+deathCounter+" times.\n\nCan you do better?";

		PlayerPrefs.SetInt ("Level", 0);
		PlayerPrefs.SetInt ("Deaths", 0);
		PlayerPrefs.SetFloat ("Timer", 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
