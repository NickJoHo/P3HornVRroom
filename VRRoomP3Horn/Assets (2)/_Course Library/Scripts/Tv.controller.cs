using UnityEngine;
using UnityEngine.Video;

public class TVController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    public void PlayTV()
    {
        if (!videoPlayer.isPlaying)
        {
            videoPlayer.Play();
        }
    }

    public void PauseTV()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
        }
    }
}
