using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float JumpVelocity;
    bool grounded;
    Animator animator;
    public Canvas canvas;
    public SpawnManager sm;
    public RepeatBackground bg;
    public RepeatBackground g1;
    public RepeatBackground g2;

    // Snowman enemy;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        bg =GameObject.Find("BackGround") .GetComponent<RepeatBackground>();
        g1 = GameObject.Find("Ground").GetComponent<RepeatBackground>();
        g2 = GameObject.Find("BottomGround").GetComponent<RepeatBackground>();
        sm = FindObjectOfType<SpawnManager>();
        //enemy = FindObjectOfType<Snowman>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            if (grounded)
            {
                Jump();
                animator.SetTrigger("Jump");
            }
        }


    }
   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Ground")
        {
            print("Grounded");
            grounded = true;
        }
        
       if(collision.gameObject.tag=="Enemy")
        {
            animator.SetTrigger("Dead");
            //animator.enabled = false;
            sm.CancelInvoke();
           bg.xoffset=0.0f ;
            g1.xoffset = 0f;
            g2.xoffset = 0f;

            
            
            canvas.gameObject.SetActive(true);
            //animator.SetTrigger("Idle");
            
            //enemy.enemyspeed = 0f;
        }
       
    }
   


    private void Jump()
    {
        grounded = false;

        playerRB.velocity = new Vector2(0, JumpVelocity);
        
    }
   
}
