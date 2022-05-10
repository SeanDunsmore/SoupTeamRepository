using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TankInteract1 : MonoBehaviour
{
    public GameObject interactMenu;

    public Button closeMenu;

    public Button CinteractButton;
    public Button INCinteractButton;
    public bool isSetup = false;
    public Material Material1;
    public GameObject Pad;

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

    void CinteractButtonPressed()
    {

        Debug.Log("High Interact Button Pressed");


        GlobalVariableStore.TankSet1 = true;

        Debug.Log(GlobalVariableStore.TankSet1);

        Pad.GetComponent<MeshRenderer>().material = Material1;

    }

    void INCinteractButtonPressed()
    {

        Debug.Log("INCInteract Button Pressed");


        GlobalVariableStore.TankSet1 = false;

        Debug.Log(GlobalVariableStore.TankSet1);

        Pad.GetComponent<MeshRenderer>().material = Material1;

    }

    void setUpButton()
    {


        var root = GetComponent<UIDocument>().rootVisualElement;

        closeMenu = root.Q<Button>("closeMenu");

        CinteractButton = root.Q<Button>("CorrectInteract");

        INCinteractButton = root.Q<Button>("IncorrectInteract");

        closeMenu.clicked += closeMenuPressed;

        CinteractButton.clicked += CinteractButtonPressed;

        INCinteractButton.clicked += INCinteractButtonPressed;

        isSetup = true;


    }

}
