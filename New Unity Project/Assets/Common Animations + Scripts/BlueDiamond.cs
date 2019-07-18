using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDiamond : MonoBehaviour
{
    [SerializeField] private Collider2D cuteGirl;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), cuteGirl);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.name == "Flatboy") {
            collision.gameObject.GetComponent<FlatboyMovement>().score += 1;
            Destroy(gameObject);
        } 
    }

    private void OnCollisionExit2D(Collision2D collision) {
    }
}
