using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Level1screenUIDoc : MonoBehaviour
{

    public GameObject UI;
    public Button Magnet1;
    public Button PauseButton;
    public IMGUIContainer Magnet2;
    public Toggle Pete;
    public Toggle Tank1;
    public Toggle Tank2;
    public Toggle Tank3;
    public Toggle Fridge1;
    public Toggle Fridge2;

    public bool isSetup = false;

    // Start is called before the first frame update
    void Start()
    {
      
        
        setUpButton();
        //Tank1.visible = false;
       // Tank2.visible = false;
       // Tank3.visible = false;
       // Fridge1.visible = false;
       // Fridge2.visible = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (isSetup == false)
        {
            setUpButton();
        }

        var root = GetComponent<UIDocument>().rootVisualElement;

        Magnet1 = root.Q<Button>("Magnify");
        Magnet2 = root.Q<IMGUIContainer>("UNMagnify");

        Pete = root.Q<Toggle>("Pete");
        Tank1 = root.Q<Toggle>("Tank1");
        Tank2 = root.Q<Toggle>("Tank2");
        Tank3 = root.Q<Toggle>("Tank3");
        Fridge1 = root.Q<Toggle>("Fridge1");
        Fridge2 = root.Q<Toggle>("Fridge2");

       

        if (GlobalVariableStore.Interactdistance)
        {
             Magnet1.visible = true;
        }
        else
        {
            Magnet1.visible = false;
        }

        if(GlobalVariableStore.TankOpen)
        {
            Tank1.visible = true;
            Tank2.visible = true;
            Tank3.visible = true;
            Tank1.SetEnabled(true);
            Tank2.SetEnabled(true);
            Tank3.SetEnabled(true);
        }
        else
        {
            Tank1.SetEnabled(false);
            Tank2.SetEnabled(false);
            Tank3.SetEnabled(false);
        }

        if(GlobalVariableStore.TankCheck1)
        {
            Tank1.value = true;
        }
        else
        {
            Tank1.value = false;
        }
        if (GlobalVariableStore.TankCheck2)
        {
            Tank2.value = true;
        }
        else
        {
            Tank2.value = false;
        }
        if (GlobalVariableStore.TankCheck3)
        {
            Tank3.value = true;
        }
        else
        {
            Tank3.value = false;
        }


        if (GlobalVariableStore.FridgeCheck1)
        {
            Fridge1.value = true;
        }
        else
        {
            Fridge1.value = false;
        }
        if (GlobalVariableStore.FridgeCheck2)
        {
            Fridge2.value = true;
        }
        else
        {
            Fridge2.value = false;
        }



        if (GlobalVariableStore.FridgeOpen)
        {
            Fridge1.visible = true;
            Fridge2.visible = true;
            Fridge1.SetEnabled(true);
            Fridge2.SetEnabled(true);
        }
        else
        {
            Fridge1.SetEnabled(false);
            Fridge2.SetEnabled(false);
        }

        if (GlobalVariableStore.OMOpen)
        {
            Pete.visible = true;
            Pete.SetEnabled(true);
        }
        else
        {
           // Pete.visible = false;
            Pete.SetEnabled(false);
        }



        //GlobalVariableStore.InteractableObject.OnFocused(GlobalVariableStore.PlayerTrans);


        //  Debug.Log(Magnet.resolvedStyle.opacity);

    }

    void MagnetButtonPressed()
    {
        GlobalVariableStore.InteractableObject.OnFocused(GlobalVariableStore.PlayerTrans);

    }


    void PauseButtonPressed()
    {

        if (!GlobalVariableStore.IsPaused) 
        {
            GlobalVariableStore.IsPaused = true;
        }
        else if (GlobalVariableStore.IsPaused)
        {
            GlobalVariableStore.IsPaused = false;
            Time.timeScale = 1;
        }



    }

    void setUpButton()
    {


        var root = GetComponent<UIDocument>().rootVisualElement;

        Magnet1 = root.Q<Button>("Magnify");

        PauseButton = root.Q<Button>("PauseButton");

        Magnet1.clicked += MagnetButtonPressed;

        PauseButton.clicked += PauseButtonPressed;

        isSetup = true;


    }


}
