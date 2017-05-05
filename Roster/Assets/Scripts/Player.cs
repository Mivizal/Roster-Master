using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))] //Sets a condition where it requires Controller2D script to run. 

public class Player : MonoBehaviour
{

    Controller2D controller;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<Controller2D> ();
    }
}	
