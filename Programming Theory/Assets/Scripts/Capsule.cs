using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shapes
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public override void DisplayText()
    {
        Debug.Log("This is a " + capsule.name + " and its color is " + capsule.gameObject.GetComponent<Renderer>().material.name);
    }
    void OnMouseDown()
    {
        DisplayText();
    }
}
