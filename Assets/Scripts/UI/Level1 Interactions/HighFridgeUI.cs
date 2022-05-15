using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HighFridgeUI : MonoBehaviour
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

        GlobalVariableStore.FridgeCheck2 = true;
        if (GlobalVariableStore.FridgeCheck1 && GlobalVariableStore.FridgeCheck2)
        {
            GlobalVariableStore.OMOpen = true;

        }

    }

    void interactButtonPressed()
    {

        Debug.Log("High Interact Button Pressed");

        GlobalVariableStore.FridgeCheck2 = true;
        GlobalVariableStore.LevelEnd1 = true;

        Debug.Log(GlobalVariableStore.LevelEnd1);

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
