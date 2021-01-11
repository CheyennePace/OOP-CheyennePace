using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedCannon : MonoBehaviour
{

    private GameObject mylargebulletprefab;
    private Coroutine largeBulletCoroutine;




    CannonFire mycannonfire;
    // Start is called before the first frame update
    void Start()
    {
        mylargebulletprefab = Resources.Load("prefabs/LargeBullet") as GameObject;
        mycannonfire = GetComponent<CannonFire>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            largeBulletCoroutine = StartCoroutine(mycannonfire.Fire(mylargebulletprefab, 0.1f));
        }
        if (Input.GetButtonUp("Fire2"))
        {
            StopCoroutine(largeBulletCoroutine);
        }

    }
}
