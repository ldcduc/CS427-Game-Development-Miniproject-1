using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastSwitch : MonoBehaviour
{
    [SerializeField] private GameObject platform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            gameObject.GetComponent<Animator>().SetBool("isTouched", true);
            platform.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            gameObject.GetComponent<Animator>().SetBool("isTouched", false);
        }
    }
}
