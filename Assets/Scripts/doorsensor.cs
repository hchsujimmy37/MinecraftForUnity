﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorsensor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider c)
    {
        Debug.Log(c.transform.name);
    }
}
