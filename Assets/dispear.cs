using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dispear : MonoBehaviour {
    bool getkey = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }
    void OnTriggerEnter(Collider other)
    {

        getkey = true;
        Destroy(gameObject);
    }
 

}
