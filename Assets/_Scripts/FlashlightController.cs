using UnityEngine;
using System.Collections;

public class FlashlightController : MonoBehaviour {

	public float duration = 0.05F;
	public Light lt;

	private bool failure = false;

	// Use this for initialization
	void Start () {
		lt = GetComponent<Light>();
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

			failure = true;
			yield return new WaitForSeconds(UnityEngine.Random.Range (2,4));
			failure = false;
			lt.intensity = 0;
			yield return new WaitForSeconds(UnityEngine.Random.Range (5,7));
			lt.intensity = 3;
			yield return new WaitForSeconds(UnityEngine.Random.Range (30,40));
		}	
	}
}
