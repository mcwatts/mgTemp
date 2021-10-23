using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class horRec_controller : MonoBehaviour
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
                case 0: horRecAnimation(cube_2, "2_yaw_left"); break;
                case 1: horRecAnimation(cube_2, "2_enlarge"); break;
                case 2: horRecAnimation(cube_1, "1_cc_roll"); break;
                case 3: horRecAnimation(cube_1, "1_shrink"); break;
                case 4: horRecAnimation(cube_3, "3_pitch_up"); break;
                case 5: horRecAnimation(cube_3, "3_away"); break;
                case 6: horRecAnimation(cube_4, "4_c_roll"); break;
                case 7: horRecAnimation(cube_4, "4_pitch_down"); break;
                case 8: horRecAnimation(cube_4, "4_towards"); break;
                case 9: horRecAnimation(cube_5, "5_yaw_right"); break;
                case 10: horRecAnimation(cube_5, "5_move_right"); break; //Actually left
                case 11: horRecAnimation(cube_1, "1_up"); break;
                case 12: horRecAnimation(cube_1, "1_right"); break;
                case 13: horRecAnimation(cube_1, "1_down"); break;
               // case 14: text.text = "Section Complete"; break;
            }
            counter++;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            SceneManager.LoadScene("ConfigScene");
        }
    }

    void horRecAnimation(GameObject obj, string ani_name)
    {
        Animator an = obj.GetComponent<Animator>();
        an.Play(ani_name);
        Invoke("AnimationComplete", an.speed + 2.15f);
    }

    void AnimationComplete()
    {
        next = true;
        switch (counter)
        {
            case 1: text.text = "Make the blue cube larger."; break;
            case 2: text.text = "Roll the red cube counterclockwise."; break;
            case 3: text.text = "Make the red cube smaller."; break;
            case 4: text.text = "Pitch the pink cube up."; break;
            case 5: text.text = "Move the pink cube away from you."; break; //case 5: text.text = "Move the pink cube backward."; break;
            case 6: text.text = "Roll the green cube clockwise."; break;
            case 7: text.text = "Pitch the green cube down."; break;
            case 8: text.text = "Move the green cube towards you."; break; //case 8: text.text = "Move the green cube forward."; break;
            case 9: text.text = "Yaw the orange cube to the right."; break;
            case 10: text.text = "Move the orange cube to the left."; break;
            case 11: text.text = "Move the red cube up."; break;
            case 12: text.text = "Move the red cube to the right."; break;
            case 13: text.text = "Move the red cube down.";
                Invoke("SectionComplete", 4f); 
                break;
        }
    }
    void SectionComplete()
    {
        text.text = "Section Complete";
    }
}
