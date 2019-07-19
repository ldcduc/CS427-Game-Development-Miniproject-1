﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SettingNamespace;

public class CutegirlMovement : MonoBehaviour
{
    AudioSource jumpAudio;
    [SerializeField] private GameObject camera;
    private GameObject otherPlayer;
    private Animator anim;
    private Rigidbody2D rb;
    private float runSpeed = Settings.factor * Settings.runSpeed;
    private float walkSpeed = Settings.factor * Settings.walkSpeed;
    private float jumpSpeed = Settings.jumpFactor * Settings.jumpForce;
    private float moveSpeed = 0.01f;

    public bool isGrounded = false;
    public bool isJumping = false;
    public bool isRunning = false;
    public bool isWalking = false;
    public bool isDead = false;

    public int score = 0;
    private float maxDistance = 1000f;
    Vector2 newPos;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        otherPlayer = GameObject.Find("Flatboy");
        maxDistance = camera.GetComponent<CameraWithPlayers>().maxDistance;
        jumpAudio = gameObject.GetComponent<AudioSource>();
        Debug.Log(jumpAudio);
    }

    bool CheckOutOfBound(float x) {
        return (Mathf.Abs(x - otherPlayer.transform.position.x) < maxDistance);
    }

    // Update is called once per frame
    void Update()
    {
        newPos = transform.position;

        isGrounded = Mathf.Abs(rb.velocity.y) < 1e-6;
        if (Input.GetButtonDown("GirlJump") && isGrounded) {
            rb.AddForce(new Vector2(0f, jumpSpeed), ForceMode2D.Impulse);
            jumpAudio.Play();
        } 

        anim.SetBool("isJumping", !isGrounded);
        if (!isGrounded) {
            anim.SetBool("isRunning", false);
            anim.SetBool("isWalking", false);
        }

        if (Input.GetKey(KeyCode.S)) 
            moveSpeed = walkSpeed;
        else moveSpeed = runSpeed;

        string stringAction = moveSpeed == walkSpeed ? "isWalking" : "isRunning";
        string stringActionNot = moveSpeed != walkSpeed ? "isWalking" : "isRunning";
        if (Input.GetKey(KeyCode.A)) {
            GetComponent<SpriteRenderer>().flipX = true;
            newPos.x -= (CheckOutOfBound(newPos.x - moveSpeed)) ? moveSpeed: 0;
            transform.position = newPos;
            anim.SetBool(stringAction, true);
            anim.SetBool(stringActionNot, false);
        }
        else if (Input.GetKey(KeyCode.D)) {
            GetComponent<SpriteRenderer>().flipX = false;
            newPos.x += (CheckOutOfBound(newPos.x + moveSpeed)) ? moveSpeed: 0;
            transform.position = newPos;
            anim.SetBool(stringAction, true);
            anim.SetBool(stringActionNot, false);
        }
        else {
            anim.SetBool("isRunning", false);
            anim.SetBool("isWalking", false);
        }

        isRunning = anim.GetBool("isRunning");
        isJumping = anim.GetBool("isJumping");
        isWalking = anim.GetBool("isWalking");
        isDead = anim.GetBool("isDead");
    }
}
