using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour {
    public float backSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Animator>().SetBool("back", true);
        }
        else {
            GetComponent<Animator>().SetBool("back", false);
        }

    }
}
