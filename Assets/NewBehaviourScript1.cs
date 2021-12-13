using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {
	public Camera cam1, cam2;
	// Use this for initialization
	void Awake () {
		cam2.enabled=false;
		cam1.enabled=true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			if (cam2.enabled == true&&cam1.enabled==false) {
				cam2.enabled = false;
				cam1.enabled = true;
			}
			else if (cam2.enabled == false&&cam1.enabled==true) {
				cam1.enabled = false;
				cam2.enabled = true;
			}
		}
	}
}
