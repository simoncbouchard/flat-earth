using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ressources : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D collision) {
        //if (collision.gameObject.name == "hero") {
            Destroy(this.gameObject);
        //}
    }
}
