using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour
{
    // Types of ressources
    public UIManager Food;
    //public UIManager Metal;
    //public UIManager Gas;

    void OnCollisionEnter2D(Collision2D collision)
    {
        //if (Food.GetQuantity)
        Food.emptyAll();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
