using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circle : MonoBehaviour {

    public float scaleSpeed = 0.05f;
    Vector3 temp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {

        temp = transform.localScale;

        temp.x -= scaleSpeed;
        temp.y -= scaleSpeed;

        if (temp.x > 1) {
            transform.localScale = temp;
        }
        
    }

/* 
    void OnTriggerEnter2D(Collider2D collision) {
        
        if (collision.gameObject.name == "rob_carbone") {
            Debug.Log("That's what she said");
        }
        
        
        //if (collision.gameObject.name == "hero") {
            //Destroy(this.gameObject);
        //}
    }
    */
}
