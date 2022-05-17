using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Level3screenUIDoc : MonoBehaviour
{

    public GameObject UI;
    public Button Magnet1;
    public Button PauseButton;
    public IMGUIContainer Magnet2;
    public Toggle Pete;
    public Toggle Generator1;
    public Toggle Generator2;
    public Toggle Forklift1;
    public Toggle Forklift2;
    public Toggle Supervisor1;
    public Toggle Supervisor2;
    public Toggle Supervisor3;
    public Toggle exit;

    public bool isSetup = false;

    // Start is called before the first frame update
    void Start()
    {

        GlobalVariableStore.Level = 3;
        GlobalVariableStore.OMOpen = true;
        //GlobalVariableStore.GenOpen = true;

        setUpButton();
       
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
        Generator1 = root.Q<Toggle>("Generator1");
        Generator2 = root.Q<Toggle>("Generator2");
        Forklift1 = root.Q<Toggle>("Forklift1");
        Forklift2 = root.Q<Toggle>("Forklift2");
       
        Supervisor3 = root.Q<Toggle>("Supervisor3");
        exit = root.Q<Toggle>("Exit");


        if (GlobalVariableStore.Interactdistance)
        {
             Magnet1.visible = true;
        }
        else
        {
            Magnet1.visible = false;
        }

        if(GlobalVariableStore.GenOpen)
        {
            Generator1.visible = true;
            Generator2.visible = true;
         
            Generator1.SetEnabled(true);
            Generator2.SetEnabled(true);
         
        }
        else
        {
            Generator1.SetEnabled(false);
            Generator2.SetEnabled(false);
        }

        if (GlobalVariableStore.ForkOpen)
        {
            Forklift1.visible = true;
            Forklift2.visible = true;

            Forklift1.SetEnabled(true);
            Forklift2.SetEnabled(true);

        }
        else
        {
            Forklift1.SetEnabled(false);
            Forklift2.SetEnabled(false);
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
     
        if (GlobalVariableStore.OML3Open)
        {

            Supervisor3.visible = true;

            Supervisor3.SetEnabled(true);
        }
        else
        {

            Supervisor3.SetEnabled(false);
        }

        if (GlobalVariableStore.exitOpen)
        {

            exit.visible = true;

            exit.SetEnabled(true);
        }
        else
        {

            exit.SetEnabled(false);
        }






        if (GlobalVariableStore.GeneratorCheck1)
        {
            Generator1.value = true;
        }
        else
        {
            Generator1.value = false;
        }
        if (GlobalVariableStore.GeneratorCheck2)
        {
            Generator2.value = true;
        }
        else
        {
            Generator2.value = false;
        }


        if (GlobalVariableStore.ForkliftCheck1)
        {
            Forklift1.value = true;
        }
        else
        {
            Forklift1.value = false;
        }


        if (GlobalVariableStore.ForkliftCheck2)
        {
            Forklift2.value = true;
        }
        else
        {
            Forklift2.value = false;
        }




        if(GlobalVariableStore.SupervisorCheckL33)
        {
            Supervisor3.value = true;
        }
        else
        {
            Supervisor3.value = false;
        }

        if (GlobalVariableStore.SupervisorCheckL34)
        {
            Pete.value = true;
        }
        else
        {
            Supervisor3.value = false;
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
