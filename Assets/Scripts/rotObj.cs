using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rotObj : MonoBehaviour
{
    float rotSpeed = 10;
    //[SerializeField] private Camera cam;
    //void Start()
    //{
    //    cam.enabled = true;
    //}
    ////public bool chooseStructure;
    ////[SerializeField] private Camera cam;


    void OnMouseDrag()
    {
        
        //cam.enabled = false;

        float rotX = Input.GetAxis("Mouse X")*rotSpeed*Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y")*rotSpeed*Mathf.Deg2Rad;
        //float rotZ = Input.GetAxis("Mouse Z") * rotSpeed * Mathf.Deg2Rad;

       // transform.RotateAround(Vector3.up, -rotX);
       // transform.RotateAround(Vector3.right, -rotY);
        //transform.RotateAround(Vector3.down, rotX);
        transform.RotateAround(Vector3.left, rotY);


    }
}
