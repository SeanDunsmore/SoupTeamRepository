using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class SuperInteract : MonoBehaviour
{
    public GameObject interactMenu;
    public GameObject interactMenu2;
    public Button closeMenu;

    public GameObject interactpad1;
    public GameObject interactpad2;
    public GameObject interactpad3;

    public Label Text;
    public Label WrongText;
    public VisualElement PeteGlad;
    public VisualElement PeteSad;

    public Button CinteractButton;
    public Button CinteractButton2;
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
        interactMenu2.SetActive(false);
    }

    void CinteractButtonPressed()
    {

        Debug.Log("Super Interact Button Pressed");

        if (GlobalVariableStore.TankSet1 && GlobalVariableStore.TankSet2 && GlobalVariableStore.TankSet3)
        {

            isSetup = false;

            interactMenu.SetActive(false);
            interactMenu2.SetActive(true);
            GlobalVariableStore.Menu2Check = true;


            interactpad1.SetActive(true);
            interactpad2.SetActive(true);
            interactpad3.SetActive(true);

            GlobalVariableStore.OMOpen = false;
            GlobalVariableStore.TankOpen = false;
            GlobalVariableStore.FridgeOpen = true;
        }
        else{


            WrongText.visible = true;
            Text.visible = false;
            PeteSad.visible = true;
            PeteGlad.visible = false;
            GlobalVariableStore.TankCheck1 = false;
            GlobalVariableStore.TankCheck2 = false;
            GlobalVariableStore.TankCheck3 = false;
            GlobalVariableStore.TankSet1 = false;
            GlobalVariableStore.TankSet2 = false;
            GlobalVariableStore.TankSet3 = false;


        }




    }

    void CinteractButton2Pressed()
    {

        Debug.Log("Super Interact Button 2 Pressed");

        if (GlobalVariableStore.TankSet1 && GlobalVariableStore.TankSet2 && GlobalVariableStore.TankSet3)
        {
            if (GlobalVariableStore.LevelEnd1 && GlobalVariableStore.LevelEnd2)
            {
                Time.timeScale = 1;
                SceneManager.LoadScene("Load");

            }
            else
            {
                WrongText.visible = true;
                Text.visible = false;
                PeteSad.visible = true;
                PeteGlad.visible = false;
            }


            }

    }

        void setUpButton()
         {

        if (GlobalVariableStore.Menu2Check)
        {
            interactMenu.SetActive(false);
            interactMenu2.SetActive(true);

        }

        var root = GetComponent<UIDocument>().rootVisualElement;

        closeMenu = root.Q<Button>("closeMenu");

        CinteractButton = root.Q<Button>("CorrectInteract");

        CinteractButton2 = root.Q<Button>("CorrectInteract2");

        Text = root.Q<Label>("Text1");

        WrongText = root.Q<Label>("Text2");

        PeteGlad = root.Q<VisualElement>("PeteGlad");

        PeteSad = root.Q<VisualElement>("PeteSad");

        WrongText.visible = false;

        PeteSad.visible = false;


        closeMenu.clicked += closeMenuPressed;

        CinteractButton.clicked += CinteractButtonPressed;

        CinteractButton2.clicked += CinteractButton2Pressed;
      
        isSetup = true;


            }
}
