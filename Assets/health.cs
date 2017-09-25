using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class health : MonoBehaviour {

    // Use this for initialization

    public float healthhuman = 6f;
    public Image bloodhurt;
    public AudioClip painclip;
    public GameObject ful;
    public GameObject obt;
    public GameObject haf;
    public GameObject low;
    public GameObject ded;
    
    void Update() {
        Color c = bloodhurt.color;
        c.a = c.a - 0.04f;
        bloodhurt.color = c;
        if (healthhuman == 5f)
        {
            ful.SetActive(true);
            obt.SetActive(false);
            haf.SetActive(false);
            low.SetActive(false);
            ded.SetActive(false);
        }
        if (healthhuman == 4f)
        {
            ful.SetActive(false);
            obt.SetActive(true);
            haf.SetActive(false);
            low.SetActive(false);
            ded.SetActive(false);
        }
        if (healthhuman == 3f)
        {
            ful.SetActive(false);
            obt.SetActive(false);
            haf.SetActive(true);
            low.SetActive(false);
            ded.SetActive(false);
        }
        if (healthhuman == 2f)
        {
            ful.SetActive(false);
            obt.SetActive(false);
            haf.SetActive(false);
            low.SetActive(true);
            ded.SetActive(false);
        }
        if (healthhuman == 1f)
        {
            ful.SetActive(false);
            obt.SetActive(false);
            haf.SetActive(false);
            low.SetActive(false);
            ded.SetActive(true);
        }
        if (healthhuman==0f) {
            SceneManager.LoadScene("shoot");
        }
    }
    public void TakeDamagehuman()
    {
        healthhuman = healthhuman - 1f;
        GetComponent<AudioSource>().PlayOneShot(painclip);
        Color c = bloodhurt.color;
        c.a = 1;
        bloodhurt.color = c;
    }

}
