﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Music : MonoBehaviour
{
     public AudioSource playMusic;
    // Start is called before the first frame update
    void Start()
    {
        playMusic = GetComponent<AudioSource>();
        playMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
