using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialogue : MonoBehaviour
{
    public bool speak;
    public bool snake;
    public bool triggerScene; 

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Open"){
            speak = true; 
        }

        if(col.gameObject.tag == "Off Screen"){
            speak = false;
            snake = true; 
        }

        if(col.gameObject.tag == "Scene"){
            snake = false;
            triggerScene = true; 
        }
    }
}
