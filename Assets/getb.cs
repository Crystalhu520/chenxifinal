using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getb : MonoBehaviour {
    public health heal;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
       heal.healthhuman = 5;
        Destroy(gameObject);
    }
}
