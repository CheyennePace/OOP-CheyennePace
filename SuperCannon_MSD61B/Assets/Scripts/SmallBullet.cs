using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBullet : Bullet
{
    // Start is called before the first frame update
    protected override void Start()
    {
        speed = 10;
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
       // DestroyOutScreen();
        Color myColor = GetComponent<SpriteRenderer>().color;
        GetComponent<SpriteRenderer>().color = new Color(myColor.r, myColor.g, myColor.b, myColor.a - 0.005f);
        if (myColor.a <= 0 )
        {
            Destroy(this.gameObject);
        }
    }
}
