﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dispear2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            Destroy(gameObject);
        }
    }
}
