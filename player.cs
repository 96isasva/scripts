using UnityEngine;
using System.Collections;
[RequireComponent (typeof (Controller2D))]
public class player : MonoBehaviour {

	Controller2D controller;

	void Start () {
		controller = GetComponent<Controller2D> ();
	}

	
	}
}
