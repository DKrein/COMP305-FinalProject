﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public Text deathText;
	public Text keysText;
	public Text centerMsgText;
	public Transform spawnPoint;

	private int keysLeft = 5;
	private int deathCounter=0;
	private float deathTimer=0;
	private bool dead;
	private GameObject player;
	private int currentLevel;


	// Use this for initialization
	void Start () {

		currentLevel = PlayerPrefs.GetInt("Level");
		deathCounter = PlayerPrefs.GetInt("Deaths");

		dead = false;
		centerMsgText.text = "";
		player = GameObject.FindWithTag ("Player");
		updateUI ();
	}
	
	// Update is called once per frame
	void Update () {
		if (dead) {
			player.GetComponent<CharacterController>().enabled = false;
			deathTimer += Time.deltaTime;
			if (deathTimer >= 1){
				//Instantiate (player, spawnPoint.position, spawnPoint.rotation);
				dead = false;
				deathTimer = 0;
				centerMsgText.text = "";
				player.GetComponent<CharacterController>().enabled = true;
			}
		}
	}

	public void pickKey() {
		keysLeft--;
		updateUI ();
	}	

	public void die() {
		deathCounter++;
		updateUI ();
		centerMsgText.text = "Y O U    D I E D";
		if (!GetComponent<AudioSource>().isPlaying) 
			GetComponent<AudioSource>().Play();
		dead = true;
		player.transform.position = spawnPoint.position;
	}	

	void updateUI(){
		deathText.text = "Deaths: "+deathCounter;
		keysText.text = "Keys Left: "+keysLeft;
	}

	public void changeLevel() {
		Debug.Log ("change level");

		if (keysLeft == 0) {
			currentLevel++;
			Debug.Log ("Change level goto" + currentLevel);
			PlayerPrefs.SetInt ("Level", currentLevel);
			PlayerPrefs.SetInt ("Deaths", deathCounter);
			Application.LoadLevel (currentLevel);
		} else {
			Debug.Log ("dok");
			StartCoroutine( ShowCenterMsg ());
		}
	}

	IEnumerator ShowCenterMsg(){
		centerMsgText.text = "You left "+keysLeft+" keys.";
		yield return new WaitForSeconds(2f);
		centerMsgText.text = "";
	}
}
