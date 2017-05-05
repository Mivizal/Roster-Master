using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))] //Sets a condition where it requires Controller2D script to run. 

public class Player : MonoBehaviour
{
	float gravity * -2;
	Vector3
 
    Controller2D controller;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<Controller2D> ();
    }
}	
