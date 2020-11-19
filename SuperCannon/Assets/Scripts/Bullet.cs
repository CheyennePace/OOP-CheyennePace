using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    private Vector3 mousePos;
    protected float speed = 0f;
    private Vector2 direction;

    

    // Start is called before the first frame update
    protected virtual void Start()
    {
        mousePos = GameData.MouseTarget;
      
        direction = new Vector2(mousePos.x, mousePos.y + 8f);
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = direction * speed;



    }

    protected virtual void DestroyOutScreen()
    {
        if (this.gameObject.transform.position.x > GameData.XMax) Destroy(this.gameObject);
        if (this.gameObject.transform.position.x < GameData.XMin) Destroy(this.gameObject);
        if (this.gameObject.transform.position.y > GameData.YMax) Destroy(this.gameObject);
        if (this.gameObject.transform.position.y < GameData.YMin) Destroy(this.gameObject);
    }

   
}
