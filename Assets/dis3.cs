using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dis3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            Destroy(gameObject);
        }

    }
   
}
