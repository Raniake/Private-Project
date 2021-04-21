using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ChangeColor : MonoBehaviour

{

    [SerializeField]  public Material materials;
    [SerializeField]  public Renderer rend;
    [SerializeField] private Material DefaultMaterial;
    static private Transform selection = null;
    private bool selected = false;
    //Transform selection;
   
 

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;



    }
    void Update()
    {
        if (selected && rend.transform != selection)
        {
            selected = false;
            rend.sharedMaterial = DefaultMaterial;
        }
    }

    void OnMouseDown()
    {

        if (Input.GetMouseButtonDown(0))
        {
            
            selected = true;
            selection = rend.transform;
            rend.sharedMaterial = materials;
          
            

        }
       
    }




}


