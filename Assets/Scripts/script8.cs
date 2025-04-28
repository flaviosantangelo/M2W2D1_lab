using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script8 : MonoBehaviour
{
    // Start is called before the first frame update

    public int a = 2;
    public int b = 3;
    void Start()
    {
        if (a > b)
            Debug.Log("a è il numero più alto" + a);
        else
            Debug.Log("b è il numero più alto" + b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
