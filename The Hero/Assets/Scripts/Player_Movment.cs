using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movment : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform transform;
    public float speed = 0.1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.position += new Vector3 (speed * Time.deltaTime , 0,0);
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.position -= new Vector3 (speed * Time.deltaTime , 0,0);
        }
        if(transform.position.x < -2.41f){
             transform.position = new Vector3(-2.41f, transform.position.y,transform.position.z);
        }
          if(transform.position.x > 2.41f){
             transform.position = new Vector3(2.41f,transform.position.y,transform.position.z);
        }
    }
}
