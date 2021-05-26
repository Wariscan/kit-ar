using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitVideo : MonoBehaviour
{
    //public GameObject GlobeVideo;
    public GameObject CanvasText;
    public GameObject Videos;


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            CanvasText.SetActive(true);
            Videos.SetActive(false);
        }
    }
}
