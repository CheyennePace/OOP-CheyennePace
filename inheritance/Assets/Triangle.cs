using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D mytriangleBody = this.gameObject.GetComponent<Rigidbody2D>();
        MoveLeft(mytriangleBody);
 
    }

    // Update is called once per frame
    protected override void MoveLeft(Rigidbody2D myshape)
    {
        base.speed = new Vector2(3f, 0f);
        base.MoveLeft(myshape);
        myshape.rotation = +90;
    }
}