using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Animator))]
public class NewBehaviourScript : MonoBehaviour {
	// Use this for initialization
	Animator anime;
	private float moving_speed;
	public Transform actor;
	private bool isrun=false;
	void Start () {
		Debug.Log ("start");
		Transform t = GetComponent<Transform> ();
		mesh_renderer = GetComponent<MeshRenderer> ();
		anime = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
		isrun = false;
		anime.SetFloat ("Speed",0f);

		if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey (KeyCode.RightShift)) {
			moving_speed = 30f; isrun = true;
			anime.SetFloat ("Speed",moving_speed);
		}
		if (Input.GetKey (KeyCode.W)) {
			if (isrun != true) {
				moving_speed = 10f;
			}
			transform.localPosition += moving_speed * Time.deltaTime * transform.forward;
			anime.SetFloat ("Speed",moving_speed); 

		}
		if (Input.GetKey (KeyCode.S)) {
			if (isrun != true) {
				moving_speed = 10f;
			}
			transform.localPosition -= moving_speed * Time.deltaTime * transform.forward;
			anime.SetFloat ("Speed",moving_speed);
		}
		if (Input.GetKey (KeyCode.A)) {
			if (isrun != true) {
				moving_speed = 10f;
			}
			transform.localPosition -= moving_speed * Time.deltaTime * transform.right;
			anime.SetFloat ("Speed",moving_speed); 
		}
		if (Input.GetKey (KeyCode.D)) {
			if (isrun != true) {
				moving_speed = 10f;
			}
			transform.localPosition += moving_speed * Time.deltaTime * transform.right;
			anime.SetFloat ("Speed", moving_speed);
		}
		if (actor.localPosition.y < -200) {
			SceneManager.LoadScene(3);
		}

	}
	public Vector3 moving_vector;
	private MeshRenderer mesh_renderer;

}
