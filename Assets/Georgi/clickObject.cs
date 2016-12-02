﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class clickObject : MonoBehaviour {

    public static GameObject selectedPawn;

    
    public string componentName;
    Texture2D outline;

    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update() {

    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0) && gameObject.GetComponent<pawn>().isPawnActive)
        {
           
            selectedPawn = gameObject;
               
            Debug.Log("The " + this.gameObject.name + " was clicked");
            componentName = this.gameObject.name;
            GameObject.Find("outline").transform.position = this.gameObject.transform.position;
            
        }
    }

}
