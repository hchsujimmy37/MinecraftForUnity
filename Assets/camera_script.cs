using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class camera_script : MonoBehaviour {
	public float speed_h = 2f;
	private float x_rot = 0f;
	public float speed_v = 2f;
	private float y_rot = 0f;
	public Transform C_1,C_3;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		x_rot += speed_h * Input.GetAxis ("Mouse X");
			y_rot -= speed_v * Input.GetAxis ("Mouse Y");
		transform.eulerAngles = new Vector3 (0,x_rot,0);
		C_1.eulerAngles = new Vector3 (y_rot,x_rot,0);
		C_3.eulerAngles = new Vector3 (y_rot,x_rot,0);
	}
}
