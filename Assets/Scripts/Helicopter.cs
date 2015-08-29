using UnityEngine;
using System.Collections;

public class Helicopter : MonoBehaviour {

	public AudioClip callSound; 

	private AudioSource audioSource;
	private bool called = false;
	private Rigidbody rigidBody;

	void Start () {
		audioSource = GetComponent<AudioSource>();
		rigidBody = GetComponent<Rigidbody>();
	}
	
	void Update () {
		if (Input.GetButtonDown("Call Heli") && !called) Call();
	}

	public void Call () {
		if (!called) {
			called = true;
			audioSource.clip = callSound;
			audioSource.Play();
			rigidBody.velocity = new Vector3 (0, 0, 50f);
		}
	}
	
}
