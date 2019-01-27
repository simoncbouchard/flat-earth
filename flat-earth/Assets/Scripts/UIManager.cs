using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text DisplayNumber;
    //public ressources Item;
    private int Quantity;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void emptyAll()
    {
        Quantity = 0;
        DisplayNumber.text = "" + Quantity;
    }

    public void addOne()
    {
        Quantity += 1;
        DisplayNumber.text = "" + Quantity;
    }

    public int GetQuantity()
    {
        return Quantity;
    }
}
