using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector3 mousePos;
    private float speed = 2;
    private Vector2 direction;
    
    // Start is called before the first frame update
    void Start()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       //mousePos = new Vector3(mousePos.x, mousePos.y, 0);
        Debug.Log(mousePos);

        direction = new Vector2 (mousePos.x, mousePos.y + 8f);
        direction.Normalize();

        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
}