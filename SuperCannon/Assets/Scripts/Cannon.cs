using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    private GameObject mysmallbulletprefab, mylargebulletprefab;
   

   
    // Start is called before the first frame update
    void Start()
    {
        mysmallbulletprefab = Resources.Load("prefabs/SmallBullet") as GameObject;
        mylargebulletprefab = Resources.Load("prefabs/LargeBullet") as GameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mousePos = new Vector3(mousePos.x, mousePos.y, 0);
        //Debug.Log(mousePos);
        
        Quaternion newrotation = Quaternion.LookRotation(this.transform.position - GameData.MouseTarget, Vector3.forward);
        newrotation.x = 0f;
        newrotation.y = 0f;
        //this.transform.rotation = newrotation;  //no slurp
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, newrotation, Time.deltaTime *4);

        
        if (Input.GetButtonDown("Fire1"))
        {
          
            Instantiate(mysmallbulletprefab, this.gameObject.transform.GetChild(0).position, Quaternion.identity);
        }

        if (Input.GetButtonDown("Fire2"))
        {

            Instantiate(mylargebulletprefab, this.gameObject.transform.GetChild(0).position, Quaternion.identity);
        }


    }
}
