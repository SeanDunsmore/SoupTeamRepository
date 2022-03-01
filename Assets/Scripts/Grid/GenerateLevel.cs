using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class test : MonoBehaviour
{

    //public UnityEngine.AI.NavMeshSurface surface;

    private void Start()
    {

        //Initiate Grid
        GridBehaviour Grid = new GridBehaviour(20, 20, 10);


        //Update NavMesh
        //surface.BuildNavMesh();

    }
}
