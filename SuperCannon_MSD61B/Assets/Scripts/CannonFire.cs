using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFire : MonoBehaviour
{
  


     public IEnumerator Fire(GameObject _myBulletPrefab, float _waitTime)
    {
        while (true)
        {
            Instantiate(_myBulletPrefab, this.gameObject.transform.GetChild(0).position, Quaternion.identity);
            yield return new WaitForSeconds(_waitTime); //yield keyword causes a delay before returning
        }
    }
}

