using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    static GameManager Instance;

    GameObject Player;

    GameObject SpawnPoint;

    GameObject GameSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");

        SpawnPoint = GameObject.Find("SpawnPoint");

        GameSpawnPoint = GameObject.Find("GameSpawnPoint");

        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            //Doesn't destroy when new scene is loaded
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        Player.transform.position = SpawnPoint.transform.position;
        Player.transform.position = GameSpawnPoint.transform.position;
    }
    
}
