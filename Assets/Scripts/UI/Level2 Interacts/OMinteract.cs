using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class OMinteract : MonoBehaviour
{
    public GameObject interactMenu;

    public Button closeMenu;
    public Button closeMenu2;
    public Button CinteractButton;

    public Label Text;
    public Label WrongText;
    public VisualElement VisualElement1;
    public VisualElement VisualElement2;

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

        if (GlobalVariableStore.SupervisorL21 && GlobalVariableStore.SupervisorL22 && GlobalVariableStore.SupervisorL23)
        {

            GlobalVariableStore.SupervisorL24 = true;
            GlobalVariableStore.SupervisorCheckL24 = true;
            VisualElement1.SetEnabled(false);
            VisualElement1.visible = false;
            VisualElement2.SetEnabled(true);
            VisualElement2.visible = true;

            GlobalVariableStore.exitOpen = true;

        }
        else
        {
            WrongText.visible = true;
            Text.visible = false;

            PeteSad.visible = true;
            PeteGlad.visible = false;

            if (GlobalVariableStore.SupervisorL21 == false)
            {
                GlobalVariableStore.SupervisorCheckL21 = false;

            }
            if (GlobalVariableStore.SupervisorL22 == false)
            {
                GlobalVariableStore.SupervisorCheckL22 = false;

            }
            if (GlobalVariableStore.SupervisorL23 == false)
            {
                GlobalVariableStore.SupervisorCheckL23 = false;

            }

        }



    }

    void closeMenu2Pressed()
    {

        Debug.Log("Exit Menu Button Pressed");
        Time.timeScale = 1;

        isSetup = false;

        interactMenu.SetActive(false);

    }

    void setUpButton()
    {


        var root = GetComponent<UIDocument>().rootVisualElement;

        closeMenu = root.Q<Button>("closeMenu");

        closeMenu2 = root.Q<Button>("closeMenu2");

        CinteractButton = root.Q<Button>("CorrectInteract");

        Text = root.Q<Label>("Text");

        WrongText = root.Q<Label>("WrongText");

        PeteGlad = root.Q<VisualElement>("PeteGlad");

        PeteSad = root.Q<VisualElement>("PeteSad");

        VisualElement1 = root.Q<VisualElement>("VisualElement1");

        VisualElement2 = root.Q<VisualElement>("VisualElement2");

        WrongText.visible = false;

        PeteSad.visible = false;

        VisualElement2.visible = false;

        closeMenu.clicked += closeMenuPressed;

        CinteractButton.clicked += CinteractButtonPressed;

        closeMenu2.clicked += closeMenu2Pressed;

        isSetup = true;


    }
}
