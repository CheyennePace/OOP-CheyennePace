using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coins : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

     void OnTriggerEnter2D(Collider2D col)
    { 
        if (col.name == "player")
            FindObjectOfType<GameScore>().AddToScore();
            Destroy(gameObject);
    }
}
