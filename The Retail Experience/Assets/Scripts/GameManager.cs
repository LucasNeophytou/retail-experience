using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;


public enum GameState {

    menu,
    inGame,
    gameOver,
    nextLevel
}

public class GameManager : MonoBehaviour
{
    
    public GameState currentGameState = GameState.menu;
    public static GameManager instance;
    public Canvas menuCanvas;
    public Canvas inGameCanvas;
    public Canvas gameOverCanvas;
    public Canvas nextLevelCanvas;

    public int value = 0;
    public TMP_Text intText;
    public int buildIndex;



    void Awake () {

        instance = this;
    }

    void Start () {

        if (buildIndex == 0) {

            BackToMenu();
        }
        else if (buildIndex >= 1) {

            StartGame();
        }
    }

    public void StartGame () {

        SetGameState(GameState.inGame);
    }

    public void BackToMenu () {

        SetGameState(GameState.menu);
    }

    

    public void SetGameState (GameState newGameState) {

        if (newGameState == GameState.menu) {

            menuCanvas.enabled = true;
            inGameCanvas.enabled = false;
            gameOverCanvas.enabled = false;
            nextLevelCanvas.enabled = false;
        }
        else if (newGameState == GameState.inGame) {

            menuCanvas.enabled = false;
            inGameCanvas.enabled = true;
            gameOverCanvas.enabled = false;
            nextLevelCanvas.enabled = false;
        }
        else if (newGameState == GameState.gameOver) {

            menuCanvas.enabled = false;
            inGameCanvas.enabled = false;
            gameOverCanvas.enabled = true;
            nextLevelCanvas.enabled = false;
        }
        else if (newGameState == GameState.nextLevel) {

            menuCanvas.enabled = false;
            inGameCanvas.enabled = false;
            gameOverCanvas.enabled = false;
            nextLevelCanvas.enabled = true;
        }

        currentGameState = newGameState;
    }

    


}
