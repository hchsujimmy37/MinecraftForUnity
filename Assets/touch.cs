using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touch : MonoBehaviour {
	public Transform t;
	public Vector3 x;
	public GameObject life;
	// Use this for initialization
	void Start () {
		t = GetComponent<Transform> ();
		x=t.transform.position;
	}

	// Update is called once per frame
	void Update () {
		t = GetComponent<Transform> ();
		x = t.transform.position;
	}
	void OnCollisionEnter(Collision a){
		if (a.gameObject.tag=="Bomb"){
			t.transform.localPosition -= transform.forward*0.5f;
			life.GetComponent<health>().decreaseheart (2);
		}

	}
}
