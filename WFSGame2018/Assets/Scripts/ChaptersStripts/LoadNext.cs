using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class LoadNext : MonoBehaviour {
    private loadSceneScript loadSceneScript;
    VideoPlayer m_VideoPlayer;

    private void Start()
    {
        m_VideoPlayer = new VideoPlayer();
        loadSceneScript = new loadSceneScript();
        
    }

    void Awake()
    {
        m_VideoPlayer = GetComponent<VideoPlayer>();
        m_VideoPlayer.loopPointReached += EndReached; // loopPointReached is the event for the end of the video
    }

    void EndReached(VideoPlayer vp)
    {
        loadSceneScript.LoadSceneMinigame1();
    }

}
