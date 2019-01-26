using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{

    private Rigidbody2D rb;


    void Start () {

        Debug.Log("test");

        rb = GetComponent<Rigidbody2D> ();
    }


    void Update () {
        
        if (Input.GetKey(KeyCode.UpArrow)) {
            rb.velocity = new Vector2(0.4f, 0.0f);
        }

        if (Input.GetKeyUp(KeyCode.UpArrow)) {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            rb.velocity = new Vector2(-0.4f, 0.0f);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow)) {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }
    }
}
