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
            Debug.Log("a � il numero pi� alto" + a);
        else
            Debug.Log("b � il numero pi� alto" + b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
