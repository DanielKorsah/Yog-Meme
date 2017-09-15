using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{


    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();

        if (scene.name != "Start Menu")
        {
            Destroy(gameObject);
        }
    }
}
