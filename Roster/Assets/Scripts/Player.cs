using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))] //Sets a condition where it requires Controller2D script to run. 

public class Player : MonoBehaviour
{
	float gravity = -20;
	Vector3 velocity;
 
    Controller2D controller;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<Controller2D> ();
    }

	void Update() {
		velocity.y += gravity * Time.deltaTime;
		controller.Move (velocity * Time.deltaTime);
	}
}	
