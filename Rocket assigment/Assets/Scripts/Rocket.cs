using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

    float rotationLeftRight = 0;
    float rotationForwardBackward = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            print("space key was pressed");
            transform.Translate(0, 0.15f, 0);
        }

        // Left 
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rotationLeftRight -= 0.01f;
        }

        // Right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotationLeftRight += 0.01f;
        }

        // Left - Right back to zero
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            rotationLeftRight = 0;
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            rotationLeftRight = 0;
        }

        // Forward 
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rotationForwardBackward += 0.01f;
        }

        // Backward
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rotationForwardBackward -= 0.01f;
        }

        // Forward Backward back to zero
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            rotationForwardBackward = 0;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            rotationForwardBackward = 0;
        }


        transform.Rotate(rotationLeftRight, 0, rotationForwardBackward, Space.Self);
    }
}
