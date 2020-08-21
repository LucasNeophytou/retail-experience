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

    public bool isHandOpen;
    public int value = 0;
    public TMP_Text intText;
    public TMP_Text handModeText;
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

    void Update () {

        intText.text = value.ToString();

        if (!Input.GetKey("mouse 0")) {

            if (Input.GetKeyDown("mouse 1")) {

                isHandOpen = !isHandOpen;
            }
        }

        if (isHandOpen == true) {

            handModeText.text = "Open Hand";
        }
        else if (isHandOpen == false) {

            handModeText.text = "Closed Hand";
        }
        
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

    public void AddValue () {

        if (isHandOpen == false) {

            value ++;
        }
        
    }


}
