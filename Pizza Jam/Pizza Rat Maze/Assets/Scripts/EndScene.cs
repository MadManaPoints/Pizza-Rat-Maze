using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    public bool end; 
  
    void Update()
    {
        if(end){
            SwitchScene(); 
        }
    }

    public void SwitchScene(){
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
    }
}
