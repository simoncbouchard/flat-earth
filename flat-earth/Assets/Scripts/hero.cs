using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed = 0.4f;


    void Start () {

        Debug.Log("test");

        rb = GetComponent<Rigidbody2D> ();
    }


    void Update () {
        
        // UpArrow
        if (Input.GetKey(KeyCode.UpArrow)) {
            rb.velocity = new Vector2(0.0f, speed);
        }

        if (Input.GetKeyUp(KeyCode.UpArrow)) {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }

        // DownArrow
        if (Input.GetKey(KeyCode.DownArrow)) {
            rb.velocity = new Vector2(0.0f, -speed);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow)) {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }


        // RightArrow
        if (Input.GetKey(KeyCode.RightArrow)) {
            rb.velocity = new Vector2(speed, 0.0f);
        }

        if (Input.GetKeyUp(KeyCode.UpArrow)) {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }

        // LeftArrow
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.velocity = new Vector2(-speed, 0.0f);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow)) {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }


    }
}
