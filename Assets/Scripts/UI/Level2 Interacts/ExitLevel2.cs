using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitLevel2 : MonoBehaviour
{

    public GameObject Exit;

    // Start is called before the first frame update
    void Start()
    {
        Exit.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (GlobalVariableStore.SupervisorL21 && GlobalVariableStore.SupervisorL22 && GlobalVariableStore.SupervisorL23 && GlobalVariableStore.SupervisorL24)
        {
            Exit.SetActive(true);

        }




    }
}
