using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Shape : MonoBehaviour
{
    // Start is called before the first frame update
    protected Vector2 speed = new Vector2();

    //public Shape(float _xspeed, float _yspeed)
    //{
    //    speed = new Vector2(_xspeed, _yspeed);
    // }

    protected virtual void MoveRight(Rigidbody2D myshape)
    {
        myshape.velocity = speed;

    }

    protected virtual void MoveLeft(Rigidbody2D myshape)
    {
        myshape.velocity = -speed;
        

    }


}