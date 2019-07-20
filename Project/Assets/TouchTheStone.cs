using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTheStone : MonoBehaviour
{
    [SerializeField] private GameObject crystal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Flatboy" || collision.gameObject.name == "Cutegirl") {
            crystal.GetComponent<Animator>().SetBool("isTriggered", true);
        }
    }
}
