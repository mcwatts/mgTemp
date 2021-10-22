using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stair_controller : MonoBehaviour
{
    public GameObject cube_1, cube_2, cube_3, cube_4;
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
                case 0: pyramidAnimation(cube_3, "3_shrink"); break;
                case 1: pyramidAnimation(cube_2, "4_cc_roll"); break; 
                case 2: pyramidAnimation(cube_2, "2_pitch_up"); ; break; // picture
                case 3: pyramidAnimation(cube_2, "2_yaw_left"); break;  
                case 4: pyramidAnimation(cube_3, "3_back"); break;
                case 5: pyramidAnimation(cube_1, "1_foward"); break; //Spelling
                case 6: pyramidAnimation(cube_1, "1_roll_right"); break;
                case 7: pyramidAnimation(cube_1, "1_enlarge"); break;
                case 8: pyramidAnimation(cube_1, "1_yaw_right"); break;
                case 9: pyramidAnimation(cube_4, "4_move_up"); break;
                case 10: pyramidAnimation(cube_4, "4_move_left"); break;
                case 11: pyramidAnimation(cube_4, "4_pitch_up"); break; //actually down
                case 12: pyramidAnimation(cube_4, "4_move_down"); break;
                case 13: pyramidAnimation(cube_1, "1_right"); break;
            }
            counter++;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            SceneManager.LoadScene("ConfigScene");
        }
    }

    void pyramidAnimation(GameObject obj, string ani_name)
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
            case 1: text.text = "Roll the red cube counterclockwise."; break;
            case 2: text.text = "Pitch the red cube up."; break;
            case 3: text.text = "Yaw the red cube to the left."; break;
            case 4: text.text = "Move the pink cube backwards."; break;
            case 5: text.text = "Move the blue cube forward."; break;
            case 6: text.text = "Roll the blue cube clockwise."; break;
            case 7: text.text = "Make the blue cube larger."; break;
            case 8: text.text = "Yaw the blue cube to the right."; break;
            case 9: text.text = "Move the green cube up"; break;
            case 10: text.text = "Move the green cube to the left."; break;
            case 11: text.text = "Pitch the green cube down."; break;
            case 12: text.text = "Move the green cube down."; break;
            case 13: text.text = "Move the blue cube to the right.";
                Invoke("SectionComplete", 4f); 
                break;
        }
    }
    void SectionComplete()
    {
        text.text = "Section Complete";
    }
}
