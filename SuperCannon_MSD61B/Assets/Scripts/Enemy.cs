using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    

    ITakeDamage damageable;
    // Start is called before the first frame update
    void Start()
    {
        
        damageable = GetComponent<ITakeDamage>();
        damageable.health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("Bottom"))
        {
            //to code health reduce
            Destroy(this.gameObject);
        }

        if (damageable != null && other.gameObject.name.Contains("Bullet"))
        {
            //to code health reduce
            Destroy(other.gameObject);
            damageable.TakeDamage(1);
            //Debug.Log("Score: " + GameData.Score);
            
          
        }


    }


}
