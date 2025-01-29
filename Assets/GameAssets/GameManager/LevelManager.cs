using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene(1);

        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            SceneManager.LoadScene(1);
        }
        else if (Input.GetKey(KeyCode.Alpha2))
        {
            SceneManager.LoadScene(0);
        }
    }
    void Menu()
    {
        //The Menu index
        SceneManager.LoadScene(0);

        //Loading the Menu by string
        SceneManager.LoadScene("MainMenu");
    }
    void Level()
    {
        //The level index
        SceneManager.LoadScene(1);

        //Loading the level by string
        SceneManager.LoadScene("GamePlay");
    }
    void LoadNewLevel(int level)
    {

    }
    void OnSceneLoaded()
    {

    }
}
