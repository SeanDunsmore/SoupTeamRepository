using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OMmenucode : MonoBehaviour
{
    public GameObject interactMenu;

    public bool isSetup = false;
    public Button TalkButton;
    public Button TalkButton2;
    public Button TalkButton3;
    public VisualElement VisualElement1;
    public VisualElement VisualElement2;


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
         VisualElement1.SetEnabled(false);
         VisualElement2.SetEnabled(true);

        VisualElement2.visible = true;
    }

    void TalkPressed2()
    {
        GlobalVariableStore.SupervisorL21 = true;
        Time.timeScale = 1;

        isSetup = false;

        interactMenu.SetActive(false);

    }

    void TalkPressed3()
    {
        Time.timeScale = 1;

        isSetup = false;

        interactMenu.SetActive(false);

    }

    void setUpButton()
    {


        var root = GetComponent<UIDocument>().rootVisualElement;


        VisualElement1 = root.Q<VisualElement>("VisualElement1");

        VisualElement2 = root.Q<VisualElement>("VisualElement2");

        TalkButton = root.Q<Button>("TalkButton");

        TalkButton2 = root.Q<Button>("TalkButton2");

        TalkButton3 = root.Q<Button>("TalkButton3");


        TalkButton.clicked += TalkPressed;

        TalkButton2.clicked += TalkPressed2;

        TalkButton3.clicked += TalkPressed3;

        VisualElement2.SetEnabled(false);
      
        isSetup = true;


    }



}
