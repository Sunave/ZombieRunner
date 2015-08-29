using UnityEngine;
using System.Collections;

public class Terrain : MonoBehaviour {

	void Start () {
		// Toggling TerrainCollider at start solves a situation where the tree colliders 
		// are not otherwise detected, as described here: 
		// http://answers.unity3d.com/questions/287361/tree-colliders-not-working.html

		GetComponent<TerrainCollider>().enabled = false;
		GetComponent<TerrainCollider>().enabled = true;
	}

}
