using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sea_Movment : MonoBehaviour
{
     public Renderer meshRenderer;
     public float speed =0.5f;
    void Start()
    {
       

    }

  
    void Update()
    {
       Vector2 offset =  meshRenderer.material.mainTextureOffset;
       offset = offset + new Vector2(0,speed * Time.deltaTime);
       meshRenderer.material.mainTextureOffset = offset;
        
    }
}
