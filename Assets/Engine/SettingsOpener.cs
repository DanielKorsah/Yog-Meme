using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsOpener : MonoBehaviour
{

    public Animator dropper;
    [SerializeField]
    private GameObject settings;


    void Awake()
    {
        dropper = gameObject.GetComponent<Animator>();
    }

    public void Open()
    {
        dropper.SetBool("isOpen", true);
    }

    public void Close()
    {
        dropper.SetBool("isOpen", false);
    }


}
