using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slots : MonoBehaviour
{
    public bool haschildren;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (transform.childCount == 0)
        {
            haschildren = false;
        }
        else
        {
            haschildren = true;
        }
    }
}
