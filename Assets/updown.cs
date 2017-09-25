using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class updown : MonoBehaviour {
    public bool up = true;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
         
        Vector3 pos = gameObject.transform.position;
        pos.y = pos.y + 0.1f;
        gameObject.transform.position = pos;
        Rigidbody rb = GetComponent<Rigidbody>();

        //rb.useGravity = false;

        if (pos.y > 9 && pos.y < 13 && up == true)
        {

            //Rigidbody rb = GetComponent<Rigidbody>();

            rb.useGravity = false;
            //pos.y = pos.y + 0.1f;
            up = false;

        }
        else if (pos.y > 13 && up == false)
        {
            //Rigidbody rb = GetComponent<Rigidbody>();

            rb.useGravity = true;
            rb.velocity = Vector3.zero;
            //pos.y = pos.y - 0.1f;
            up = true;

        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Destroy(gameObject);
        }
    }





}
