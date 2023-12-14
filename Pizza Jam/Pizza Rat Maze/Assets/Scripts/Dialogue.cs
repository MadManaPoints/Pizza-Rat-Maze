using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TMP_Text text;
    TriggerDialogue opening;
    string[] dialogue = new string [] {"RAT: You know what's REALLY delicious?! PIZZA! That's why I'm here.", "SNAKE: I didn't ask for your life story.", "RAT: FINE! Catch me if you can, jerk.", "SNAKE: AHHHHHHHHHHH!"};
    int dialogueIndex = 0; 

    //SORRY THIS SCRIPT IS A MESS. IT IS LATE AND I DO NOT WANT TO WATCH TUTORIALS SO I AM GOING IN BLIND 
    void Start()
    {
        opening = GameObject.Find("Player").GetComponent<TriggerDialogue>(); 
    }

    // Update is called once per frame
    void Update()
    {   
        if(opening.speak){
            text.text = "RAT: DEAD END! DEAD END! RUN AWAAAAYYY!";
        }

        if(opening.snake){
            text.text = "SNAKE: GET BACK HERE! YOU LOOK DELICIOUS!"; 
        }

        if(opening.triggerScene){
            for(int i = 0; i < dialogue.Length; i++){
                text.text = dialogue[dialogueIndex];
            }
        }
    }

    public void Next(){
        dialogueIndex += 1; 
    }
}
