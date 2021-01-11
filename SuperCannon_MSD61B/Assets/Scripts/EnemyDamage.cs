using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour, ITakeDamage
{
    // Start is called before the first frame update
    public int health {get; set;}
    
    public void TakeDamage(int damage)
    {
        health = health - damage;
        GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color + new Color(0.2f, 0f, 0f, -0.2f);
        GameData.Score++;
        GameManager._instance.ScoreDisplay();
        if (health <= 0) Destroy(this.gameObject);


    }
}
