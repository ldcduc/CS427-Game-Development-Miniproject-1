using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationDoor : MonoBehaviour
{
    [SerializeField] private Collider2D flatBoy;
    [SerializeField] private Collider2D cuteGirl;
    private Animator anim;
    // Start is called before the first frame update
    public bool isTouched = false;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       isTouched = anim.GetBool("isTouched"); 
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            collision.gameObject.GetComponent<FinishScript>().finished = true;
            anim.SetBool("isTouched", true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            collision.gameObject.GetComponent<FinishScript>().finished = false;
            anim.SetBool("isTouched", false);
        }
    }
}
