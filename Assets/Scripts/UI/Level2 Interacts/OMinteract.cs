using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class OMinteract : MonoBehaviour
{
    public GameObject interactMenu;

    public Button closeMenu;
    public Button CinteractButton;

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
    
    }

    void CinteractButtonPressed()
    {

        Debug.Log("Super Interact Button Pressed");

        if (GlobalVariableStore.SupervisorL21 && GlobalVariableStore.SupervisorL22 && GlobalVariableStore.SupervisorL23)
        {

            GlobalVariableStore.SupervisorL24 = true;

            Time.timeScale = 1;

            isSetup = false;

            interactMenu.SetActive(false);
           

        }


    }

   

    void setUpButton()
    {


        var root = GetComponent<UIDocument>().rootVisualElement;

        closeMenu = root.Q<Button>("closeMenu");

        CinteractButton = root.Q<Button>("CorrectInteract");

       

        closeMenu.clicked += closeMenuPressed;

        CinteractButton.clicked += CinteractButtonPressed;

      
        isSetup = true;


    }
}
