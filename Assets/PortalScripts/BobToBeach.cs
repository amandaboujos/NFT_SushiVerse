using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BobToBeach : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider gameObjectInformation)
    {
        if (gameObjectInformation.gameObject.tag == "Player")
        {
            Debug.Log("Collision Detected");
            SceneManager.LoadScene("Island");
        }

        //Debug.Log(gameObjectInformation.gameObject.name); 


    }

}