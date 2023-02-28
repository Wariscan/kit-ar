using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    [SerializeField] private string URL;

    public void OpenLink()
    {
        Application.OpenURL(URL);

    }

}
