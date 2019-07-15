using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlatboyController : MonoBehaviour
{
    Vector2 newPos;

    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        newPos = transform.position;        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            newPos.x -= speed;
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            newPos.x += speed;
        }
        transform.position = newPos;
    }
}
