﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupmelk : MonoBehaviour {

    public GameObject nietei;
    void OnTriggrEnter(Collider other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            nietei.SetActive(true);
        }
    }
}
