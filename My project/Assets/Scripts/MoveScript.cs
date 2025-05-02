using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Rigidbody2D Player;
    public float speed;
    

    private float Move;
    private bool isground = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");
        Player.velocity = new Vector2(Move * speed, Player.velocity.y);
        if (Input.GetKeyDown(KeyCode.Space) && isground==true)
        {
            Player.velocity=new Vector2(Player.velocity.x,3 );
            isground = false;
          
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
            isground = true;
        
    }
}
