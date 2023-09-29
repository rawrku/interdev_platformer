using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    float horizontalMove;
    public float speed = 7f;

    Rigidbody2D myBody;
    Animator myAnim;
    SpriteRenderer mySprite;

    // checking to see if weather or not we are allowed to jump
    bool grounded = false;
    public float castDist = 1f;

    // varibles to jump lol
    // power of jump
    public float jumpPower = 30f;
    // scale of jump
    public float gravityScale = 15f;
    // scale of the fall
    public float gravityFall = 20f;

    // bool holding the varible to check if we should jump or not
    bool jump = false;

    void Start()
    {

        myBody = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
        mySprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump") && grounded)
        {
            myAnim.SetBool("jumping", true);
            jump = true;
        }

        if (horizontalMove > 0.2f || horizontalMove < -0.2f)
        {
            myAnim.SetBool("running", true);
        } else
        {
            myAnim.SetBool("running", false);
        }

        if (horizontalMove > -1)
        {
            
            mySprite.flipX = false;
        }
        if (horizontalMove < 0)
        {
            Debug.Log(horizontalMove);
            mySprite.flipX = true;
        }
    }

    void FixedUpdate()
    {
        if (jump)
        {
            myBody.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jump = false;
        }

        if (myBody.velocity.y > 0)
        {
            myBody.gravityScale = gravityScale;
        } else if (myBody.velocity.y < 0)
        {
            myBody.gravityScale = gravityFall;
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, castDist);
        Debug.DrawRay(transform.position, Vector2.down * castDist, Color.red);

        if (hit.collider != null && hit.transform.name == "Ground")
        {
            myAnim.SetBool("jumping", false);
            grounded = true;
        } else
        {
            grounded = false; 
        }

        float movespeed = horizontalMove * speed;
        myBody.velocity = new Vector3(movespeed, myBody.velocity.y, 0f);
    }
}
