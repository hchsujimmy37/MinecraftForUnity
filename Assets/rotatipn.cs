using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatipn : MonoBehaviour {
	public float speed_v = 2f;
	private float y_rot = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		y_rot -= speed_v * Input.GetAxis ("Mouse Y");
		transform.eulerAngles = new Vector3 (y_rot,0,0);
	}
}
