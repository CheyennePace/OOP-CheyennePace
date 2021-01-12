using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{


    public float speed = 10f;
    private Rigidbody2D body;

    private GameObject missilePrefab;
    private GameManager gm_instance;
    public Transform fireTransform;

    public float fireForce = 500;


    void Start()
    {
        missilePrefab = Resources.Load("Prefabs/PlayerBullet") as GameObject;
        body = GetComponent<Rigidbody2D>();

        gm_instance = GameObject.FindObjectOfType<GameManager>();
        // Retrieve reference to this GameObject's Rigidbody component
    }

    void Update()
    {
        
        
        // TODO: Execute GetMovementInput() (to be coded below)
        //       Determine amount to move based on direction and speed

        float movementInput = GetMovementInput();
        Vector2 movement = transform.up * movementInput * speed * Time.deltaTime;
        body.MovePosition(body.position + movement);

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject missile = Instantiate(missilePrefab, fireTransform.position + new Vector3(0f, 0.5f, 0f), transform.rotation);

            Rigidbody2D missileBody = missile.GetComponent<Rigidbody2D>();

            missileBody.AddForce(transform.up * fireForce);

        }


    }

    // TODO: GetMovementInput() -Returns input values of 0, 1 or -1 based on whether Player tries to move right or left
    float GetMovementInput()
    {
        KeyCode positiveKey = KeyCode.A;
        KeyCode negativeKey = KeyCode.D;

        if (Input.GetKey(positiveKey))
        {
            return -1f;
        }
        else if (Input.GetKey(negativeKey))
        {
            return 1f;
        }
        else
        {
            return 0f;
        }
    }


void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Contains("Fire"))
        {
            this.gameObject.transform.position = new Vector3(GameData.XMin + 1, this.gameObject.transform.position.y, this.gameObject.transform.position.z);

            gm_instance.DropLifeAndDisplay();

        }
    }
}
