using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Level2ScreenUI : MonoBehaviour
{

    public GameObject UI;
    public Button Magnet1;
    public IMGUIContainer Magnet2;
    public Toggle Pete;
    public Toggle Supervisor1;
    public Toggle Supervisor2;
    public Toggle Supervisor3;
    public Toggle ExitSet;
   

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

        var root = GetComponent<UIDocument>().rootVisualElement;

        Magnet1 = root.Q<Button>("Magnify");
        Magnet2 = root.Q<IMGUIContainer>("UNMagnify");

        Pete = root.Q<Toggle>("Pete");
        Supervisor1 = root.Q<Toggle>("Supervisor1");
        Supervisor2 = root.Q<Toggle>("Supervisor2");
        Supervisor3 = root.Q<Toggle>("Supervisor3");
        ExitSet = root.Q<Toggle>("ExitDoor");
     

       

        if (GlobalVariableStore.Interactdistance)
        {
             Magnet1.visible = true;
        }
        else
        {
            Magnet1.visible = false;
        }

       

        if (GlobalVariableStore.OMOpen)
        {
            Pete.visible = true;
        }
        else
        {
            Pete.visible = false;
        }



        //GlobalVariableStore.InteractableObject.OnFocused(GlobalVariableStore.PlayerTrans);


        //  Debug.Log(Magnet.resolvedStyle.opacity);

    }

    void MagnetButtonPressed()
    {
        GlobalVariableStore.InteractableObject.OnFocused(GlobalVariableStore.PlayerTrans);

    }


    void setUpButton()
    {


        var root = GetComponent<UIDocument>().rootVisualElement;

        Magnet1 = root.Q<Button>("Magnify");
     

        Magnet1.clicked += MagnetButtonPressed;
     


        isSetup = true;


    }


}
