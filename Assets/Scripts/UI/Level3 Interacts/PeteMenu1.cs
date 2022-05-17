using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PeteMenu1 : MonoBehaviour
{
    public GameObject interactMenu;

    public bool isSetup = false;
    public Button TalkButton;
    public Button TalkButton2;
    public Button TalkButton3;
    public Button ExitButton;
    public Button ExitButton2;
    public VisualElement VisualElement1;
    public VisualElement VisualElement2;
    public VisualElement VisualElement3;
    public Label text1;
    public Label Wrongtext1;
    public Label Wrongtext2;
    public Label Righttext1;
    public Label Righttext2;

    public GameObject Interactpad1;
    public GameObject Interactpad2;
    public GameObject Interactpad3;
    public GameObject Interactpad4;
    public GameObject InteractPete1;
    public GameObject InteractPete2;
    public GameObject InteractSupervisor;

    // Start is called before the first frame update
    void Start()
    {
        // GlobalVariableStore.OMOpen = true;
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

    void TalkPressed()
    {

        Interactpad1.SetActive(true);
        Interactpad2.SetActive(true);
        Interactpad3.SetActive(true);
        Interactpad4.SetActive(true);

        VisualElement1.SetEnabled(false);
         VisualElement2.SetEnabled(true);

        VisualElement2.visible = true;

        GlobalVariableStore.ForkOpen = true;
        GlobalVariableStore.GenOpen = true;
    }

    void TalkPressed2()
    {

        if(GlobalVariableStore.Forklift1 && GlobalVariableStore.Forklift2)
        {

            text1.visible = false;
            Wrongtext1.visible = false;
            Wrongtext2.visible = false;
            Righttext2.visible = false;


            Righttext1.visible = true;
            GlobalVariableStore.SupervisorL31 = true;
        }
        else
        {
            text1.visible = false;
            Wrongtext2.visible = false;
            Righttext1.visible = false;
            Righttext2.visible = false;

            Wrongtext1.visible = true;

        }


    }

    void TalkPressed3()
    {


        if (GlobalVariableStore.Generator1 && GlobalVariableStore.Generator2)
        {

            text1.visible = false;
            Wrongtext1.visible = false;
            Wrongtext2.visible = false;
            Righttext1.visible = false;


            Righttext2.visible = true;


            GlobalVariableStore.SupervisorL32 = true;

        }
        else
        {
            text1.visible = false;
            Wrongtext1.visible = false;
            Righttext1.visible = false;
            Righttext2.visible = false;

            Wrongtext2.visible = true;

        }

    }

    void ExitPressed()
    {

        if (GlobalVariableStore.SupervisorL31 && GlobalVariableStore.SupervisorL32)
        {
            VisualElement2.visible = false;
            VisualElement3.visible = true;
            VisualElement2.SetEnabled(false);
            VisualElement3.SetEnabled(true);
        }
        else
        {
        Time.timeScale = 1;

        isSetup = false;

        interactMenu.SetActive(false);


        }


        

    }


    void ExitPressed2()
    {



                Interactpad1.SetActive(false);
    Interactpad2.SetActive(false);
    Interactpad3.SetActive(false);
    Interactpad4.SetActive(false);
    InteractPete1.SetActive(false);
    InteractPete2.SetActive(true);
    InteractSupervisor.SetActive(true);


        GlobalVariableStore.ForkOpen = false;
        GlobalVariableStore.GenOpen = false;
        GlobalVariableStore.OML3Open = true;
        GlobalVariableStore.OMOpen = false;



        Time.timeScale = 1;

            isSetup = false;

            interactMenu.SetActive(false);


       




    }


    void setUpButton()
    {


        var root = GetComponent<UIDocument>().rootVisualElement;


        VisualElement1 = root.Q<VisualElement>("VisualElement1");

        VisualElement2 = root.Q<VisualElement>("VisualElement2");

        VisualElement3 = root.Q<VisualElement>("VisualElement3");

        TalkButton = root.Q<Button>("TalkButton");

        TalkButton2 = root.Q<Button>("TalkButton2");

        TalkButton3 = root.Q<Button>("TalkButton3");

        ExitButton = root.Q<Button>("closeMenu");

        ExitButton2 = root.Q<Button>("closeMenu2");

        text1 = root.Q<Label>("Text1");
        Wrongtext1 = root.Q<Label>("Text2");
        Wrongtext2 = root.Q<Label>("Text3");
        Righttext1 = root.Q<Label>("Text4");
        Righttext2 = root.Q<Label>("Text5");



        VisualElement2.visible = false;
        VisualElement3.visible = false;
        text1.visible = false;
        Wrongtext2.visible = false;
        Righttext1.visible = false;
        Righttext2.visible = false;

        Wrongtext1.visible =false;


        TalkButton.clicked += TalkPressed;

        TalkButton2.clicked += TalkPressed2;

        TalkButton3.clicked += TalkPressed3;

        ExitButton.clicked += ExitPressed;

        ExitButton2.clicked += ExitPressed2;

        VisualElement2.SetEnabled(false);
        VisualElement3.SetEnabled(false);

        isSetup = true;


    }



}
