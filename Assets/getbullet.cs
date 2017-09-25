using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getbullet : MonoBehaviour {
    public bullet bulletSpawn;
 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other) {

        bulletSpawn.ammo += 20;
        Destroy(gameObject);
    }
}
