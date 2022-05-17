using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;



public class LoadScreen : MonoBehaviour
{
  


    //Random Rnd = new Random();


    public float TimeTarget;
    // Start is called before the first frame update
    void Start()
    {
        
        TimeTarget = 1500; // = Rnd.Next(3, 9);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        TimeTarget -= Time.time;
       //  GlobalVariableStore.Level = 1;
        Debug.Log(GlobalVariableStore.Level);
        if(TimeTarget <= 0.0f)
        {
            EndTime();

        }




    }

    void EndTime()
    {

       
        if (GlobalVariableStore.Level == 0)
        {

            GlobalVariableStore.Level = 1;
            SceneManager.LoadScene("Level 1");


        }
        else if (GlobalVariableStore.Level == 1) {

            GlobalVariableStore.Level = 2;
        SceneManager.LoadScene("Level 2");


        }
         else  if (GlobalVariableStore.Level == 2)
        {

            GlobalVariableStore.Level = 3;
            SceneManager.LoadScene("Level 3");


        }
         else if (GlobalVariableStore.Level == 3)
        {

            GlobalVariableStore.Level = 0;
            SceneManager.LoadScene("Title Screen");


        }








    }

}
