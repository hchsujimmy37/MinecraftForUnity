using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour {
    private AudioSource bgm;
    private bool isclip1 = true;
    private bool isplay = true; 
	// Use this for initialization
	void Start () {
        bgm = GetComponent<AudioSource>();
    }
    [SerializeField] AudioClip clip1;
    [SerializeField] AudioClip clip2;
    // Update is called once per frame
    void Update () {
		if(Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Hello");
           if(isplay)
            {
                bgm.Pause();
                isplay = false;
            }
            else
            {
                bgm.Play();
                isplay = true;
            }
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            if(bgm.isPlaying)
            {
                bgm.Stop();
            }
            if(isclip1)
            {
                bgm.clip = clip1;
                bgm.Play();
                isclip1 = false;
            }
            else if(isclip1==false)
            {
                bgm.clip = clip2;
                bgm.Play();
                isclip1 = true;
            }
        }
	}
}
