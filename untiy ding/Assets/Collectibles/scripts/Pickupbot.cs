using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupbot : MonoBehaviour {

    public GameObject nietbot;
    void OnTriggrEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            nietbot.SetActive(true);
        }
    }
}
