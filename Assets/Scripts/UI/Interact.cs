using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    // Start is called before the first frame update
    public float radius = 3f;

    bool isFocus = false;
    Transform player;

    bool hasinteracted = false;
    //bool iswindowopen = false;

    public GameObject interactMenu;

    float distance = 4;

    public virtual void interact()
    {
        Debug.Log("INTERACT WITH " + transform.name);
        //iswindowopen = true;
        //// loop until is window open / equals true
        Time.timeScale = 0;

        interactMenu.SetActive(true);

    }

    void FixedUpdate()
    {

        player = GlobalVariableStore.PlayerTrans;

        distance = Vector3.Distance(player.position, transform.position);

        if (!GlobalVariableStore.InteractStateChanged)
        { 
            if (distance <= radius)
            {
                GlobalVariableStore.Interactdistance = true;
                GlobalVariableStore.InteractableObject = this;
                GlobalVariableStore.InteractStateChanged = true;

            }
            else
            {
                GlobalVariableStore.Interactdistance = false;
            }
        }


        if (isFocus && !hasinteracted)
        {

            if (distance <= radius)
            {

                  Debug.Log("INTERACT");
                  interact();
                  hasinteracted = true;
                  

            }
            
        }
    }


    public void OnFocused(Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
        hasinteracted = false;
    }

    public void OnDefocused()
    {
        isFocus = false;
        player = null;
        hasinteracted = false;
    }


    void OnDrawGizmosSelected ()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }



}
