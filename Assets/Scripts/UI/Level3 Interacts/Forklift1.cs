using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Forklift1 : MonoBehaviour
{

    public GameObject interactMenu;

    public Button closeMenu;

    public Button interactButton;
    public bool isSetup = false;

    // Start is called before the first frame update
    void Start()
    {

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


    void closeMenuPressed()
    {

        Debug.Log("Exit Menu Button Pressed");
        Time.timeScale = 1;

        isSetup = false;

        interactMenu.SetActive(false);

        GlobalVariableStore.ForkliftCheck1 = true;
        if (GlobalVariableStore.ForkliftCheck1 && GlobalVariableStore.ForkliftCheck2)
        {
            GlobalVariableStore.OMOpen = true;

        }


    }

    void interactButtonPressed()
    {

        Debug.Log("testButton Button Pressed");



        GlobalVariableStore.ForkliftCheck1 = true;
        GlobalVariableStore.Forklift1 = true;

        Debug.Log("Exit Menu Button Pressed");
        Time.timeScale = 1;

        isSetup = false;

        interactMenu.SetActive(false);

        
        if (GlobalVariableStore.ForkliftCheck1 && GlobalVariableStore.ForkliftCheck2)
        {
            GlobalVariableStore.OMOpen = true;

        }



    }

    void setUpButton()
    {

        
        var root = GetComponent<UIDocument>().rootVisualElement;

        closeMenu = root.Q<Button>("closeMenu");

        interactButton = root.Q<Button>("interact");

        closeMenu.clicked += closeMenuPressed;

        interactButton.clicked += interactButtonPressed;


        isSetup = true;


    }

}
