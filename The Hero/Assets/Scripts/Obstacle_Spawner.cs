using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Spawner : MonoBehaviour
{
    public GameObject[] obstacle;
    void Start()
    {
       StartCoroutine(SpawnObstacles());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void obstacles (){
        int rand = Random.Range(0,obstacle.Length);
        Instantiate(obstacle[rand],transform.position,Quaternion.identity);

    }
    IEnumerator SpawnObstacles(){
        while (true)
        {
              yield return new WaitForSeconds(4);
        obstacles();
        }
      
    }
}
