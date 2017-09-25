using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour {

    public controller right;
    public controller middle;
    public controller left;
    enum Position { left, middle, right };
    public bool change = true;
    Position loc = Position.right;
    // Use this for initialization
    void Start()
    {
    
    }



    // Update is called once per frame
    void Update()
    {
        Vector3 pos = gameObject.transform.position;
        pos.z = pos.z + 0.25f;
        gameObject.transform.position = pos;
       if( Input.GetKeyDown(KeyCode.Alpha0)){
            SceneManager.LoadScene("DemoSceneFree", LoadSceneMode.Single);

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && change == true)
        {
            if (loc == Position.right)
            {
                loc = Position.middle;
            }
            else if (loc == Position.middle)
            {
                loc = Position.left;
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && change == true)
        {
            if (loc == Position.middle)
            {
                loc = Position.right;
            }
            else if (loc == Position.left)
            {
                loc = Position.middle;
            }
        }



        if (loc != Position.right)
        {
            right.disable();
        }
        if (loc != Position.middle)
        {
            middle.disable();
        }
        if (loc != Position.left)
        {
            left.disable();
        }


        if (loc == Position.right)
        {
            right.enable();
        }
        if (loc == Position.middle)
        {
            middle.enable();
        }
        if (loc == Position.left)
        {
            left.enable();
        }
    }
}
