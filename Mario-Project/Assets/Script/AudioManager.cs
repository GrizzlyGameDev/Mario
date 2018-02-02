﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

    public AudioSource BGM;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void playSoundEffect(AudioClip music) {
        BGM.clip = music;
        BGM.Play();
    }

    public void ChangeBGM(AudioClip music) {
        BGM.Stop();
        BGM.clip = music;
        BGM.Play();
    }
}