using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIcontroller : MonoBehaviour
{

    public GameObject interactMenu;

    public Button closeMenu;

    public Button testButton;
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

    void testButtonPressed()
    {

        Debug.Log("testButton Button Pressed");
   
    }

    void setUpButton()
    {

        
        var root = GetComponent<UIDocument>().rootVisualElement;

        closeMenu = root.Q<Button>("closeMenu");

        testButton = root.Q<Button>("testButton");

        closeMenu.clicked += closeMenuPressed;

        testButton.clicked += testButtonPressed;


        isSetup = true;


    }

}
