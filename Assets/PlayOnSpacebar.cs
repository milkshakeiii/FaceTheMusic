using UnityEngine;
using System.Collections;

public class PlayOnSpacebar : MonoBehaviour {

	public AudioSource playMe;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space))
			playMe.Play ();
	}
}
