using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    static GameManager Instance;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            //Doesn't destroy when new scene is loaded
            GameObject.DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }
    
}
