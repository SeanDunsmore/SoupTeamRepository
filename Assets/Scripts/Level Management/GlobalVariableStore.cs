using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GlobalVariableStore : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool LevelEnd1;
    public static bool LevelEnd2;

    public static bool TankSet1;
    public static bool TankSet2;
    public static bool TankSet3;

    public GameObject LevelExit;
    public Light LevelExitLight;

    public Material Material1;
    public GameObject LowFridge;
    public GameObject HighFridge;

    void Start()
    {
        LevelEnd1 = false;
        LevelEnd2 = false;

        TankSet1 = false;
        TankSet2 = false;
        TankSet3 = false;


    }

    void Update()
    {

        if (LevelEnd1)
        {

            HighFridge.GetComponent<MeshRenderer>().material = Material1;

            if (LevelEnd2)
            {

                LevelExit.GetComponent<MeshRenderer>().material = Material1;
                LevelExitLight.color = Color.green;

            }


        }

        if (LevelEnd2)
        {
            LowFridge.GetComponent<MeshRenderer>().material = Material1;
        }


            //Debug.Log(LevelEnd);
    }
    // Update is called once per frame

}
