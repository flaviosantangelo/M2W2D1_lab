using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script8 : MonoBehaviour
{
    public int a = 2;
    public int b = 3;
    void Start()
    {
       MaggioreFra2(a, b); 
    }

    public int MaggioreFra2(int a, int b)
    {
        int c;
        if (a > b)
        {
            Debug.Log("a è il numero più alto" + a);
            c = a;
        }
        else
        {
            Debug.Log("b è il numero più alto" + b);
            c = b;
        }
        return c;
            

    }
}
