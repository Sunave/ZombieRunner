using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public GameObject landingAreaPrefab;

	private bool respawn;
	private Transform[] spawnPoints;
	private InnerVoice innerVoice;
	private ClearArea clearArea;

	void Start () {
		spawnPoints = GameObject.Find("PlayerSpawnPoints").GetComponentsInChildren<Transform>();
		innerVoice = GetComponentInChildren<InnerVoice>();
		clearArea = GetComponentInChildren<ClearArea>();
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
		innerVoice.OnFindClearArea();
		Invoke ("DropFlare", 3f);
	}

	void DropFlare () {
		Instantiate(landingAreaPrefab, transform.position, transform.rotation);
	}

}
