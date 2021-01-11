using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private GameObject myenemy1prefab, myenemy2prefab;

    private int enemychoice;

    [SerializeField] List<GameObject> enemiesList;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnEnemies()
    {
        int enemycount = 0;
        while (true)
        {
            enemychoice = Random.Range(0, 2);
            Vector3 myenemypos = new Vector3(Random.Range(GameData.XMin, GameData.XMax), GameData.YMax, 0f);
            Instantiate(enemiesList[enemychoice], myenemypos, Quaternion.identity);
            enemycount++;
            yield return new WaitForSeconds(0.5f);
        }
        
    }
}
