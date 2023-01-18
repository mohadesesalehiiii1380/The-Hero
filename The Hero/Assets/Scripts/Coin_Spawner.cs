using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Spawner : MonoBehaviour
{
    public GameObject coinPrefabs;
    
    // Start is called before the first frame update
    
    void Start()
    {
      StartCoroutine(CoinSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
       void CoinSpawn(){
           float rand= Random.Range(-2.41f,2.41f);
           Instantiate(coinPrefabs, new Vector3(rand,transform.position.y,transform.position.z), Quaternion.identity);

       }
       IEnumerator CoinSpawner(){
           while (true)
           {
              
               int time = Random.Range(4,10);
               yield return new WaitForSeconds(5);
               CoinSpawn();
               
           }
       }
    

}
