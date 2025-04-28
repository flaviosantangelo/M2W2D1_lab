using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class script5 : MonoBehaviour
{
    public int a = 13;

    // Start is called before the first frame update
    void Start()
    {
        if (a % 2 == 0)
            Debug.Log("il numero è pari");
        else
            Debug.Log("il numero è dispari");
        if (a >= 10)
            Debug.Log("il numero è maggiore di 10");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
