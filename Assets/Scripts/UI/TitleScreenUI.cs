using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class TitleScreenUI : MonoBehaviour
{

    public GameObject interactMenu;

    public Button LevelSelectButton;
    public Button ExitButton;
    public Button CreditsButton;
    public Button ExitCredits;
    public VisualElement Credits;
    public VisualElement MainMenu;


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
        Debug.Log("Level Select Button Pressed");
        SceneManager.LoadScene("Level Select Menu");
    }

    void ExitButtonPressed()
    {
        Debug.Log("Exit Button Pressed");
        Application.Quit();
    }

    void CreditsButtonPressed()
    {
        MainMenu.SetEnabled(false);
        Credits.visible = true;

        Debug.Log("Credits Button Pressed");
        
    }

    void ExitCreditsButtonPressed()
    {
        MainMenu.SetEnabled(true);
        Credits.visible = false;
        Debug.Log("Exit Credits Button Pressed");

    }

    void setUpButton()
    {

        
        var root = GetComponent<UIDocument>().rootVisualElement;

        LevelSelectButton = root.Q<Button>("levelSelect");
        ExitButton = root.Q<Button>("Exit");
        CreditsButton = root.Q<Button>("Credits");
        ExitCredits = root.Q<Button>("ExitCredit");

        MainMenu = root.Q<VisualElement>("MainMenu");
        Credits = root.Q<VisualElement>("CreditsElement");

        Credits.visible = false;

        LevelSelectButton.clicked += LevelSelectButtonPressed;
        ExitButton.clicked += ExitButtonPressed;
        CreditsButton.clicked += CreditsButtonPressed;
        ExitCredits.clicked += ExitCreditsButtonPressed;


        isSetup = true;


    }

}
