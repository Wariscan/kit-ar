using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{

    public void ChangeSceneByIndex (int index)
    {
        SceneManager.LoadScene(index);
    }

    public void ChangeSceneByName (string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
