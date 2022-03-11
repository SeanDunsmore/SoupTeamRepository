using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LevelEndUI : MonoBehaviour
{

    public GameObject interactMenu;

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

    void setUpButton()
    {

        
        var root = GetComponent<UIDocument>().rootVisualElement;

        isSetup = true;


    }

}
