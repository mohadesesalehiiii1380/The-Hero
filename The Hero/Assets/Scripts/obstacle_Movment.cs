using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_Movment : MonoBehaviour
{
    // Start is called before the first frame update
      public Transform transform;
    public float speed=4f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         transform.position -= new Vector3(0, speed * Time.deltaTime);
    }
}
