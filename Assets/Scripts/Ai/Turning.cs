using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turning : MonoBehaviour
{
    float modifier;
    //public GameObject Worker;
    bool left = true;
   // bool first = false;

    float startDirection;
    //float starttime = Random.Range(5.0f, 10.0f);

    // Start is called before the first frame update
    void Start()
    {

        startDirection = transform.eulerAngles.y;


    }

    /*
    // Update is called once per frame
    void Update()
    {
        modifier = Random.Range(5.0f, 10.0f);

        Nexttime = Time.time + modifier;


        if (Time.time > Nexttime)
        {


            if (left)
            {
                this.transform.Rotate(0.0f, 30.0f, 0.0f);
                left = false;
            }
            else
            {
                this.transform.Rotate(0.0f, -30.0f, 0.0f);
                left = true;
            }

        }

    }
    */


    void FixedUpdate()
    {

     //  if (Time.time == starttime)
     //   {
     //       first = true;

    //    }


        Vector3 newRotation;

     // if (first) { 


        if (left)
        {

            newRotation = new Vector3(0.0f, 1.0f, 0.0f);

        }
        else
        {

            newRotation = new Vector3(0.0f, -1.0f, 0.0f);

        }

        this.transform.Rotate(newRotation);

        if (transform.eulerAngles.y > startDirection + 40)
        {

            left = false;

        }

        if (startDirection - 40 > 0)
        {

            if (transform.eulerAngles.y < startDirection - 40)
            {

                left = true;

            }

        }
        else
        {


            //Issue with this setup is that if the starting value minus or plus 40 is under 0 or over 365 it causes bugs
            //the reason for this is if the object is transformed pass either values they loop back to the other side causing unintended behavior
            //This code exists to deal with that when it happens, its a bad fix but works for the time being
            //ideally we would prevent this from happening in the first place
            if (transform.eulerAngles.y > 355)
            {


                left = true;

            }

        }


     // }
    }

}
