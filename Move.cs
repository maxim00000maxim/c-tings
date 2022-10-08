using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector3 rightdirection = new Vector3(0.02f,0f,0f);
    private Vector3 leftdirection = new Vector3(-0.02f, 0f, 0f);
    private Vector3 forwarddirection = new Vector3(0f, 0f, 0.02f);
    private Vector3 backdirection = new Vector3(0f, 0f, -0.02f);
    private Vector3 updirection = new Vector3(0f, 0.02f, 0f);
    private Vector3 downdirection = new Vector3(0f, -0.02f, 0f);
    
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        if (Input.GetKey("d")){
            transform.Translate(rightdirection);
        }

        if (Input.GetKey("a"))
        {
            transform.Translate(leftdirection);
        }

        if (Input.GetKey("w"))
        {
            transform.Translate(forwarddirection);
        }

        if (Input.GetKey("s"))
        {
            transform.Translate(backdirection);
        }

        if (Input.GetKey("space"))
        {
            transform.Translate(updirection);
        }

        if (Input.GetKey("e"))
        {
            transform.Translate(downdirection);
        }

        

    }
}
