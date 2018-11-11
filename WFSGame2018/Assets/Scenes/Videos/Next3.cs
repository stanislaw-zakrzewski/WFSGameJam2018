using UnityEngine;
using UnityEngine.Video;

public class Next3 : MonoBehaviour
{
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
        loadSceneScript.LoadSplash3();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            loadSceneScript.LoadSplash3();
        }
    }

}
