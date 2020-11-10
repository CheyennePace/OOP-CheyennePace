using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    private Vector3 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos = new Vector3(mousePos.x, mousePos.y, 0);
        Debug.Log(mousePos);
        Quaternion newrotation = Quaternion.LookRotation(this.transform.position - mousePos, Vector3.forward);
        newrotation.x = 0f;
        newrotation.y = 0f;
        //this.transform.rotation = newrotation;
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, newrotation, Time.deltaTime *4);
    }
}
