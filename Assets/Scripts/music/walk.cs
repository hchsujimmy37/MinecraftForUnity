using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour {
    private AudioSource bgm;
    private bool isplaying=false;
    [SerializeField]
    AudioClip clip1;
    [SerializeField]
    AudioClip clip2;
    [SerializeField]
    AudioClip clip3;
    // Use this for initialization
    void Start () {
        bgm = GetComponent<AudioSource>();
        bgm.clip = clip1;
        bgm.Stop();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bgm.clip = clip3;
            bgm.Play();
        }

    }
}
