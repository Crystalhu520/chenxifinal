using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class getpic : MonoBehaviour {
    public int pic = 0;
 
    public Image jackpic;
    public Text txt;
    bool getjackpic = false;

    // Use this for initialization
    void Start () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        getjackpic = true;
        Destroy(gameObject);

    }
    // Update is called once per frame
    void Update () {
        txt.text = "" + pic;
        if (getjackpic == true)
        {
            Color c = jackpic.color;
            c.a = 1f;
            jackpic.color = c;
            txt.text = pic+"X";
        }
        else {
            Color c = jackpic.color;
            c.a = 0f;
            jackpic.color = c;

        }



    }

}
