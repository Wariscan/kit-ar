using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoLoader : MonoBehaviour
{
    // https://drive.google.com/file/d//view?usp=sharing
    // 1TZPL_jyPrASODE3ynr4mnJoZa8HMZ14A
    // https://drive.google.com/uc?export=download&id=1TZPL_jyPrASODE3ynr4mnJoZa8HMZ14A

    public string mUri = "https://drive.google.com/uc?export=download&id=";
    public bool mClearCache = false;

    private VideoPlayer mVideoPlayer = null;
    private AssetBundle mBundle = null;

    // Start is called before the first frame update
    private void Awake()
    {
        mVideoPlayer = GetComponent<VideoPlayer>();
        Caching.compressionEnabled = false;

        if (mClearCache)
            Caching.ClearCache();
    }

    public void LoadAndPlayVideo()
    {
        StartCoroutine(DownloadAndPlay());
    }

    private IEnumerator DownloadAndPlay()
    {
        yield return GetBundle();

        if (!mBundle)
        {
            Debug.Log("Bundle failed to load");
            yield break;
        }

        VideoClip newVideoClip = mBundle.LoadAsset<VideoClip>("Dinosaur");
        mVideoPlayer.clip = newVideoClip;
        mVideoPlayer.Play();
    }

    private IEnumerator GetBundle()
    {
        WWW request = WWW.LoadFromCacheOrDownload(mUri, 0);

        while (!request.isDone)
        {
            Debug.Log(request.progress);
            yield return null;
        }

        if (request.error == null)
        {
            mBundle = request.assetBundle;
            Debug.Log("Success");
        }
        else
        {
            Debug.Log(request.error);
        }
    }
}
