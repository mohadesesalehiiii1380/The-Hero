using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class Score_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public int score= 0;
    public Text scoreText;
    public int highScore;
    void Start()
    {
     StartCoroutine(Score());  
     highScore=0; 
    }

    // Update is called once per frame
    void Update()
    {
       scoreText.text = score.ToString();
       if(score > highScore){
          highScore= score;
          Debug.Log(highScore);
       }
    }
    IEnumerator Score(){
       while (true)
       {
            yield return new WaitForSeconds(2);
         score = score + 1;
       // Debug.Log("Score :" + score);
       }
    }
}
