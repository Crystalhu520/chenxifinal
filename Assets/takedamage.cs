using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takedamage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        health p = other.GetComponent<health>();
        if (p != null) p.TakeDamagehuman();
    }
}
