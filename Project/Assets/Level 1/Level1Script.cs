using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Script : MonoBehaviour
{
    [SerializeField] private GameObject flatBoy;
    [SerializeField] private GameObject cuteGirl;
    [SerializeField] private GameObject GameOver;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!GameObject.Find("Flatboy")) {
            // cuteGirl.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            GameObject.Destroy(cuteGirl);
            GameOver.SetActive(true);
        }

        if (!GameObject.Find("Cutegirl")) {
            // flatBoy.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            GameObject.Destroy(flatBoy);
            GameOver.SetActive(true);
        }
    }

    public void Replay() {
        SceneManager.LoadScene("Scene1");
    }
}
