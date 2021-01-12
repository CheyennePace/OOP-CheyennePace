using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour
{
    void start(){
        StartCoroutine(Fire());
    }

    void Update() {
         {
        if (Input.GetButtonDown("Fire1"))
        {
            PlayerBullet = StartCoroutine(Fire.Fire1(PlayerBullet, 0.1f));
        }
        if (Input.GetButtonUp("Fire1"))
        {
            StopCoroutine(PlayerBullet);
        }

    }
    }
    
    IEnumerator Fire(GameObject PlayerBullet, float _waitTime)
    {
        while (true)
        {
            Instantiate(PlayerBullet, this.gameObject.transform.GetChild(0).position, Quaternion.identity);
            yield return new WaitForSeconds(_waitTime); //yield keyword causes a delay before returning
        }
    }
}
