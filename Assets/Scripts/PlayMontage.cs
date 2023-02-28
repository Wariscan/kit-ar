//05 Oktober 2020 7:17 AM
//Script ini letaknya di Main Camera
//Bila video dimain sampai hujung, Coroutine akan beralih ke Scene yang lain
//Script ini tidak sesuai untuk video yang ada Play, Pause dan Stop
//Script ini hanya untuk video Montage sebelum beralih ke Scene lain

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayMontage : MonoBehaviour
{
    [SerializeField]
    int VideoDuration = 60;
    //Sama dengan duration video yang dimainkan

    [SerializeField]
    string NextScene = "Scene Name";
    //Nama scene seterusnya

    void Start()
    {
        StartCoroutine(Pindah());
        //Kiraan Coroutine bermula sebaik sahaja GameObject aktif
    }

    IEnumerator Pindah()
    {
        yield return new WaitForSeconds(VideoDuration);
        SceneManager.LoadScene(NextScene);
    }
}