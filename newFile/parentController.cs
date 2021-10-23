using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentController : MonoBehaviour
{
     public GameCube parent;
     
     void Update{
          if(Input.getKeyDown(KeyCode.UpArrow){
              //move display up
              parent.transform.position = new Vector(0,0.1,0);
          }
          if(Input.getKeyDown(KeyCode.DownArrow){
              //move display down
              parent.transform.position = new Vector(0,-0.1,0);
          }
          
     }
}
