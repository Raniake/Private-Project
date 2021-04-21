using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    private Camera cam;
    private float startingFOV;

    public float minFOV;
    public float maxFOV;
    public float zoomRate;

    private float currentFOV;


    private void Start()
    {
        cam = GetComponent<Camera>();
        startingFOV = cam.fieldOfView;
    }

    /*private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, (cam.transform.psition + finaloffset), -25f);
    }*/


    private void Update()
    {
        currentFOV = cam.fieldOfView;

        if (Input.GetKeyDown(KeyCode.P))
        {
            currentFOV = startingFOV;
        }

        UseWheel();

    }


    public void UseWheel()
    {
        currentFOV = cam.fieldOfView;

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        currentFOV += scroll * zoomRate;

        currentFOV = Mathf.Clamp(currentFOV, minFOV, maxFOV);
        cam.fieldOfView = currentFOV;
    }

}
