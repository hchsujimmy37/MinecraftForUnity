using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lighting_script : MonoBehaviour {
	public new Light light;
	private float light_time;
	public Vector3 pos;
	// Use this for initialization
	void Start () {
		light = GetComponent<Light>();
		light_time = 0;
	}

	// Update is called once per frame
	void Update () {
		light_time++;
		//Debug.Log (light_time);
		if (light_time >= 0 && light_time < 750) {
			light.transform.eulerAngles -= new Vector3 (0.12f, 0, 0);
		}
		else if (light_time >= 750 && light_time < 1500) {
			light.transform.eulerAngles -= new Vector3 (0.12f, 0, 0);
		}
		else if (light_time >= 1500 && light_time < 2250) {
			light.transform.eulerAngles += new Vector3 (0.12f, 0, 0);
		}
		else if (light_time >= 2250 && light_time < 3000) {
			light.transform.eulerAngles += new Vector3 (0.12f, 0, 0);
		}
		if (light_time == 3000) {
			light_time = 0;
		}
	}
}
