using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCannon : MonoBehaviour
{
    private GameObject mysmallbulletprefab;
    private Coroutine smallBulletCoroutine;

    

    CannonFire mycannonfire;


    // Start is called before the first frame update
    void Start()
    {
        mysmallbulletprefab = Resources.Load("prefabs/SmallBullet") as GameObject;
        mycannonfire = GetComponent<CannonFire>();
    }

    // Update is called once per frame
    void Update()
    {


        Quaternion newrotation = Quaternion.LookRotation(this.transform.position - GameData.MouseTarget, Vector3.forward);
        newrotation.x = 0f;
        newrotation.y = 0f;
        //this.transform.rotation = newrotation;  //no slurp
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, newrotation, Time.deltaTime * 4);

        if (Input.GetButtonDown("Fire1"))
        {
            smallBulletCoroutine = StartCoroutine(mycannonfire.Fire(mysmallbulletprefab, 0.1f));
        }
        if (Input.GetButtonUp("Fire1"))
        {
            StopCoroutine(smallBulletCoroutine);
        }
    }
}
