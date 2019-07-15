using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlatboyMovement : MonoBehaviour
{
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(-speed, 0));
            GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
