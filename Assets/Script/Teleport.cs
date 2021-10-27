using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D p_collision)
    {
        if (p_collision.GetComponent<Pipe>() != null || p_collision.GetComponent<Check>() != null)
        {
            p_collision.transform.position = new Vector3(8f, p_collision.transform.position.y, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
