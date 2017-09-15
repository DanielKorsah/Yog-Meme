using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSave
{
    private static CharacterSave instance;

    private CharacterSave() { }

    public static CharacterSave Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new CharacterSave();
            }
            return instance;
        }
    }

    private GameObject playerCharater;

    public GameObject PlayerCharacter
    {
        get { return playerCharater; }
        set { playerCharater = value; }
    }

}
