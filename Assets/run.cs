﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour {
    public float runSpeed;
   
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Animator>().SetBool("isRunning", true);
        }else {
            GetComponent<Animator>().SetBool("isRunning", false);
        }

    }
}
