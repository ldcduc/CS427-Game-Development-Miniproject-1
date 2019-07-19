using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWithPlayers : MonoBehaviour
{
    [SerializeField] private GameObject flatBoy;
    [SerializeField] private GameObject cuteGirl;
    public float maxDistance = 18.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Flatboy") && GameObject.Find("Cutegirl")) {
            bool flag = !(Mathf.Abs(flatBoy.transform.position.x - cuteGirl.transform.position.x) > maxDistance);
            if (Mathf.Abs(flatBoy.transform.position.x - cuteGirl.transform.position.x) > maxDistance) {
            } else {
                float y = gameObject.transform.position.y;
                float z = gameObject.transform.position.z;
                gameObject.transform.position = new Vector3((flatBoy.transform.position.x + cuteGirl.transform.position.x)/2, y, z);
            } 
        }
    }
}
