using UnityEngine;
using System.Collections;

public class RadioSystem : MonoBehaviour {

	public AudioClip callHeli;
	public AudioClip heliCallReply;

	private AudioSource audioSource;

	void Start () {
		audioSource = GetComponent<AudioSource>();
	}

	void OnMakeInitialHeliCall () {
		audioSource.clip = callHeli;
		audioSource.Play();
		Invoke("CallHeli", callHeli.length + 1f);
	}

	void CallHeli () {
		audioSource.clip = heliCallReply;
		audioSource.Play();
		BroadcastMessage ("OnDispatchHelicopter");
	}
}
