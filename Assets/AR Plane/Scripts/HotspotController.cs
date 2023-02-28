using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotspotController : MonoBehaviour
{
    public GameObject CanvasMenu;
    public GameObject CircleSet;

    //Canvas Menu should deactivated before build

    void OnTriggerStay(Collider collider)
    {
        if (collider.gameObject.tag == "MainCamera")
        {
            CanvasMenu.SetActive(true);
            CircleSet.SetActive(false);

        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "MainCamera")
        {
            CanvasMenu.SetActive(false);
            CircleSet.SetActive(true);
        }
    }
}


// Hotspot Controller
// Created by Shamsul Amar bin Hashim
// Created 11 Oct 2020
// Last change 29 Aug 2021