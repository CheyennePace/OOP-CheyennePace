using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien_SS : MonoBehaviour
{
    // Start is called before the first frame update
    
    int firetime;
    GameObject enemyFirePrefab, enemyfire;

    private void Start()
    {
        enemyFirePrefab = Resources.Load("Prefabs/AlienFire") as GameObject;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        firetime = Random.Range(0, 500);
        if (firetime == 0) enemyfire = Instantiate(enemyFirePrefab, this.transform.position, Quaternion.identity);
    }


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerBullet")
        {
            GameData.CurrentNumberOfEnemies--;
            GameManager myGameManager = FindObjectOfType<GameManager>();
            if (myGameManager != null) myGameManager.AddScoreAndDisplay(10);
            Destroy(col.gameObject);
            Destroy(this.gameObject);
            //LifeManager.lives--;
       
        }
    }



}
