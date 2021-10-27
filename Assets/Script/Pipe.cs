using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float speed;
    public bool alive = true;
    // Update is called once per frame
    void Update()
    {
        if (alive == true)
        {
            transform.position -= Vector3.right * speed;
        }
        else
        {
            transform.position -= Vector3.right * 0;
        }
        
    }

    public void setalive()
    {
        alive = false;
    }
}
