using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlatboyMovement : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    public float moveSpeed = 1f;
    public float jumpSpeed = 4f;
    public bool isGrounded = false;
    public bool isJumping = false;
    public bool isRunning = false;
    public bool isWalking = false;
    const float runSpeed = 3f;
    const float walkSpeed = 1f;
    float dirX = 0f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("BoyJump")) {
            anim.SetBool("isJumping", true);
            rb.AddForce(new Vector2(0f, jumpSpeed), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.DownArrow)) 
            moveSpeed = walkSpeed;
        else moveSpeed = runSpeed;

        if (Input.GetKey(KeyCode.LeftArrow)) {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            GetComponent<SpriteRenderer>().flipX = false;
        }

        SetAnimationState();

        if (!anim.GetBool("isDead")) 
            dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;
    }

    void FixedUpdate() {
        rb.velocity = new Vector2(dirX, rb.velocity.y);
    }

    void SetAnimationState() {
        if (isGrounded == true) {
            anim.SetBool("isJumping", false);
        }

        if (Mathf.Abs(dirX) == walkSpeed && anim.GetBool("isJumping") == false)
            anim.SetBool("isWalking", true);
        else 
            anim.SetBool("isWalking", false);
        if (Mathf.Abs(dirX) == runSpeed && anim.GetBool("isJumping") == false) 
            anim.SetBool("isRunning", true);
        else 
            anim.SetBool("isRunning", false);

        // Debug.Log(isGrounded + " " + " isJumping:" + anim.GetBool("isJumping"));
        // Debug.Log("isWalking:" + anim.GetBool("isWalking"));
        // Debug.Log("isRunning:" + anim.GetBool("isRunning"));
        Debug.Log("isJumping:" + anim.GetBool("isJumping"));
        Debug.Log("isWalking:" + anim.GetBool("isWalking"));
        Debug.Log("isRunning:" + anim.GetBool("isRunning"));
        isRunning = anim.GetBool("isRunning");
        isJumping = anim.GetBool("isJumping");
        isWalking = anim.GetBool("isWalking");
    }
}
