using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Button : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        
    
    }
    public void Playbutton(){
        SceneManager.LoadScene("Game");
    }
}
