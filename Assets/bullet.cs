using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bullet : MonoBehaviour {
    public GameObject bulletPrefab;
    public int ammo = 20;
    public Text txt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        txt.text = "" + ammo;
        if (Input.GetButtonDown("Fire1")&&ammo>0) {
            GameObject b = (GameObject)Instantiate(
                bulletPrefab,
                transform.position,
                transform.rotation  );
            ammo--;
            b.GetComponent<Rigidbody>().velocity = transform.forward*15;
        }
	}
   
}
