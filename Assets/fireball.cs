using UnityEngine;
using System.Collections;

public class fireball : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletSpawn;
    public GameObject player;
    float countdown = -1;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, player.transform.position) < 5f)
        {
            countdown = countdown - Time.deltaTime;
            if (countdown < 0)
            {
                countdown = 0.5f;
                GameObject obj = (GameObject)Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
                obj.GetComponent<Rigidbody>().velocity = Vector3.right * 20;
                Destroy(obj, 5.0f);
            }
        }

    }
}