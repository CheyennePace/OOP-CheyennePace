using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeBullet : Bullet
{
    // Start is called before the first frame update
    protected override void Start()
    {
        direction = new Vector2(GameData.XMax, GameData.YMax);
        speed = 5;
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = direction * speed;

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
