using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class create_cube : MonoBehaviour {
	public  Transform dirt;
	public Vector3 Pos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit raycasthit;
			if(Physics.Raycast(ray,out raycasthit)){
				Transform cube = Instantiate (dirt);
				if (raycasthit.collider.gameObject.tag=="Ground"||raycasthit.collider.gameObject.tag=="Cube") {
					Pos.x = Mathf.Floor (raycasthit.point.x) + cube.transform.localScale.x / 2;
					Pos.y = Mathf.Floor (raycasthit.point.y) + cube.transform.localScale.y / 2;
					Pos.z= Mathf.Floor (raycasthit.point.z) + cube.transform.localScale.z / 2;
					cube.transform.position = Pos;
					cube.gameObject.tag="Cube";
				}
			}
		}
	}
}
