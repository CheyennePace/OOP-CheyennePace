 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject myCirclePrefab;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 mypos = new Vector3(7.5f,7.5f,0);
       GameObject mycircle1 = Instantiate(myCirclePrefab, mypos, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
