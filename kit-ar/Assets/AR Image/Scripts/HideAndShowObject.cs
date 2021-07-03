using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAndShowObject : NYImageTrackerEventHandler

{

    public GameObject AugmentedObject;


    private void Start()
    {
        AugmentedObject.SetActive(false);
    }


    public override void OnTrackingFound()
    {
        AugmentedObject.SetActive(true);
    }

    public override void OnTrackingLost()
    {
        AugmentedObject.SetActive(false);
    }
}