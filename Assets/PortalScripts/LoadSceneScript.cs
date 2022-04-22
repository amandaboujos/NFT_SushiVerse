using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceneScript : MonoBehaviour
{
    public string SceneName;
    public GameObject LoadingScreen;
    public Slider LoadingSlider; 

    void OnTriggerEnter(Collider gameObjectInformation)
    {
        if (gameObjectInformation.gameObject.tag == "Player")
        {
            Debug.Log("Collision Detected");
            StartCoroutine(LoadSceneAsync());
        }

        //Debug.Log(gameObjectInformation.gameObject.name); 


    }

    IEnumerator LoadSceneAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(SceneName, LoadSceneMode.Single);
        LoadingScreen.SetActive(true);
        while (!asyncLoad.isDone)
        {
            float progress = Mathf.Clamp01(asyncLoad.progress/0.9f);
            LoadingSlider.value = progress;
            yield return null;
        }
    }
}
