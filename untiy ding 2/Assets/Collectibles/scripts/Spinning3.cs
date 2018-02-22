using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning3 : MonoBehaviour {


	// Update is called once per frame
	void Update () {
        transform.RotateAround(new Vector3(0, 0, 0), new Vector3 (0, 90, 0), 20 * Time.deltaTime);
    }
}
