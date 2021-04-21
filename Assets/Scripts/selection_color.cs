using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selection_color : MonoBehaviour
{
    public Material materials;
    public Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;


    }

    void OnMouseDown()
    {

        if (Input.GetMouseButtonDown(0))
        {
            print(rend.transform.name);
            rend.sharedMaterial = materials;
        }
    }
}
