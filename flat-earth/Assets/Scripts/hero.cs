using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed = 10f;
    private Animator anim;
    private bool robMoving;
    private Vector2 lastMove;


    void Start () {

        rb = GetComponent<Rigidbody2D> ();

        anim = GetComponent<Animator> ();
    }


    void Update () {
        
        robMoving = false;
        
        // UpArrow
        if (Input.GetKey(KeyCode.UpArrow)) {
            rb.velocity = new Vector2(0.0f, speed);
            robMoving = true;
            lastMove = new Vector2 (0f, Input.GetAxisRaw("Vertical"));
        }

        if (Input.GetKeyUp(KeyCode.UpArrow)) {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }

        // DownArrow
        if (Input.GetKey(KeyCode.DownArrow)) {
            rb.velocity = new Vector2(0.0f, -speed);
            robMoving = true;
            lastMove = new Vector2 (0f, Input.GetAxisRaw("Vertical"));
        }

        if (Input.GetKeyUp(KeyCode.DownArrow)) {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }


        // RightArrow
        if (Input.GetKey(KeyCode.RightArrow)) {
            rb.velocity = new Vector2(speed, 0.0f);
            robMoving = true;
            lastMove = new Vector2 (Input.GetAxisRaw("Horizontal"), 0f);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow)) {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }

        // LeftArrow
        if (Input.GetKey(KeyCode.LeftArrow)) {
            rb.velocity = new Vector2(-speed, 0.0f);
            robMoving = true;
            lastMove = new Vector2 (Input.GetAxisRaw("Horizontal"), 0f);
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow)) {
            rb.velocity = new Vector2(0.0f, 0.0f);
        }

        anim.SetFloat("moveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("moveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("rob_move", robMoving);
        anim.SetFloat("last_moveX", lastMove.x);
        anim.SetFloat("last_moveY", lastMove.y);

    }
}