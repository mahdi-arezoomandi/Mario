using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Rigidbody2D Player;
    public float speed;
    public float Timer=0;
    private float Move;
    private bool isground = true;
    private bool isStop= true;
    public float Jumpforce;
   
    public Animator ANmove;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      
            if (Input.GetKeyDown(KeyCode.Space) && isground == true && Timer < 2)
            {
                ANmove.SetBool("isground", false);
                Player.velocity = new Vector2(Player.velocity.x, Jumpforce);
                Timer++;

            }
            if (Timer >= 2)
            {
                isground = false;
                Timer = 0;
            }
            if (Player.velocity.x > 0 || Player.velocity.x < 0)
                ANmove.SetBool("static", false);
            else
                ANmove.SetBool("static", true);
            flip();
        
    }
    private void FixedUpdate()
    {
        if (isStop == false)
        {


            Move = Input.GetAxis("Horizontal");
            Player.velocity = new Vector2(Move * speed, Player.velocity.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            isground = true;
            isStop = false;
            ANmove.SetBool("isground", true);
        }
        if (collision.gameObject.CompareTag("Stop"))
        {
            isStop = true;

        }
       
        

    }
    private void flip()
    {
        if (Player.velocity.x < 0)
            transform.localScale = new Vector2(-1, 1);
        else if(Player.velocity.x > 0)
            transform.localScale = new Vector2(1, 1);
    }      
    }
