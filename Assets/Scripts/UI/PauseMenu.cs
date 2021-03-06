using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject interactMenu;

    public Button LevelSelectButton;
    public Button ExitButton;



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

    void LevelSelectButtonPressed()
    {
        Debug.Log("Return to Level Select Button Pressed");
        GlobalVariableStore.IsPaused = false;
        Time.timeScale = 1;
        isSetup = false;
        SceneManager.LoadScene("Level Select Menu");

    }

    void ExitButtonPressed()
    {
        Debug.Log("Level Resume Pressed");
        isSetup = false;
        GlobalVariableStore.IsPaused = false;
        Time.timeScale = 1;
    }

    void setUpButton()
    {

        
        var root = GetComponent<UIDocument>().rootVisualElement;

        LevelSelectButton = root.Q<Button>("levelSelect");
        ExitButton = root.Q<Button>("Exit");

        LevelSelectButton.clicked += LevelSelectButtonPressed;
        ExitButton.clicked += ExitButtonPressed;
      

        isSetup = true;


    }

}
