using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level0Script : MonoBehaviour
{
    [SerializeField] private GameObject flatBoy;
    [SerializeField] private GameObject cuteGirl;
    // [SerializeField] private GameObject GameOver;
    public bool flatBoyFinished = false;
    public bool cuteGirlFinished = false;
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
            // GameOver.SetActive(true);
            flatBoyFinished = false;
        } else {
            flatBoyFinished = flatBoy.GetComponent<FinishScript>().finished;
        }

        if (!GameObject.Find("Cutegirl")) {
            // flatBoy.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            GameObject.Destroy(flatBoy);
            // GameOver.SetActive(true);
            cuteGirlFinished = false;
        } else {
            cuteGirlFinished = cuteGirl.GetComponent<FinishScript>().finished;
        }

        if (flatBoyFinished && cuteGirlFinished)
            NextLevel();
    }

    public void NextLevel() {
        SceneManager.LoadScene("Scene1");
    }

    public void Replay() {
        SceneManager.LoadScene("Scene0");
    }

    public void MainMenu() {
        SceneManager.LoadScene("MainMenu");
    }
}
