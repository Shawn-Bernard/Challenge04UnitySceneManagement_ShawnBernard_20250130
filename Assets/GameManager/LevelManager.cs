using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    private string spawnPointName;

    bool readyToleave;
    void Start()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void LoadSceneWithSpawnPoint(string sceneName, string triggerSpawnPoint)
    {
        if (readyToleave)
        {
            spawnPointName = triggerSpawnPoint;
            readyToleave = false;
            
            StartCoroutine(WaitToLeave());
            //Throwing in my trigger string into my spawn point name
            
            
        }

        //Loading in my scene name with the string from the trigger
        SceneManager.LoadScene(sceneName);


        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private IEnumerator WaitToLeave()
    {
        yield return new WaitForSeconds(15.0f);
        readyToleave = true;
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //after loading in scene throwing in my spawnPointName
        SetPlayerSpawnPoint(spawnPointName);

        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    

    private void SetPlayerSpawnPoint(string spawnPointName)
    {
        //Finding my player object
        GameObject player = GameObject.Find("Player");

        GameObject spawnPoint = GameObject.Find(spawnPointName);

        player.transform.position = spawnPoint.transform.position;

        SceneManager.sceneLoaded -= OnSceneLoaded;

        

    }
}
