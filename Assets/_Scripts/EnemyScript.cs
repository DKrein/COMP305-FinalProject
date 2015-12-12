using UnityEngine;
using System.Collections;
using System;
using System.Linq;

public class EnemyScript : MonoBehaviour
{
	

	public float speed; //Enemy Speed
	private GameObject objPlayer;
	private NavMeshAgent agent;

	
	protected void Initialize()
	{
		agent = GetComponent<NavMeshAgent>();
		objPlayer = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Use this for initialization
	void Start()
	{
		Initialize();
	}

	// Update is called once per frame
	void FixedUpdate()
	{

		if (Vector3.Dot(objPlayer.transform.forward, (transform.position - objPlayer.transform.position).normalized) < .65f) {
			if (!GetComponent<AudioSource>().isPlaying) 
				GetComponent<AudioSource>().Play();

			agent.enabled = true;
			agent.SetDestination (objPlayer.transform.position);
		} else {	
			GetComponent<AudioSource>().Stop();
			agent.enabled = false;
		}
	
	}
		
}
