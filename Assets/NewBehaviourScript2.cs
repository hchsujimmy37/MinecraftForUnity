using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour {
	public Transform ground;
	public Vector3 Pos;
	// Use this for initialization
	void Start () {
		Transform new_ground = Instantiate (ground);
		new_ground.parent=transform;
		new_ground.gameObject.tag = "Ground";
		Pos.x = 3; Pos.y = 0; Pos.z = 0;
		new_ground.localPosition=Pos;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
