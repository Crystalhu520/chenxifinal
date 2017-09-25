using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class right : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Animator>().SetBool("right", true);
        }
        else {
            GetComponent<Animator>().SetBool("right", false);
        }
    }
}
