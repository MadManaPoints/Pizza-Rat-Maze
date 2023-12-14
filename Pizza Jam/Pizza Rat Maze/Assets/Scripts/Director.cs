using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Director : MonoBehaviour
{
    PlayableDirector director; 
    TriggerDialogue dialogue;
    void Start()
    {
        director = GetComponent<PlayableDirector>();
        dialogue = GameObject.Find("Player").GetComponent<TriggerDialogue>();
    }

    void Update()
    {
        if(dialogue.triggerScene){
            director.Play(); 
        }
    }
}
