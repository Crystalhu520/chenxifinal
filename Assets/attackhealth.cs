using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackhealth : MonoBehaviour {

    public float health = 60f;

    void  Update()
    {
        if (health==0) {
            Destroy(gameObject,1f);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        health -= 20f;
    }

}
