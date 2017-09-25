using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class talk3 : MonoBehaviour
{
    public GameObject player;
    public GameObject talkplayer;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, player.transform.position) < 3f && Input.GetKeyDown(KeyCode.A))
        {
            talkplayer.SetActive(true);

        }
        if (talkplayer.active == true && Input.GetKeyDown(KeyCode.Alpha9))
        {
            talkplayer.SetActive(false);
            
        }
    }
}
