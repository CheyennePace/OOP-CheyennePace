using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExplosion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(Explode());
    }

    // Update is called once per frame
    IEnumerator Explode()
    {
        yield return new WaitForSeconds (3f);
        //destroy
        Destroy(this.gameObject);
    }
}
