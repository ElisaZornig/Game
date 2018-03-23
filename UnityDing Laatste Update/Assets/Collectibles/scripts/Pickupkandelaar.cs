using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupkandelaar : MonoBehaviour {

    public GameObject nietkandelaar;
    void OnTriggrEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            nietkandelaar.SetActive(true);
        }
    }
}
