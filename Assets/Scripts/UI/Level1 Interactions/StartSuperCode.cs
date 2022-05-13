using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class StartSuperCode : MonoBehaviour
{
    public GameObject interactMenu;
    public GameObject interactpad1;
    public GameObject interactpad2;
    public GameObject interactpad3;
    public GameObject Supervisor;
    public GameObject StartVisor;
    public bool isSetup = false;
    public Button StartButton;

    // Start is called before the first frame update
    void Start()
    {
        GlobalVariableStore.OMOpen = true;
        setUpButton();

    }

    // Update is called once per frame
    void Update()
    {

        if (isSetup == false)
        {
            setUpButton();
        }

    }

    void StartPressed()
    {
         
         interactMenu.SetActive(false);
         interactpad1.SetActive(true);
         interactpad2.SetActive(true);
         interactpad3.SetActive(true);
         Supervisor.SetActive(true);
        GlobalVariableStore.OMOpen = false;
        GlobalVariableStore.TankOpen = true;

            StartVisor.SetActive(false);
        Time.timeScale = 1;

    }

    void setUpButton()
    {


        var root = GetComponent<UIDocument>().rootVisualElement;

        StartButton = root.Q<Button>("StartButton");
  

       StartButton.clicked += StartPressed;


        isSetup = true;


    }



}
