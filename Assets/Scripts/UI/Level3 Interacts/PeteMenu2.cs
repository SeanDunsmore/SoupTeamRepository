using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class PeteMenu2 : MonoBehaviour
{
    public GameObject interactMenu;

    public Button closeMenu;
    public Button CinteractButton;

    public Label Text;
    public Label WrongText;

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

        if (GlobalVariableStore.SupervisorL33)
        {

            GlobalVariableStore.SupervisorL34 = true;
            GlobalVariableStore.SupervisorCheckL34 = true;
            Time.timeScale = 1;

            isSetup = false;

            interactMenu.SetActive(false);

            GlobalVariableStore.OML3Open = false;
            
        }
        else
        {
            WrongText.visible = true;
            Text.visible = false;

            if (GlobalVariableStore.SupervisorL33 == false)
            {
                GlobalVariableStore.SupervisorCheckL33 = false;
                GlobalVariableStore.OML3Open = true;
                GlobalVariableStore.OMOpen = false;
            }

        }



    }

   

    void setUpButton()
    {


        var root = GetComponent<UIDocument>().rootVisualElement;

        closeMenu = root.Q<Button>("closeMenu");

        CinteractButton = root.Q<Button>("CorrectInteract");

        Text = root.Q<Label>("Text");

        WrongText = root.Q<Label>("WrongText");

        WrongText.visible = false;

        closeMenu.clicked += closeMenuPressed;

        CinteractButton.clicked += CinteractButtonPressed;

      
        isSetup = true;


    }
}
