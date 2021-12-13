using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dirt : MonoBehaviour {
    public Transform[]  cur = new Transform[7];
    
    private Vector3 cur_pos;
    public float amp = 10f;
    public float freq = 10f;
    private int cols = 100;
    private int rows = 200;
    
    void Awake() {
        
    }
    // Use this for initialization
    void Start ()
    {
        cur_pos = transform.position;
        generate();
    }

    // Update is called once per frame
    void Update () {
		
	}
    
    void generate() {
        
        for (int i = 0;i< cols; ++i) {
            for (int j = 0; j<rows;++j) {
				int rnd = UnityEngine.Random.Range (0, 7);
                Transform new_cur = Instantiate(cur[rnd]);
				new_cur.gameObject.AddComponent<BoxCollider> ();
                new_cur.parent = transform;
				if(rnd==0) new_cur.gameObject.tag="Stone";
				else if(rnd==1) new_cur.gameObject.tag="Gold";
				else if(rnd==2) new_cur.gameObject.tag="Glass";
				else if(rnd==3) new_cur.gameObject.tag="Dirt";
				else if(rnd==4) new_cur.gameObject.tag="Brick";
				else if(rnd==5) new_cur.gameObject.tag="Log";
				else if(rnd==6) new_cur.gameObject.tag="Grass";
                float y = Mathf.PerlinNoise((cur_pos.x + i) / freq, (cur_pos.z + j) / freq) * amp;
                y = Mathf.Floor(y);
                new_cur.position = new Vector3(cur_pos.x+i,-4.0f+y,cur_pos.z+j);
                
            }
        }
    }
}
