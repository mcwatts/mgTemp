using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vertRec_controller : MonoBehaviour
{
    public GameObject cube_1, cube_2, cube_3, cube_4, cube_5;
    int counter = 0;
    public TMPro.TMP_Text text;
    bool next = true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) && next)
        {
            next = false;
            switch (counter)
            {
                case 0: vertRecAnimation(cube_5, "5_down"); break; 
                case 1: vertRecAnimation(cube_5, "5_move_left"); break; 
                case 2: vertRecAnimation(cube_5, "5_enlarge"); break; 
                case 3: vertRecAnimation(cube_4, "4_shrink"); break; 
                case 4: vertRecAnimation(cube_4, "1_pitch_up"); break; //picture
                case 5: vertRecAnimation(cube_2, "2_roll_cc"); break; 
                case 6: vertRecAnimation(cube_3, "3_roll_clock"); break; 
                case 7: vertRecAnimation(cube_3, "3_yaw_left"); break; //picture
                case 8: vertRecAnimation(cube_4, "4_forward"); break; 
                case 9: vertRecAnimation(cube_1, "1_pitch_down"); break; //picture
                case 10: vertRecAnimation(cube_1, "1_away"); break; 
                case 11: vertRecAnimation(cube_1, "1_yaw_right"); break; //picture
                case 12: vertRecAnimation(cube_1, "1_move_right"); break; 
                case 13: vertRecAnimation(cube_5, "5_move_up"); break;
                //case 14: text.text = "Section Complete"; break; 
            }
            counter++;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            SceneManager.LoadScene("ConfigScene");
        }
    }

    void vertRecAnimation(GameObject obj, string ani_name)
    {
        Animator an = obj.GetComponent<Animator>();
        an.Play(ani_name);
        Invoke("AnimationComplete", an.speed+2.15f);
    }

    void AnimationComplete()
    {
        next = true;
        switch (counter)
        {
            case 1: text.text = "Move the pink cube to the left."; break;
            case 2: text.text = "Make the pink cube larger."; break;
            case 3: text.text = "Make the blue cube smaller."; break;
            case 4: text.text = "Pitch the blue cube up."; break;
            case 5: text.text = "Roll the red cube counterclockwise."; break;
            case 6: text.text = "Roll the orange cube clockwise."; break;
            case 7: text.text = "Yaw the orange cube to the left."; break;
            case 8: text.text = "Move the blue cube forward."; break;
            case 9: text.text = "Pitch the green cube down."; break;
            case 10: text.text = "Move the green cube backward."; break;
            case 11: text.text = "Yaw the green cube to the right."; break;
            case 12: text.text = "Move the green cube to the right."; break;
            case 13: text.text = "Move the pink cube up.";
                Invoke("SectionComplete",4f); 
                break;
        }
    }

    void SectionComplete()
    {
        text.text = "Section Complete";
    }
}
