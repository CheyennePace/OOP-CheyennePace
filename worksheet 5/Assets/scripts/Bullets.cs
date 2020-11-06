using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    // Start is called before the first frame update
    protected Vector2 speed = new Vector2();

    protected virtual void MoveRight(Rigidbody2D myshape)
    {
        myshape.velocity = speed;

    }

    protected virtual void MoveLeft(Rigidbody2D myshape)
    {
        myshape.velocity = -speed;
        

    }


}