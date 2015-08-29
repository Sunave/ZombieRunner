using UnityEngine;
using System.Collections;

public class ClearArea : MonoBehaviour {

	public float timeSinceLastTrigger = 0f;

	void Start () {
		
	}
	
	void Update () {
		timeSinceLastTrigger += Time.deltaTime;
		if (timeSinceLastTrigger > 3f && Time.realtimeSinceStartup > 10f) SendMessageUpwards ("OnFindClearArea");
	}

	void OnTriggerStay (Collider collider) {
		timeSinceLastTrigger = 0f;
	}
	
}
