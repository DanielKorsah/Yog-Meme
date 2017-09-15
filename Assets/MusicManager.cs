using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    AudioControls source;

    // Use this for initialization
    void Start()
    {
        GameObject music = GameObject.Find("Music Player");
        source = music.GetComponent<AudioControls>();
    }


    public void MutePassthrough()
    {
        source.Mute();
    }
}
