using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienOrange : Alien
{
    // Start is called before the first frame update
    protected override void Start()
    {
        scoreToAdd = 10;
        firespeed = 600;
        enemyFirePrefab = Resources.Load("Prefabs/OrangeFire") as GameObject;
    }


}
