using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private GameObject flatBoy;
    [SerializeField] private GameObject cuteGirl;

    // Update is called once per frame
    void Update()
    {
        int score1 = flatBoy.GetComponent<FlatboyMovement>().score;
        int score2 = cuteGirl.GetComponent<CutegirlMovement>().score;
        Debug.Log("score1 " + score1);
        Debug.Log("score2 " + score2);
        GetComponent<TMPro.TextMeshProUGUI>().text = (score1 + score2).ToString();
    }
}
