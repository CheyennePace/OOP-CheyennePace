using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBullet : Bullets
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D smallBullet = this.gameObject.GetComponent<Rigidbody2D>();
        MoveLeft(smallBullet);
 
    }

    // Update is called once per frame
    protected override void MoveLeft(Rigidbody2D myshape)
    {
        base.speed = new Vector2(1f, 0f);
        base.MoveLeft(myshape);
    }
}