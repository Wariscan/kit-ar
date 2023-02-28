using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAndShowObject : NYImageTrackerEventHandler

{

    public GameObject ObjectToHideShow;


    private void Start()
    {
        ObjectToHideShow.SetActive(false);
    }


    public override void OnTrackingFound()
    {
        ObjectToHideShow.SetActive(true);
    }

    public override void OnTrackingLost()
    {
        ObjectToHideShow.SetActive(false);
    }
}