using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BushFloor : MonoBehaviour {
    public string[] floor_name = { "big_module_01", "big_module_01_02", "big_module_02", "big_module_02_02","big_module_03",
                                   "big_module_03_02","big_module_04", "big_module_04_02","big_module_05", "big_module_05_02"};
    public string resource_path = "Models/Environment/";
    private GameObject[] floor = new GameObject[20];
    System.Random rand = new System.Random();
    // Use this for initialization
	void Start () {
        /*
        for (int i = 0; i<10;++i) {
            floor_name[i] = resource_path + floor_name[i];
        }
        
        for (int i = 0 ; i <4 ; ++i) {
            for (int j = 0 ; j < 5;  ++j) {
                GameObject f = GameObject.CreatePrimitive(PrimitiveType.Plane);
                int r = rand.Next(0, 10);
                //f.AddComponent(Plane); 
                //Debug.Log(Resources.Load(floor_name[r]));
                
                Debug.Log(f.ToString());
                floor[5 * i + j] = f;
                
            }
        }
        */
    }

    // Update is called once per frame
    void Update () {
		
	}
}
