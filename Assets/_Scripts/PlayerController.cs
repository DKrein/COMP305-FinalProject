using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private GameController gameController;

	// Use this for initialization
	void Start () {

		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null) {
			gameController = gameControllerObject.GetComponent <GameController>();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Goal") { 
			gameController.changeLevel(); 
		}

		if (other.transform.tag == "Enemy") { 
			gameController.die(); 
		}

		if (other.transform.tag == "Key")
		{	
			gameController.pickKey();
			Destroy(other.gameObject);
		}

	}
}
