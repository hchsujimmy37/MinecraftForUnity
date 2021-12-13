using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class escape : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        Scene cur_scene = SceneManager.GetActiveScene();
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Debug.Log("current scene name= " + cur_scene.name);
            Debug.Log("current scene build index= " + cur_scene.buildIndex);

            SceneManager.LoadScene(0);
        }
    }
}
