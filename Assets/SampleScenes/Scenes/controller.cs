using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour {

    bool get = true;
    public control lr;
    public AudioClip bgm;
    public void disable()
    {
        gameObject.SetActive(false);
    }

    public void enable()
    {
        gameObject.SetActive(true);
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
        if (Input.GetKeyDown(KeyCode.UpArrow)&& get==true)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(Vector3.up * 450);
            rb.useGravity = true;
            get = false;
            lr.change= false;
            
        }
        if (gameObject.transform.position.y <2)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.useGravity = false;
            rb.velocity = Vector3.zero;
            Vector3 pos = gameObject.transform.position;
            pos.y = 2;
            gameObject.transform.position = pos;
            get = true;
            lr.change=true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        GetComponent<AudioSource>().PlayOneShot(bgm);
        SceneManager.LoadScene("surfer", LoadSceneMode.Single);
    }
}