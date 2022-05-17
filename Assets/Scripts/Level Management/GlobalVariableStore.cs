using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GlobalVariableStore : MonoBehaviour
{
    // Start is called before the first frame update

    public static bool IsPaused;

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

    public static bool Menu2Check;

    public static int Level;

    public static bool Interactdistance;
    public GameObject Player;
    public GameObject PauseMenu;
    public static Transform PlayerTrans;
    public static bool InteractStateChanged;
    public static Interact InteractableObject;

    public GameObject LevelExit;
    public Light LevelExitLight;

    public Material Material1;
    public GameObject LowFridge;
    public GameObject HighFridge;

    // Level 2

    public static bool SupervisorL21;
    public static bool SupervisorL22;
    public static bool SupervisorL23;
    public static bool SupervisorL24;

    public static bool SupervisorCheckL21;
    public static bool SupervisorCheckL22;
    public static bool SupervisorCheckL23;
    public static bool SupervisorCheckL24;


    // level 3

    public static bool Forklift1;
    public static bool Forklift2;
    public static bool Generator1;
    public static bool Generator2;

    public static bool ForkliftCheck1;
    public static bool ForkliftCheck2;
    public static bool GeneratorCheck1;
    public static bool GeneratorCheck2;

    public static bool SupervisorL31;
    public static bool SupervisorL32;
    public static bool SupervisorL33;
    public static bool SupervisorL34;

    public static bool SupervisorCheckL31;
    public static bool SupervisorCheckL32;
    public static bool SupervisorCheckL33;
    public static bool SupervisorCheckL34;

    public static bool GenOpen;
    public static bool ForkOpen;
    public static bool OML3Open;
    public static bool exitOpen;

    void Start()
    {

        IsPaused = false;
        PauseMenu.SetActive(false);

        LevelEnd1 = false;
        LevelEnd2 = false;

        TankSet1 = false;
        TankSet2 = false;
        TankSet3 = false;

        TankOpen = false;
        FridgeOpen = false;
        OMOpen = true;

        TankCheck1 = false;
        TankCheck2 = false;
        TankCheck3 = false;
        FridgeCheck1 = false;
        FridgeCheck2 = false;

        Menu2Check = false;

        Interactdistance = false;

        //Level 2
        SupervisorL21 = false;
        SupervisorL22 = false;
        SupervisorL23 = false;
        SupervisorL24 = false;

        SupervisorCheckL21 = false;
        SupervisorCheckL22 = false;
        SupervisorCheckL23 = false;
        SupervisorCheckL24 = false;

        // Level 3


        Forklift1 = false;
        Forklift2 = false;
        Generator1 = false;
        Generator2 = false;

        ForkliftCheck1 = false;
        ForkliftCheck2 = false;
        GeneratorCheck1 = false;
        GeneratorCheck2 = false;

        SupervisorL31 = false;
        SupervisorL32 = false;
        SupervisorL33 = false;
        SupervisorL34 = false;

        SupervisorCheckL31 = false;
        SupervisorCheckL32 = false;
        SupervisorCheckL33 = false;
        SupervisorCheckL34 = false;

        GenOpen = false;
        ForkOpen = false;
        OML3Open = false;
        exitOpen = false;


        PlayerTrans = Player.transform;

    }

    void Update()
    {

        if(Level == 1)
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

        }

        if (Level == 2)
        {
            if (SupervisorL21 && SupervisorL22 && SupervisorL23 && SupervisorL24)
            {
                LevelExit.GetComponent<MeshRenderer>().material = Material1;
                LevelExitLight.color = Color.green;
            }

        }

        if (Level == 3)
        {

            if (SupervisorL34)
            {
                LevelExit.GetComponent<MeshRenderer>().material = Material1;
                LevelExitLight.color = Color.green;
            }


        }


        if (IsPaused)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0;

        }
        else
        {
            PauseMenu.SetActive(false);
        }


        InteractStateChanged = false;

            //Debug.Log(LevelEnd);
    }
    // Update is called once per frame

}
