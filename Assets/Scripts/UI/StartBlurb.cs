using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class StartBlurb : MonoBehaviour
{

    public GameObject interactMenu;
    public Button ExitMenu;
    public bool isSetup = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
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

        Time.timeScale = 1;
        interactMenu.SetActive(false);
        isSetup = false;


    }

    void setUpButton()
    {


        var root = GetComponent<UIDocument>().rootVisualElement;

        ExitMenu = root.Q<Button>("ExitInteract");

        ExitMenu.clicked += closeMenuPressed;

        isSetup = true;


    }

}

