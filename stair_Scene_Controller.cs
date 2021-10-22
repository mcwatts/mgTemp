using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stair_Scene_Controller : MonoBehaviour
{
    string next_scene = "";
    void Start()
    {
        switch (SceneConfigManager.SceneConfig)
        {
            case 0: next_scene = "Vert_Rec"; break;
            case 1: next_scene = "Pyramid"; break;
            case 2: next_scene = "End"; break; //End
            case 3: next_scene = "Pyramid"; break;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene(next_scene);
        }
    }
}
