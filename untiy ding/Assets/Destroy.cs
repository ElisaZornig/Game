using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {
	private GameObject canvas;

	// Update is called once per frame
	void Update () {

		canvas = GameObject.FindGameObjectWithTag ("Music");
			DestroyObject (canvas);
	}
}
