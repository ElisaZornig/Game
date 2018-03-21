using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupbloem : MonoBehaviour {

    public GameObject nietbloem;
    private void OnTriggrEnter(Collider other)
    {
        bool player = other.gameObject.CompareTag("player");
        if (player)
        {
            nietbloem.SetActive(true);
        }
    }
}
