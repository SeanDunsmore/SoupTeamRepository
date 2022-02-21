using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using 


public class GridBehaviour
{
    private int width;
    private int height;
<<<<<<< Updated upstream
    private int[,] gridArray;
    //Gameobject gameobject = new Gameobject("text", typeof(Textmesh));

=======
     private int[,] gridArray;
  //  private float Gridspace = 5f;
>>>>>>> Stashed changes

  
   
    public GridBehaviour(int width, int height)
    {
        this.width = width;
        this.height = height;

        gridArray = new int[width, height];
        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int y = 0; y < gridArray.GetLength(1); y++)
            {
                GameObject gameObject = new GameObject("world_text", typeof(TextMesh));




<<<<<<< Updated upstream
       // Debug.log(width + "," + height);

        for (int x = 0; x < gridArray.GetLegnth(0); x++)
        {
            for (int y = 0; y < gridArray.GetLegnth(1); y++)
            {


            }
        }


=======
            }

        }
        
>>>>>>> Stashed changes

    }
   

   // [SeralizeField] private GameObject GridCellPrefab;


}

