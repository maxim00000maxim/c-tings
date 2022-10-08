using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
  
    void Start()
    {
        
    }

   
    void FixedUpdate()
    {
        if (Input.GetKey("right"))
        {
            Quaternion rotation = Quaternion.AngleAxis(1, Vector3.up);
            transform.rotation *= rotation;
        }

        if (Input.GetKey("left"))
        {
            Quaternion rotation = Quaternion.AngleAxis(1, Vector3.down);
            transform.rotation *= rotation;
        }

        if (Input.GetKey("down"))
        {
            Quaternion rotation = Quaternion.AngleAxis(1, Vector3.right);
            transform.rotation *= rotation;
        }

        if (Input.GetKey("up"))
        {
            Quaternion rotation = Quaternion.AngleAxis(1, Vector3.left);
            transform.rotation *= rotation;
        }
    }
}
