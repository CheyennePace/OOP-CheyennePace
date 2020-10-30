using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numScript : MonoBehaviour
{
    int num = 10;
    int max = 50;
    int min = 5;
    // Start is called before the first frame update
    void Start()
    {
        print("testing");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("up")) {
            print(num++);
            
        }
        if(Input.GetKeyDown("down")) {
            print( num--);
            
        }
        if(Input.GetKey("right")) {
            print(num = num+10);
            
        }
        if(Input.GetKey("left")) {
            print(num = num-10);
            
        }
        if(num >= max) {
            print ("number reached max");
            UnityEditor.EditorApplication.isPlaying = false ;
        }
        if(num >= min) {
            print ("number reached min");
            UnityEditor.EditorApplication.isPlaying = false ;
        }
    }
}
