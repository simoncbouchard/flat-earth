using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed = 10f;
    private Animator anim;


    void Start () {

        rb = GetComponent<Rigidbody2D> ();

        anim = GetComponent<Animator> ();
    }


    void Update () {
        
        /* 
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f) {
            transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0f, 0f));
        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f) {
            transform.Translate (new Vector3(Input.GetAxisRaw("Vertical") * speed * Time.deltaTime, 0f));
        }
        */
        

        anim.SetFloat("moveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("moveY", Input.GetAxisRaw("Vertical"));


        
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

        if (Input.GetKeyUp(KeyCode.RightArrow)) {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }

        // LeftArrow
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.velocity = new Vector2(-speed, 0.0f);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow)) {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }
        

    }
}