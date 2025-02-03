using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager_Test : MonoBehaviour
{
    public static gameManager_Test instance { get; private set; }

    public LevelManager levelManager;

    public PlayerMovement player;
    // Start is called before the first frame update
    void Start()
    {
        //This will make it collapsable when within the region and end region
        #region Sigleton Pattern

        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
