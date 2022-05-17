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

    public VisualElement PeteGlad;
    public VisualElement PeteSad;

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
            GlobalVariableStore.OML3Open = false;
            GlobalVariableStore.OMOpen = false;
            GlobalVariableStore.exitOpen = true;
            isSetup = false;

            interactMenu.SetActive(false);



            

            
        }
        else
        {
            WrongText.visible = true;
            Text.visible = false;
            PeteSad.visible = true;
            PeteGlad.visible = false;

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

        PeteGlad = root.Q<VisualElement>("PeteGlad");

        PeteSad = root.Q<VisualElement>("PeteSad");

        WrongText.visible = false;

        PeteSad.visible = false;

        closeMenu.clicked += closeMenuPressed;

        CinteractButton.clicked += CinteractButtonPressed;

      
        isSetup = true;


    }
}
