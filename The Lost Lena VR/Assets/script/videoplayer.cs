using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class videoplayer : MonoBehaviour
{
    public GameObject videoPlayer;
    public int timeToStop;

    private void Start()
    {
        videoPlayer.SetActive(false);
    }
    private void OnTriggerEnter(Collider player)
    {
        if(player.gameObject.tag == "MainCamera")
        {
            videoPlayer.SetActive(true);
            Destroy(videoPlayer, timeToStop);
        }
    }
}
