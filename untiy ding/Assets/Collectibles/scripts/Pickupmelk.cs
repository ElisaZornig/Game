using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupmelk : MonoBehaviour {

    public GameObject nietmelk;
    void OnTriggrEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            nietmelk.SetActive(true);
        }
    }
}
