using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizardScript : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
    
        print("is the number higher or lower than " + guess+ "?");

        //outputs in unity concole
        print("Welcome to Number Wizard");
        Debug.Log("Pick a number in your head but don't tell me!");


        print("The max num is" + max);
        print("The min num is" + min);

        print("is the number higher or lower than 500? ");
        print("UP Arrow: higher, DOWN Arrow: lower, RETURN: equal");
    }

    // Update is called once per frame
    void Update()
    {
        // Input - expecting an input from the user
        // GetKeyDown - something happens when the key reaches down
        // (“up”) - the name of the key I want to press.
        //if User presses the Up Arrows, the lines in the brackets happen 
        if(Input.GetKeyDown("up")) {
            print("Up Arrow pressed");
            min = guess;
            guess = (max + min) / 2;
            print("higher or lower than " + guess);
        }
        if(Input.GetKeyDown("down")) {
            print("Down Arrow pressed");
            max = guess;
            guess = (max - min) /2;
            print("higher or lower than " + guess);
        }
        else if(Input.GetKeyDown("return")) {
            print("I won");
        }
    }
}
