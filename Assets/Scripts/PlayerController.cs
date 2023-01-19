using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float step = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move rat
        if(Input.GetKeyDown("w"))
        {
            transform.Translate(0,0,step, Space.World);
        }
        if(Input.GetKeyDown("s"))
        {
            transform.Translate(0,0,-step, Space.World);
        }
        if(Input.GetKeyDown("d"))
        {
            transform.Translate(step,0,0, Space.World);
        }
        if(Input.GetKeyDown("a"))
        {
            transform.Translate(-step,0,0, Space.World);
        }
    }
}
