using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeBullet : Bullets
 {
     void Start()
     {
        Rigidbody2D largeBullet = this.gameObject.GetComponent<Rigidbody2D>();
        MoveRight(largeBullet);
    }

    protected override void MoveRight(Rigidbody2D myshape)
    {

        base.speed = new Vector2 (1f, 0f);
        base.MoveRight(myshape);
    }
}