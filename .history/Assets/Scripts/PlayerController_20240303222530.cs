using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

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
           onGround = false;
        }

        
    }

    public void die() {
        //death
         // Get the current scene index
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Reload the current scene
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void Hit(int damage) {
        currHealth -= damage;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "NormalDimension" 
            || collision.gameObject.tag == "GlitchedDimension"
            || collision.gameObject.tag == "Ground")
        {
            onGround = true;
        }
        if (collision.gameObject.CompareTag("GlitchedDimensionTrap") || collision.gameObject.CompareTag("NormalDimensionTrap"))
        {
            Debug.Log("Player hit the spike!");
            die();
            //death
        }
        if (collision.gameObject.CompareTag("JumpBoost"))
        {
            
            //death
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
