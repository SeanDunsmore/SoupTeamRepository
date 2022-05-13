using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TankInteract2 : MonoBehaviour
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
        GlobalVariableStore.TankCheck2 = true;
        interactMenu.SetActive(false);

        if (GlobalVariableStore.TankCheck1 && GlobalVariableStore.TankCheck2 && GlobalVariableStore.TankCheck3)
        {
            GlobalVariableStore.OMOpen = true;

        }

    }

    void CinteractButtonPressed()
    {

        Debug.Log("High Interact Button Pressed");


        GlobalVariableStore.TankSet2 = true;

        Debug.Log(GlobalVariableStore.TankSet2);

        Pad.GetComponent<MeshRenderer>().material = Material1;

    }

    void INCinteractButtonPressed()
    {

        Debug.Log("INCInteract Button Pressed");


        GlobalVariableStore.TankSet2 = false;

        Debug.Log(GlobalVariableStore.TankSet2);

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
