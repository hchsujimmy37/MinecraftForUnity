using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class STARTBUTTON : MonoBehaviour,IPointerClickHandler{
    private GameObject obj;
    private AudioSource bgm;
    public void OnPointerClick(PointerEventData e)
    {
        Scene cur_scene = SceneManager.GetActiveScene();
        if (e.button == PointerEventData.InputButton.Left) {
            bgm.Pause();
            SceneManager.LoadScene(1);
        }
        
    }
	// Use this for initialization
	void Start () {
        obj = GameObject.Find("BackgroundMusic");
        bgm = obj.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
