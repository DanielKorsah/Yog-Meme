using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Person
{

    private string name;
    private int relationship;
    private static string status;
    [SerializeField]
    private Image uiPic;
    [SerializeField]
    private Sprite spritePic;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Relationship
    {
        get { return relationship; }
        set { relationship = value; }
    }

    public string Status()
    {
        //set status accordium to corresponding relationship values
        if (relationship >= 100)
        {
            status = "Lover";
        }
        else if (relationship >= 80 && relationship < 100)
        {
            status = "F(l)uck(s) Buddies";
        }
        else if (relationship >= 60 && relationship < 80)
        {
            status = "Testificate Ticklers";
        }
        else if (relationship >= 40 && relationship < 60)
        {
            status = "Gym Buddies";
        }
        else if (relationship >= 60 && relationship < 70)
        {
            status = "Besties";
        }
        else if (relationship >= 50 && relationship < 60)
        {
            status = "Interested";
        }
        else if (relationship >= 40 && relationship < 50)
        {
            status = "Friendly";
        }
        else if (relationship >= 20 && relationship < 40)
        {
            status = "Acquaintence";
        }
        else if (relationship >= 0 && relationship < 20)
        {
            status = "Strangers";
        }


        if (status == null || status == "")
        {
            return "STATUS BUG";
        }
        else
        {
            return status;
        }
    }

    public Image UI_PIC
    {
        get { return uiPic; }
    }

    public Sprite SPRITE_PIC
    {
        get { return spritePic; }
    }

}
