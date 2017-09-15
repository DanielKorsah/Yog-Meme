using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CCManager : MonoBehaviour
{
    GameObject character;
    List<GameObject> faceParts = new List<GameObject>();

    public List<Sprite> heads = new List<Sprite>();
    public List<Sprite> hairs = new List<Sprite>();
    public List<Sprite> eyes = new List<Sprite>();
    public List<Sprite> noses = new List<Sprite>();
    public List<Sprite> mouths = new List<Sprite>();

    int head_i = 3;
    int hair_i = 3;
    int eyes_i = 3;
    int nose_i = 3;
    int mouth_i = 3;

    void Start()
    {

        character = GameObject.Find("Player");

        //get all child objects
        for (int i = 0; i < 5; i++)
        {
            faceParts.Add(character.gameObject.transform.GetChild(i).gameObject);

        }

        Cycle(faceParts[0], heads, ref head_i);
        Cycle(faceParts[1], hairs, ref hair_i);
        Cycle(faceParts[2], eyes, ref eyes_i);
        Cycle(faceParts[3], noses, ref nose_i);
        Cycle(faceParts[4], mouths, ref mouth_i);
    }

    void Cycle(GameObject feature, List<Sprite> sprite, ref int i)
    {
        SpriteRenderer SR = feature.GetComponent<SpriteRenderer>();

        if (i < sprite.Count - 1)
        {
            i++;
            SR.sprite = sprite[i];
            Debug.Log(SR.sprite);
        }
        else
        {
            i = 0;
            SR.sprite = sprite[i];
        }

        CharacterSave player = CharacterSave.Instance;
        player.PlayerCharacter = character;
    }

    public void Head()
    {
        Cycle(faceParts[0], heads, ref head_i);
    }

    public void Hair()
    {
        Cycle(faceParts[1], hairs, ref hair_i);
    }

    public void Eyes()
    {
        Cycle(faceParts[2], eyes, ref eyes_i);
    }

    public void Nose()
    {
        Cycle(faceParts[3], noses, ref nose_i);
    }

    public void Mouth()
    {
        Cycle(faceParts[4], mouths, ref mouth_i);
    }



}
