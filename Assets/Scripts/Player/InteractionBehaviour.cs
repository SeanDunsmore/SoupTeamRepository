using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionBehaviour : MonoBehaviour
{
    public Interact focus;
    public LayerMask WhatCanBeClicked;
    // Update is called once per frame
    float distance;

  

    public GameObject interactIcon;

    //NOTE: since the interaction is based on raycast, it needs a physical body


    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(myRay, out hitInfo, 100, WhatCanBeClicked))
            {
                UnsetFocus();
            }

        }



        if (Input.GetMouseButtonDown(1)) // right click no camera?
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                Interact interact = hit.collider.GetComponent<Interact>();
                if (interact != null)
                {

                    SetFocus(interact);
                }
            }

        }

        void SetFocus(Interact newFocus)
        {
            if (newFocus != focus)
            {

                if (focus != null)
                    focus.OnDefocused();

                focus = newFocus;


            }

            newFocus.OnFocused(transform);
        }

        void UnsetFocus()
        {
            if (focus != null)
                focus.OnDefocused();

            focus = null;
            // focus.OnDefocused();
        }


      //  Ray Dray = Camera.main.ScreenPointToRay(Input.mousePosition);
      //  RaycastHit DistanceHit;
      //  Interact Dinteract = DistanceHit.collider.GetComponent<Interact>();
       // distance = Vector3.Distance(player.position, transform.position);


      //  if (distance <= Dinteract.radius)
       // {
       //     interactIcon.SetActive(true);
       // }
      //  else
       // {

       //     interactIcon.SetActive(false);
      //  }

    }
}
