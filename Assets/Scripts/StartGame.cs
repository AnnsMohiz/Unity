using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    // Boolean variable to control the game state
    private bool IsGameStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        // Game starts when the scene is loaded
        GameStart();
    }

    // Update is called once per frame
    void Update()
    {
        // Check for input to end the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EndGame();
        }
    }

    // Method to start the game
    void GameStart()
    {
        IsGameStarted = true;
        Debug.Log("Game Started!");
    }

    // Method to end the game
    void EndGame()
    {
        IsGameStarted = false;
        Debug.Log("Game Ended!");
    }
}
