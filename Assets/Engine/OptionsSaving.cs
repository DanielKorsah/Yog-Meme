using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsSaving
{
    private float volume;
    private int mute;

    private static OptionsSaving instance = null;

    private OptionsSaving()
    {
    }

    public static OptionsSaving Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new OptionsSaving();
            }
            return instance;
        }
    }


    public float Volume
    {
        get { return volume; }
        set { volume = value; }
    }

    public int Mute
    {
        get { return mute; }
        set { mute = Mathf.Clamp(value, 0, 1); }
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("volume", volume);
        PlayerPrefs.SetInt("mute", mute);
    }
}



