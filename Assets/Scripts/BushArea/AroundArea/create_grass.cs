using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_grass : MonoBehaviour {
    private Transform grass_type;
    private List<Transform> grass_group = new List<Transform>();
    
    // Use this for initialization
    void Start () {
        
	}
    //62.0 -1.8 -13.5
    //68.0 -1.8 -22.0
    void Awake() {
        
        //grass and flower
        for (int i = 3; i<9;++i) {
            string str = "grass_0";
            create(str+i.ToString(), 10000, 45.00f, 155.00f, 50.00f, -80.00f);
        }
        
    }
    void create(string object_name,int times,float x_min,float x_max,float z_min,float z_max) {
        grass_type = transform.Find(object_name);
        for (int i = 0; i < times; ++i)
        {
            Transform t;
            float x = Random.Range(x_min, x_max);
            float z = Random.Range(z_min, z_max);
            float y = Random.Range(-1.70f,-1.85f);
            Vector3 position = new Vector3(x, y, z);
            t = Instantiate(grass_type);
            t.parent = transform;
            t.position = position;
            grass_group.Add(t);
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
