using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class gunfire : MonoBehaviour
{
    public float damage = 10f;                                  // Number in seconds which controls how often the player can fire
    public float Range = 100f;                                     // Distance in Unity units over which the player can fire
    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public bool abc = false;
    public AudioClip fi;

    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Shoot();
            GetComponent<AudioSource>().PlayOneShot(fi);


        }
          

    }
    void Shoot() {
        muzzleFlash.Play();
        abc = true;

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, Range)) {
                Debug.Log(hit.transform.name);
                attackhealth  target = hit.transform.GetComponent<attackhealth>();   
           
        }
    }
    
}