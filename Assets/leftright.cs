using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftright : MonoBehaviour {
    public bool left = true;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = gameObject.transform.position;
        gameObject.transform.position = pos;


        if (pos.z <-23  && left == true)
        {
            pos.z = pos.z + 0.1f;
            left = false;

        }else if (pos.z >-21 && left == false)
        {
          
            pos.z = pos.z - 0.1f;
            left = true;

        }

    }
}
