using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkingBehviour : MonoBehaviour
{
    public LayerMask WhatCanBeClicked;

    private UnityEngine.AI.NavMeshAgent myAgent;

    void Start()
    {
        myAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown (0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast (myRay, out hitInfo, 100, WhatCanBeClicked))
            {
                myAgent.SetDestination(hitInfo.point);
            }

        }

    }
}
