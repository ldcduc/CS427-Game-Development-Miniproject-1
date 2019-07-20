using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterKillsBoth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if ((collision.gameObject.name == "Cutegirl" || collision.gameObject.name == "Flatboy") && !collision.gameObject.GetComponent<Animator>().GetBool("isDead")) {
            collision.gameObject.GetComponent<Animator>().SetBool("isDead", true);
        } 
    }

    private void OnCollisionExit2D(Collision2D collision) {
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
    }

    void OnTriggerExit2D(Collider2D collision)
    {
    }
}
