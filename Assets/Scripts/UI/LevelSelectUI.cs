using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class LevelSelectUI : MonoBehaviour
{

    public GameObject interactMenu;

    public Button Level1Button;
    public Button Level2Button;
    public Button Level3Button;
    public Button ReturnButton;


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

    void Level1ButtonPressed()
    {
        Debug.Log("Level 1 Button Pressed");
        SceneManager.LoadScene("Level 1");
    }

    void Level2ButtonPressed()
    {
        Debug.Log("Level 2 Button Pressed");
        SceneManager.LoadScene("Level 2");
    }

    void Level3ButtonPressed()
    {
        Debug.Log("Level 3 Button Pressed");
        SceneManager.LoadScene("Level 3");
    }

    void ReturnButtonPressed()
    {
        Debug.Log("Return Button Pressed");
        SceneManager.LoadScene("Title Screen");
    }

    void setUpButton()
    {

        
        var root = GetComponent<UIDocument>().rootVisualElement;

        Level1Button = root.Q<Button>("level1");
        Level2Button = root.Q<Button>("level2");
        Level3Button = root.Q<Button>("level3");
        ReturnButton = root.Q<Button>("Return");

        Level1Button.clicked += Level1ButtonPressed;
        Level2Button.clicked += Level2ButtonPressed;
        Level3Button.clicked += Level3ButtonPressed;
        ReturnButton.clicked += ReturnButtonPressed;

        isSetup = true;


    }

}
