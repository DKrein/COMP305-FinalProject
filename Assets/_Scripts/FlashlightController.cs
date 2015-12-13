using UnityEngine;
using System.Collections;

public class FlashlightController : MonoBehaviour {

	public float duration = 0.05F;
	private Light lt;
	private AudioSource audios;

	private bool failure = false;

	// Use this for initialization
	void Start () {
		lt = GetComponent<Light>();
		audios = GetComponent<AudioSource>();
		StartCoroutine( RandomBehavior ());
	}
	
	// Update is called once per frame
	void Update () {
		if (failure) {
			float phi = Time.time / duration * 1f * Mathf.PI;
			float amplitude = Mathf.Cos (phi) * 0.5F + 0.5F;
			lt.intensity = amplitude;
		}
	}

	IEnumerator RandomBehavior(){
		
		while(true){
			audios.Play();
			failure = true;
			yield return new WaitForSeconds(UnityEngine.Random.Range (2,4));
			failure = false;
			audios.Stop();
			lt.intensity = 0;
			yield return new WaitForSeconds(UnityEngine.Random.Range (5,7));
			lt.intensity = 4;
			yield return new WaitForSeconds(UnityEngine.Random.Range (30,40));
		}	
	}
}
