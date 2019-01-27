using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ressources : MonoBehaviour {
    public UIManager ResourceUI;

    void OnCollisionEnter2D(Collision2D collision) {
        //if (collision.gameObject.name == "hero") {
            Destroy(this.gameObject);
        //}
    }

    private void OnDestroy()
    {
        this.collectResource();
    }

    private void collectResource()
    {
        ResourceUI.addOne();
    }
}
