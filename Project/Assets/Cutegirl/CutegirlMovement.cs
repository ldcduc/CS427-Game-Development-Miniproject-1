using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutegirlMovement : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    public float moveSpeed = 1f;
    public float jumpSpeed = 4f;

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
        if (Input.GetKey(KeyCode.A)) {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey(KeyCode.D)) {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        dirX = Input.GetAxisRaw("Horizontal") * moveSpeed;
    }

    void FixedUpdate() {
        rb.velocity = new Vector2(dirX, rb.velocity.y);
    }
}
