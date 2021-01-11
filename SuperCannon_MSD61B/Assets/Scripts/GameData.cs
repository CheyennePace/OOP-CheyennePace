using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameData : MonoBehaviour
{
    //Create a GETTER to contain the mouse position in world units
    
    private static Vector3 mousePos;
    private static int _score;
    public static int Score
    {
        set { _score = value; }
        get { return _score; }
    }

    public static Vector3 MouseTarget
    {
        get { return GetTarget(); }
    }
  
    private static Vector3 GetTarget()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos = new Vector3(mousePos.x, mousePos.y, 0);
      //  Debug.Log(mousePos);
        return mousePos;
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
