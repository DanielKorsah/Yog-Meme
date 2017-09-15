using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void HubScene()
    {
        SceneManager.LoadScene("PersonPicker");
    }

    public void NextScene()
    {
        SceneManager.LoadScene("Character Creation");
    }


}
