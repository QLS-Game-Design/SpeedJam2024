using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float currHealth;
    public float maxHealth;
    public float speed;
    Rigidbody2D rb;
    public float jumpForce = 6f;
    public float horizontalMove = 0f;
    public bool onGround = true;
    private float timeFromLastJump = 0f;
    private bool jumpQueued = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        maxHealth = 100;
        currHealth = maxHealth;
        speed = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (maxHealth <= 0) {
            Destroy(gameObject);
        }

        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;

        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
           timeFromLastJump = 0;
           jumpQueued = true;
        }
        else
        {
           timeFromLastJump += Time.deltaTime;
        }
        if (onGround && timeFromLastJump < 0.2 && jumpQueued)
        {
           rb.velocity = Vector2.up * jumpForce;
           jumpQueued = false;
        }

        
    }

    

    public void Hit(int damage) {
        currHealth -= damage;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "NormalDimension" 
            || collision.gameObject.tag == "GlitchedDimension")
        {
            onGround = true;
        }
    }
 
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "NormalDimension" 
            || collision.gameObject.tag == "GlitchedDimension")
        {
            onGround = false;
        }
    }
}
