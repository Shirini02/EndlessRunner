using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman : MonoBehaviour
{
    Rigidbody2D Rg;
    public float movespeed;
    //Animator animator;

  
    // Start is called before the first frame update
    void Start()
    {
        Rg = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void FixedUpdate()
    {
        Rg.velocity = Vector2.left * movespeed;
        

        if(transform.position.x<-6.92f)
        {
            Destroy(gameObject);
        }
    }
   
}
