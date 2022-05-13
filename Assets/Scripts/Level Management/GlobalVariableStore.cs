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

    public static bool TankOpen;
    public static bool FridgeOpen;
    public static bool OMOpen;

    public static bool TankCheck1;
    public static bool TankCheck2;
    public static bool TankCheck3;
    public static bool FridgeCheck1;
    public static bool FridgeCheck2;


    public static bool Interactdistance;
    public GameObject Player;
    public static Transform PlayerTrans;
    public static bool InteractStateChanged;
    public static Interact InteractableObject;

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

        TankOpen = false;
        FridgeOpen = false;
        OMOpen = false;

        TankCheck1 = false;
        TankCheck2 = false;
        TankCheck3 = false;
        FridgeCheck1 = false;
        FridgeCheck2 = false;


    Interactdistance = false;

        PlayerTrans = Player.transform;

    }

    void FixedUpdate()
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




        InteractStateChanged = false;

            //Debug.Log(LevelEnd);
    }
    // Update is called once per frame

}
