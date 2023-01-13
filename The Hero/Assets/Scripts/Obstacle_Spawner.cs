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
        float randXPos = Random.Range(-2.41f , 2.41f);
        Instantiate(obstacle[rand],new Vector3(randXPos,transform.position.y,transform.position.z ),Quaternion.identity);

    }
    IEnumerator SpawnObstacles(){
        while (true)
        {
              yield return new WaitForSeconds(4);
        obstacles();
        }
      
    }
}
