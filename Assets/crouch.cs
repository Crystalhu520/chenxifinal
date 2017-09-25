using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crouch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Animator>().SetBool("crouch", true);
        }
        else {
            GetComponent<Animator>().SetBool("crouch", false);
        }

    }
}
