using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
 
    public static GameManager _instance;
    private AliensManagement alienManager;
    Text scoreText, livesText;

    // Start is called before the first frame update

    void Awake()
    {
        //Check if instance already exists
        if (_instance == null)
            //if not, set instance to this
            _instance = this;
        //If instance already exists and it's not this:
        else if (_instance != this)
            //Then destroy this. This enforces our singleton pattern,
            //meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);
        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

       
    }


    private void Start()
    {
        alienManager = GetComponent<AliensManagement>();
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        livesText = GameObject.Find("LivesText").GetComponent<Text>();
        GameData.Score = 0;
        GameData.Lives = 3;
        DisplayScore();
        DisplayLives();
        alienManager.SpawnAliens();
    }

 

    public void AddScoreAndDisplay(int scoreToAdd)
    {
        GameData.Score += scoreToAdd;
        DisplayScore();
        if (GameData.CurrentNumberOfEnemies <= 0) LoadScene("WinScene");
    }


    public void DisplayScore()
    {
        scoreText.text = GameData.Score.ToString();
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void DropLifeAndDisplay()
    {
        GameData.Lives--;
        DisplayLives();       
    }

    public void DisplayLives()
    {
        livesText.text = GameData.Lives.ToString();
    }


    public void QuitGame()
    {
#if UNITY_EDITOR
        //Stop playing the scene
        UnityEditor.EditorApplication.isPlaying = false;
#else
           Application.Quit();
#endif

    }


}
