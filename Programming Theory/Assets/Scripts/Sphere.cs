using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shapes
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
        Debug.Log("This is a " + sphere.name + " and its color is " + sphere.gameObject.GetComponent<Renderer>().material.name);
    }
    void OnMouseDown()
    {
        DisplayText();
    }
}
