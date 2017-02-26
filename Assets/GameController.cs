using System.Collections;
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
            GameObject.DontDestroyOnLoad(this);
        }
        else if (instance != this)
        {
            GameObject.Destroy(this);
        }
    }

    public void NextLevel()
    {
        sceneIndex = (sceneIndex + 1) % scenes.Length;
        SceneManager.LoadScene(scenes[sceneIndex]);
    }
}