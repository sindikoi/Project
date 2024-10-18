using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public float timeLimit = 30f; 
    private float timer;
    private string finalScene = "ExitScene";

    void Start()
    {
        Debug.Log("Time's Start!");
        timer = timeLimit;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        { Debug.Log("Time's up!");
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene(finalScene);

        Application.Quit();

    }



}
