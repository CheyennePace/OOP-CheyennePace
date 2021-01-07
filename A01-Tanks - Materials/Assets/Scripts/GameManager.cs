using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

      
   

    [SerializeField] Text playerScoreText;

    [SerializeField] GameObject playerPrefab;

    
    void Start () {
        GameData.GameScore = 0;
        playerScoreText.text = "Score: " + GameData.GameScore.ToString();
	}

    public void OnEnemyDie()
    {
      
        GameData.GameScore++;
        playerScoreText.text = "Score: " + GameData.GameScore.ToString();
        
    }

    public void OnFixedEnemyDie()
    {

        SceneManager.LoadScene("Win");

    }

    public void OnPlayerDie()
    {
        
        SceneManager.LoadScene("GameOver");
    }
 
    
}
