using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBehaviour
{
    private int width;
    private int height;
    private float cellSize;

    private int[,] gridArray;

  //private float Gridspace = 5f;

  
   
    public GridBehaviour(int width, int height, float cellSize)
    {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;

        gridArray = new int[width, height];

        //hopefully this works
        GameObject grid = new GameObject("Grid", typeof(TextMesh));

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int y = 0; y < gridArray.GetLength(1); y++)
            {

                CreateWorldText(grid.transform, gridArray[x, y].ToString(), GetWorldPosition(x, y), 5, Color.white, TextAnchor.MiddleCenter, TextAlignment.Left, 1);

                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1));


            }
        }
    }
   
    //Get position
    private Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x, y) * cellSize;
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

