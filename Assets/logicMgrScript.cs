using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicMgrScript : MonoBehaviour
{
    public int playerScore=0;
    public Text scoreText;
    public GameObject gameOverScene;

    //[ContextMenu("Increase Score")]
    public void addScore(int ScoreToAdd){
        playerScore = playerScore+ScoreToAdd;
        scoreText.text=playerScore.ToString();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        gameOverScene.SetActive(true);
    }
}
