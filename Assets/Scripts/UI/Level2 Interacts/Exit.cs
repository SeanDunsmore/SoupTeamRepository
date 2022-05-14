using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{

    public GameObject LevelExit;
    public Button ExitMenu;
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

        Time.timeScale = 1;
        SceneManager.LoadScene("Level 3");
        LevelExit.SetActive(false);
       

    }

    void setUpButton()
    {


        var root = GetComponent<UIDocument>().rootVisualElement;

        ExitMenu = root.Q<Button>("ExitInteract");

        ExitMenu.clicked += closeMenuPressed;

        isSetup = true;


    }

}
