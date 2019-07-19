using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpTouchStone : MonoBehaviour
{
    [SerializeField] private GameObject text;
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
        if (collision.gameObject.name == "Flatboy" || collision.gameObject.name == "Cutegirl") {
            text.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Flatboy" || collision.gameObject.name == "Cutegirl") {
            text.SetActive(false);
        }
    }
}
