using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAndShowObject : NYImageTrackerEventHandler

{

    public GameObject AugmentedObject;

    public override void OnTrackingFound()
    {
        AugmentedObject.SetActive(true);
    }

    public override void OnTrackingLost()
    {
        AugmentedObject.SetActive(false);
    }
}