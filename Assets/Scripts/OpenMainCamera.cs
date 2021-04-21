using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMainCamera : MonoBehaviour
{

    private Camera cam;

    void Start()
    {
        cam = Camera.main;
        
    }
    bool isExpanded = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))

            isExpanded = !isExpanded;

        if (isExpanded)
        {
            cam.rect = new Rect(0.5f, 0.0f, 1.0f, 1.0f);
        }
        else
        {
            cam.rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
        }
    }
    /* bool isExpanded = false;

     void Update()
     {
         //print("Do stuff...");
         if (Input.GetKeyDown(KeyCode.M))
             isExpanded = !isExpanded;

         if (isExpanded)
         {
             print("Do stuff...");
         }
         else
         {
             //print("Do opposite stuff...");
         }
     }*/
}
