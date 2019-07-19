using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpMovementScript : MonoBehaviour
{
    [SerializeField] private GameObject text1;
    [SerializeField] private GameObject text2;
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
        if (collision.gameObject.name == "Flatboy") {
            text2.SetActive(true);
        }
        if (collision.gameObject.name == "Cutegirl") {
            text1.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Flatboy") {
            text2.SetActive(false);
        }
        if (collision.gameObject.name == "Cutegirl") {
            text1.SetActive(false);
        }
    }
}
