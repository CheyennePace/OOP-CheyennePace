using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKill : MonoBehaviour, ITakeDamage
{
    // Start is called before the first frame update
    public int health { get; set; }
  
    public void TakeDamage(int damage)
    {
        
        GameData.Score+=5;
        GameManager._instance.ScoreDisplay();
        Destroy(this.gameObject);


    }
}
