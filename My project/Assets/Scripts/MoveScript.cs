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
    public float Jumpforce;
    public float Rate=3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Move = Input.GetAxis("Horizontal");
        Player.velocity = new Vector2(Move * speed, Player.velocity.y);
        
        if (Input.GetKeyDown(KeyCode.Space) && isground==true&& Timer<2)
        {
            
            Player.velocity=new Vector2(Player.velocity.x,Jumpforce);
            Timer++;
            
        }
        if (Timer >= 2)
        {
            isground = false;
            Timer = 0;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
            isground = true;
        
    }
}
