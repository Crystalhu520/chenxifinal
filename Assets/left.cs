using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left : MonoBehaviour {
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Animator>().SetBool("left", true);
        }
        else {
            GetComponent<Animator>().SetBool("left", false);
        }
    }
}
