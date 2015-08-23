using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour {

	public AudioClip callSound; 

	private AudioSource audioSource;
	private bool called = false;

	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	void Update () {
		if (Input.GetButtonDown("Call Heli") && !called) CallHelicopter();
	}

	private void CallHelicopter () {
		called = true;
		audioSource.clip = callSound;
		audioSource.Play();
	}
}
