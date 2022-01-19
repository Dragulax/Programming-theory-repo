using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapes : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] protected GameObject cube;
    [SerializeField] protected GameObject sphere;
    [SerializeField] protected GameObject capsule;

    [SerializeField] private Camera gameCamera;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void MouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = gameCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

                DisplayText();
                // the object identified by hit.transform was clicked
                // do whatever you want
            }
        }
       
    }
    public virtual void DisplayText()
    {
        //Debug.Log("This is a " + cube.name + " and its color is " + cube.gameObject.GetComponent<Renderer>().material.name);
    }

}
