using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restart()
    {
        Player _player = FindObjectOfType<Player>();
        Pipe[] _pipe = FindObjectOfType<Pipe>();
        Check[] _check = FindObjectOfType<Check>();
    }
}
