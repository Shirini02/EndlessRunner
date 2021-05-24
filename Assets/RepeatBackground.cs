using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Material bgMat;
    public float xoffset;
    Animator anim;
    PlayerMovement pl;


    void Start()
    {
        bgMat = GetComponent<MeshRenderer>().material;
        anim = GetComponent<Animator>();
        pl = GetComponent<PlayerMovement>();
    }


    private void FixedUpdate()
    {
        bgMat.mainTextureOffset = new Vector2(xoffset * Time.time, 0);
       
    }
    
   
}
