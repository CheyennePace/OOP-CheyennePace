using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((this.gameObject.transform.position.y < GameData.YMin)
            || (this.gameObject.transform.position.y > GameData.YMax))
            Destroy(this.gameObject);
    }

  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name.Contains("piece"))
        {
            
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
