using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explo : MonoBehaviour {
    public GameObject explosionPrefab;
    // Use this for initialization


    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        GameObject explosion = (GameObject)Instantiate(explosionPrefab, transform.position, transform.rotation);
        Destroy(explosion, 1.0f);




    }
}
