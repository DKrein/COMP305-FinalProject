using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private static int totalKeyCount = 1;
	private int deathCount =0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Death()
	{
		deathCount += 1;
		Debug.Log ("You died "+ deathCount +" times");
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Goal")
		{
			//complete the level
			if (totalKeyCount <= 0) {
				Debug.Log ("level completed");
			}
		}
		
		if (other.transform.tag == "Key")
		{	
			totalKeyCount -= 1; ;
			Debug.Log ("Keys left: "+totalKeyCount);
			Destroy(other.gameObject);
		}
		
		if (other.transform.tag == "Enemy")
		{
			Death();
		}

	}
}
