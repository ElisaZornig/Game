using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy1 : MonoBehaviour {

	public void Awake (){
		DontDestroyOnLoad (this);

		if (FindObjectsOfType (GetType ()).Length > 1) {
			Destroy (this.gameObject);
		}
	}

}
