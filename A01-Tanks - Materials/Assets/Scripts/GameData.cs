using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameData : MonoBehaviour
{
    // Start is called before the first frame update
    private static int _score;
  

    public static int GameScore
    {
        get { return _score; }
        set { _score = value; }
    }



}
