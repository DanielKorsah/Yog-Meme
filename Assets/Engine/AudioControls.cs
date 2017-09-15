using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControls : MonoBehaviour
{
    public AudioSource musicSource;
    void Start()
    {
        musicSource = gameObject.GetComponent<AudioSource>();

    }

    public void Mute()
    {
        OptionsSaving save = OptionsSaving.Instance;
        Debug.Log(musicSource.gameObject.name + " " + musicSource.mute);
        musicSource.mute = !musicSource.mute;

        if (musicSource.mute == false) { save.Mute = 0; }
        else { save.Mute = 1; }

        save.Save();
    }
}
