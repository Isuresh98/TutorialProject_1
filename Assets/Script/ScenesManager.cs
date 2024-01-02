using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScenesManager : MonoBehaviour
{
     private int currentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
         currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }


    public void LoadScence(String LevelName){

        SceneManager.LoadScene(LevelName);


    }
     public void LoadScenceIndex(int LevelNumber){

        SceneManager.LoadScene(LevelNumber);


    }

     public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
