using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script9 : MonoBehaviour
{
    public int a = 32;
    public int b = 3;
    // Start is called before the first frame update
    void Start()
    {
        if (a < b)
            Debug.Log("a è il numero più piccolo" + a);
        else
            Debug.Log("b è il numero più piccolo" + b);
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
