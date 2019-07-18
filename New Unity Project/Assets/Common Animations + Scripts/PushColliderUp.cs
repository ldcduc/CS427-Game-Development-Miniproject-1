using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SettingNamespace;

public class PushColliderUp : MonoBehaviour
{
    private float jumpSpeed = Settings.jumpFactor * Settings.jumpForce;
    void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 6*jumpSpeed), ForceMode2D.Impulse);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
    }
}
