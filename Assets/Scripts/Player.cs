using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public AudioClip gameStartSound;

	private bool respawn;
	private Helicopter helicopter;
	private Transform[] spawnPoints;
	private AudioSource innerVoice;

	void Start () {
		spawnPoints = GameObject.Find("PlayerSpawnPoints").GetComponentsInChildren<Transform>();
		helicopter = GameObject.FindObjectOfType<Helicopter>();

		AudioSource[] audioSources = GetComponents<AudioSource>();
		foreach (AudioSource audioSource in audioSources) {
			if (audioSource.priority == 1) innerVoice = audioSource;
		}

		innerVoice.clip = gameStartSound;
		innerVoice.Play();
	}
	
	void Update () {
		if (respawn) ReSpawn();
	}

	private void ReSpawn() {
		int i = Random.Range(1, spawnPoints.Length);
		transform.position = spawnPoints[i].transform.position;
		respawn = false;
	}

	void OnFindClearArea () {
		Debug.Log ("Found clear area in player");
		helicopter.Call();
	}

}
