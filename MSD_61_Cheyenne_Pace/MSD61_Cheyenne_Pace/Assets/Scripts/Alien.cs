using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{

    protected int scoreToAdd = 0;
    protected GameObject enemyFirePrefab, enemyfire;
    public int firespeed = 400;
    GameManager myGameManager;
    int firetime;

    private void Awake()
    {
        myGameManager = FindObjectOfType<GameManager>();
    }
    protected virtual void Start()
    {
        enemyFirePrefab = Resources.Load("Prefabs/RedFire") as GameObject;
    }



    void FixedUpdate()
    {
        firetime = Random.Range(0, firespeed);
        if (firetime == 0) enemyfire = Instantiate(enemyFirePrefab, this.transform.position, Quaternion.identity);
        if (this.gameObject.transform.position.y <= GameData.YMin) myGameManager.LoadScene("LoseScene");
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "PlayerBullet")
        {
            GameData.CurrentNumberOfEnemies--;
            
            if (myGameManager != null) myGameManager.AddScoreAndDisplay(scoreToAdd);
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}
