using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBehaviour
{
    private int width;
    private int height;

    private int[,] gridArray;

  //private float Gridspace = 5f;

  
   
    public GridBehaviour(int width, int height)
    {
        this.width = width;
        this.height = height;

        gridArray = new int[width, height];
        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int y = 0; y < gridArray.GetLength(1); y++)
            {


          
            }
        }
    }
   

    //Create Text
    public static TextMesh CreateWorldText(Transform parent, string text, Vector3 localPosition, int fontSize, Color color, TextAnchor textAnchor, TextAlignment textAlignment, int sortingOrder)
    {

        //Create a game object to place text position in world
        GameObject gameObject = new GameObject("world_text", typeof(TextMesh));
        Transform transform = gameObject.transform;
        transform.SetParent(parent, false);
        transform.localPosition = localPosition;

        //Create text
        TextMesh textMesh = gameObject.GetComponent<TextMesh>();
        textMesh.anchor = textAnchor;
        textMesh.alignment = textAlignment;
        textMesh.text = "cowabunga";
        textMesh.fontSize = fontSize;
        textMesh.color = color;
        textMesh.GetComponent<MeshRenderer>().sortingOrder = sortingOrder;

        return textMesh;

    }


    // [SeralizeField] private GameObject GridCellPrefab;


}

