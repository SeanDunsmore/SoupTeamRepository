using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitLevel3 : MonoBehaviour
{

    public GameObject Exit3;

    // Start is called before the first frame update
    void Start()
    {
        Exit3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariableStore.SupervisorL34)
        {
            Exit3.SetActive(true);

        }




    }
}
