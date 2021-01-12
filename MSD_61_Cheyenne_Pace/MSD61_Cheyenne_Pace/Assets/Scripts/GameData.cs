using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameData : MonoBehaviour
{

    private static int _currentnumberofenemies;
    private static int _score;
    public static int Score
    {
        set{_score = value;}
        get {return _score;}
    }
    private static int _lives;
    public static int Lives
    {
        set{_lives = value;}
        get{return _lives;}
    }
    
    


    public static int CurrentNumberOfEnemies
    {
        get { return _currentnumberofenemies; }
        set { _currentnumberofenemies = value; }
    }



    public static float XMin
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x; }
    }


    public static float XMax
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x; }
    }

    public static float YMin
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y; }
    }

    public static float YMax
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y; }
    }




}
