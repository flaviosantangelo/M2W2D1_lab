using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script9 : MonoBehaviour
{
    public int a = 32;
    public int b = 3;
    void Start()
    {
       MinoreFra2(a, b);
    }
    public int MinoreFra2(int a, int b)
    {
        int c;
        if (a < b)
        {
            Debug.Log("a � il numero pi� piccolo" + a);
            c = a;
        }
        else
        {
            Debug.Log("b � il numero pi� piccolo" + b);
            c = b;
        }
        return c;
    }
}