using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AliensManagement : MonoBehaviour
{
    public int direction = 1;

    private float speed = 0.2f;
    private int startEnemyCount;
    private GameObject enemyPrefab1;


    public void SpawnAliens()
    {
        GameData.CurrentNumberOfEnemies = 0;
        enemyPrefab1 = Resources.Load("Prefabs/OrangeAlien") as GameObject;
        SpawnAlienLine(enemyPrefab1, GameData.YMax - 2, 9);
     
        startEnemyCount = GameData.CurrentNumberOfEnemies;
        StartCoroutine(MoveEnemies(this.gameObject));   
    }

    void SpawnAlienLine(GameObject _myenemyprefab, float _y_offset, int _maximumNumberOfEnemies)

    {
        Vector3 spawnPoint = new Vector3(GameData.XMin + 2, _y_offset, 0f);
        int enemiesLineCount = 0;
        GameObject myenemy;
        while (enemiesLineCount < _maximumNumberOfEnemies)
        {
            myenemy = GameObject.Instantiate(_myenemyprefab, spawnPoint, Quaternion.identity);
            myenemy.transform.SetParent(this.transform);
            spawnPoint = spawnPoint + new Vector3(2f, 0f, 0f);
            enemiesLineCount++;
            GameData.CurrentNumberOfEnemies++;
        }
    }


    public IEnumerator MoveEnemies(GameObject objectToMove)
    {

        while (true)
        {
            objectToMove.transform.position = objectToMove.transform.position + new Vector3(direction, 0f, 0f);
            yield return new WaitForSeconds(speed);
        }

    }


    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Start Enemy Count: " + startEnemyCount);
        Debug.Log("Enemy Count: " + GameData.CurrentNumberOfEnemies);
        Debug.Log("Speed: " + speed);

        float movedown_value = -0.5f;

        if ((other.gameObject.name=="RightCollider") && (direction==1))
        {
         
            this.gameObject.transform.position = this.gameObject.transform.position + new Vector3(0f, movedown_value, 0f); 
            speed = (startEnemyCount * GameData.CurrentNumberOfEnemies) / startEnemyCount * 0.02f;
            direction = -1;
        }
        if (other.gameObject.name == "LeftCollider" && (direction == -1))
        {
            
            this.gameObject.transform.position = this.gameObject.transform.position + new Vector3(0f, movedown_value, 0f);
            speed = (startEnemyCount * GameData.CurrentNumberOfEnemies) / startEnemyCount * 0.02f;
            direction = 1;
        }
    }
}
