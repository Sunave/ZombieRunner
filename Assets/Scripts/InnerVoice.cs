using UnityEngine;
using System.Collections;

public class InnerVoice : MonoBehaviour {

	public AudioClip gameStart;
	public AudioClip goodLandingArea;

	private AudioSource audioSource;

	void Start () {
		audioSource = GetComponent<AudioSource>();
		audioSource.clip = gameStart;
		audioSource.Play();
	}
	
	public void OnFindClearArea () {
		audioSource.clip = goodLandingArea;
		audioSource.Play();

		Invoke ("CallHeli", goodLandingArea.length + 1f);
	}

	void CallHeli () {
		SendMessageUpwards ("OnMakeInitialHeliCall");
	}
}
