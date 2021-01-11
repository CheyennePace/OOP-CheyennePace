using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public interface ITakeDamage
{
    int health { get; set; }
    void TakeDamage(int damage);
}





public class GameManager : MonoBehaviour
{
    
    // Start is called before the first frame update

    public static GameManager _instance;

   



    //Singleton pattern.. assign current instance first time and destroy any further instances upon spawn.
    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance != this)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }



    void Start()
    {
        GameData.Score = 0;
        ScoreDisplay();
        
        

        SetupBoundaries();
    }

    // Update is called once per frame
    void Update()
    {

   
    }

    private void SetupBoundaries()
    {
        GameObject.Find("LeftBoundary").transform.position = new Vector3(GameData.XMin - 1.25f, 0, 0);
        GameObject.Find("RightBoundary").transform.position = new Vector3(GameData.XMax + 1.25f, 0, 0);
        GameObject.Find("BottomBoundary").transform.position = new Vector3(0, GameData.YMin - 1, 0);
        GameObject.Find("TopBoundary").transform.position = new Vector3(0, GameData.YMax + 1.5f, 0);
    }


    public void ScoreDisplay()
    {
        Text textobject = GameObject.Find("ScoreText").GetComponent<Text>();  //can be done in start method
        textobject.text = GameData.Score.ToString();
        if (GameData.Score >= 100) ChangeScene("GameOver");
    }


    public void ChangeScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void QuitGame()
    {

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
         Application.OpenURL(webplayerQuitURL);
#else
         Application.Quit();
#endif


    }


}
