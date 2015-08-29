using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	private bool respawn;
	private Transform[] spawnPoints;
//	private AudioSource innerVoice;
	private InnerVoice innerVoice;

	void Start () {
		spawnPoints = GameObject.Find("PlayerSpawnPoints").GetComponentsInChildren<Transform>();
		innerVoice = GetComponentInChildren<InnerVoice>();
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
		print ("OnFindClearArea player");
		innerVoice.OnFindClearArea();
		Invoke ("DropFlare", 3f);
	}

	void DropFlare () {
		// TODO make it drop flare
	}

}
