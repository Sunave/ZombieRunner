using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public bool respawn;

	private Transform[] spawnPoints;

	void Start () {
		spawnPoints = GameObject.Find("PlayerSpawnPoints").GetComponentsInChildren<Transform>();
	}
	
	void Update () {
		print(spawnPoints.Length);
		if (respawn) ReSpawn();
	}

	private void ReSpawn() {
		int i = Random.Range(1, spawnPoints.Length);
		transform.position = spawnPoints[i].transform.position;
		respawn = false;
	}
}
