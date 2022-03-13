using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMove : MonoBehaviour
{

    int direction = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector3 newPosition;
       

        if (direction ==0)
        {

            newPosition = new Vector3(0.01f, 0, 0.01f);

        }
        else
        {

            newPosition = new Vector3(-0.01f, 0, -0.01f);

        }

        transform.position = transform.position + newPosition;

        if (transform.position.x > 10)
        {

            direction = 1;

        }

        if (transform.position.x < -10)
        {

            direction = 0;

        }

        
    }
}
