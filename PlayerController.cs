using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
    public Rigidbody2D rb; // Reference to Rigidbody2D.
    public GameObject player; // Reference to the player GameObject.

    public SpriteRenderer playerSprite; // Reference to the sprite renderer. (to flip the sprite)

    Animator anim; // Reference to the Animator of the player animations. (To change the animation states)

    public float jumpHeight; // The jumping height.
    public float walkSpeed; // The walking speed.

    bool canJump; // Can the player jump? (1 jump limit)
    bool grounded; // Is the player touching the floor?
    bool jumpAnimRunning; // Is the jumping animation playing?
    bool firstHit; // Is it the first touch with the ground?

    public static bool canMove = true; // Not the best solution, might want to schange next time!

    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody2D>(); // Assigning the rigidbody to a variable.
        anim = GetComponent<Animator>(); // Assigning the Animator to a variable.
    }

    // Update is called once per frame
    void Update()
    {
        float x; // The x velocity of the player.
        float y; // The y velocity of the player.

        if (!PlayerController.canMove) // Again, not ideal way of implementing!
        {
            anim.SetInteger("State", 0);
        }

        if (grounded && canMove) // If the player is touching the ground...
        {
            canJump = true; // Set the canJump variable to true. (the player may now jump)
        }
        else if (!grounded && canMove) // If the player isn't touching the ground.
        {
            anim.SetInteger("State", 2); // Change the player animation to Jumping. 
            jumpAnimRunning = true; // Set the jumpAnimRunning variable to true. (The jumping animation is playing)

            canJump = false; // Set the canJump variable to false. (the player may not jump because he has already jumped once)
        }


        if (Input.GetKeyDown(KeyCode.Space) && canJump && canMove) // If spacebar is pressed and if the player may jump.
        {
            x = rb.velocity.x; // Set 'x' to the velocity.x of the player
            rb.velocity = new Vector2(x, jumpHeight); // Change the vertical velocity. (results in jumping)

            grounded = false; // Set the grounded variable to false. (Player isn't touching the ground)
        }

        ////
        if (Input.GetKey(KeyCode.A) && canMove) // If the player holds down the A key...
        {
            y = rb.velocity.y; // Set 'y' to the velocity.y of the player
            rb.velocity = new Vector2(-walkSpeed, y); // Change the horizontal velocity. (results in walking) 
            playerSprite.flipX = true; // Flip the player sprite. (now facing left)

            if (!jumpAnimRunning && canMove) // If the jump animation isn't playing...
            {
                anim.SetInteger("State", 1); // Change the player animation to Walking. 
            }

            if (Input.GetKeyDown(KeyCode.Space) && canMove) // If spacebar is pressed while A is held down...
            {
                anim.SetInteger("State", 2); // Change the player animation to Jumping.     
            }
        }

        if (Input.GetKeyUp(KeyCode.A) && canMove) // If the player lets go of the A key...
        {
            if (!jumpAnimRunning && canMove) // If the jump animation isn't playing...
            {
                anim.SetInteger("State", 0); // Change the player animation to Idle. 
            }
        }

        ////
        if (Input.GetKey(KeyCode.D) && canMove) // If the player holds down the D key...
        {
                y = rb.velocity.y; // Set 'y' to the velocity.y of the player
                rb.velocity = new Vector2(walkSpeed, y); // Change the horizontal velocity. (results in walking) 
                playerSprite.flipX = false; // Flip the player sprite. (now facing right)

                if (!jumpAnimRunning && canMove) // If the jump animation isn't playing...
                {
                    anim.SetInteger("State", 1); // Change the player animation to Walking. 
                }

                if (Input.GetKeyDown(KeyCode.Space) && canMove) // If spacebar is pressed while D is held down.
                {
                    anim.SetInteger("State", 2); // Change the player animation to Jumping.  
                }
        }

        if (Input.GetKeyUp(KeyCode.D) && canMove) // If the player lets go of the D key...
        {
            if (!jumpAnimRunning && canMove) // If the jump animation isn't playing...
            {
                anim.SetInteger("State", 0); // Change the player animation to Idle. 
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        firstHit = true; // Set the firstHit variable to true. (it is the first hit)
        if (firstHit && canMove) // If firstHit is true...
        {
            anim.SetInteger("State", 0); // Change the player animation to Idle.  
            firstHit = false; // Set the firstHit variable to true. 
        }


        jumpAnimRunning = false; // Set the jumpAnimRunning to false. (the jumping animation isn't playing) 
        grounded = true; // Set the grounded variable to true. (the player is touching the ground)
    }
}
