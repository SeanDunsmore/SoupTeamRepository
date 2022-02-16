using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using 

public class Grid
{
    private int width;
    private int height;
    private int[,] gridArray;
    //Gameobject gameobject = new Gameobject("text", typeof(Textmesh));


    public Grid(int width, int height)
    {
        this.width = width;
        this.height = height;

        gridArray = new int[width, height];

       // Debug.log(width + "," + height);

        for (int x = 0; x < gridArray.GetLegnth(0); x++)
        {
            for (int y = 0; y < gridArray.GetLegnth(1); y++)
            {


            }
        }



    }

}
