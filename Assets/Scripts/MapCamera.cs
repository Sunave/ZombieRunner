using UnityEngine;
using System.Collections;

public class MapCamera : MonoBehaviour {

	private float storedShadowDistance = 0;

	void OnPreRender () { 
		storedShadowDistance = QualitySettings.shadowDistance;
		QualitySettings.shadowDistance = 0; 
	}

	void OnPostRender () { 
		QualitySettings.shadowDistance = storedShadowDistance;
	}
}
