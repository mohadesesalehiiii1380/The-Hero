using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score= 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score = score + 1;
        Debug.Log("Score :" + score);
    }
}
