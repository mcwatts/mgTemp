using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stair_instruction_controller : MonoBehaviour
{
    public TMPro.TMP_Text gestureMode;
    void Start()
    {
        switch (SceneConfigManager.GestureConfig)
        {
            case 0: gestureMode.text += "Mid-Air Gestures"; break;
            case 1: gestureMode.text += "Microgestures"; break;
            case 2: gestureMode.text += "Mid-Air Gestures"; break;
            case 3: gestureMode.text += "Microgestures"; break;
        }
    }
}
