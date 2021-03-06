﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public string[] scenes;
    private int sceneIndex;

    private static GameController instance;

    // Use this for initialization
    void Start()
    {
        if (instance == null)
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            GameObject.Destroy(gameObject);
        }


    }

    public void NextLevel()
    {
        sceneIndex = (sceneIndex + 1) % scenes.Length;
        Debug.Log("Loading scene " + sceneIndex + ": " + scenes[sceneIndex]);
        SceneManager.LoadScene(scenes[sceneIndex]);

    }
}